using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;

namespace Clint_kursach3.Models
{
    public class WorkWithWord<T>
    {
        private T rep;
        private BindingList<Options> options;
        private BindingList<Options_Table> option_table;

        public WorkWithWord(ref T rep, BindingList<Options> options, BindingList<Options_Table> option_table)
        {
            this.rep = rep;
            this.options = options;
            this.option_table = option_table;
        }

        public void ToWord()
        {
            var word_app = new Word.Application();
            Word.Document word_doc = null;

            try
            {
                string filename = Directory.GetCurrentDirectory() + @"\rep.docx";
                word_app.Visible = false;
                word_doc = word_app.Documents.Open(filename);
                if (word_doc.Content.Find.Execute(FindText: "<table1>") && word_doc.Content.Find.Execute(FindText: "<table2>") && word_doc.Content.Find.Execute(FindText: "<text>"))
                {
                    ReplaceWordSub("<text>", rep.ToString(), word_doc);
                    CreateWordTable(word_doc, word_app);
                    word_doc.SaveAs2(Directory.GetCurrentDirectory() + @"\Отчет.docx");
                    word_app.Visible = true;
                }
                else
                {
                    throw new Exception("Один или несколько тегов не найдены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                word_doc.Close();
                word_app.Quit();
            }
        }



        private void CreateWordTable(Word.Document document, Word.Application word_app)
        {
            Word.Range wordrange = document.Content;

            wordrange.Find.ClearFormatting();
            wordrange.Find.Execute(FindText: "<table1>");
            var paragraph = wordrange.Paragraphs[1];

            Object defaultTableBehavior = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitWindow;
            Word.Table wordtable1 = document.Tables.Add(wordrange, option_table.Count + 1, options.Count + 3, ref defaultTableBehavior, ref autoFitBehavior);
            wordrange = document.Content;
            wordrange.Find.ClearFormatting();
            wordrange.Find.Execute(FindText: "<table2>");
            paragraph = wordrange.Paragraphs[1];
            Word.Table wordtable2 = document.Tables.Add(wordrange, options.Count + 1, 5, ref defaultTableBehavior, ref autoFitBehavior);
            Filliing_1(wordtable1);
            Filliing_2(wordtable2);
        }

        private void ReplaceWordSub(string stub_to_repl, string text, Word.Document document)
        {
            var range = document.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stub_to_repl, ReplaceWith: text);
        }

        private void Filliing_1(Word.Table wordtable1) ///заполнение первой таблицы
        {

            Word.Range wordcellrange;
            wordcellrange = wordtable1.Cell(1, 1).Range;
            wordcellrange.Text = "Эi";
            wordcellrange = wordtable1.Cell(1, 2).Range;
            wordcellrange.Text = "ri";
            wordcellrange = wordtable1.Cell(1, 3).Range;
            wordcellrange.Text = "DRi";
            for (int i = 0; i < wordtable1.Rows.Count; i++)
            {
                for (int j = 0; j < wordtable1.Columns.Count; j++)
                {
                    if (i == 0 && j > 2)
                    {
                        wordcellrange = wordtable1.Cell(i + 1, j + 1).Range;
                        wordcellrange.Text = "В" + (j - 2);
                    }
                    if (i != 0)
                    {
                        if (j < 3)
                        {
                            wordcellrange = wordtable1.Cell(i + 1, j + 1).Range;
                            wordcellrange.Text = option_table[i - 1].expert;
                            j++;
                            wordcellrange = wordtable1.Cell(i + 1, j + 1).Range;
                            wordcellrange.Text = option_table[i - 1].expert_rj;
                            j++;
                            wordcellrange = wordtable1.Cell(i + 1, j + 1).Range;
                            wordcellrange.Text = option_table[i - 1].expert_Drj;
                        }
                        else
                        {
                            wordcellrange = wordtable1.Cell(i + 1, j + 1).Range;
                            wordcellrange.Text = option_table[i - 1].Marks[j - 3];
                        }
                    }
                }
            }
        }

        private void Filliing_2(Word.Table wordtable2)///заполнение 2й таблицы
        {
            Word.Range wordcellrange;
            wordcellrange = wordtable2.Cell(1, 1).Range;
            wordcellrange.Text = "Номер варинта";
            wordcellrange = wordtable2.Cell(1, 2).Range;
            wordcellrange.Text = "Вариант";
            wordcellrange = wordtable2.Cell(1, 3).Range;
            wordcellrange.Text = "Описание";
            wordcellrange = wordtable2.Cell(1, 4).Range;
            wordcellrange.Text = "Ck";
            wordcellrange = wordtable2.Cell(1, 5).Range;
            wordcellrange.Text = "DCj";
            for (int i = 1; i < wordtable2.Rows.Count; i++)
            {

                for (int j = 0; j < wordtable2.Columns.Count; j++)
                {
                    wordcellrange = wordtable2.Cell(i + 1, j + 1).Range;
                    wordcellrange.Text = options[i - 1].Id.ToString();
                    j++;
                    wordcellrange = wordtable2.Cell(i + 1, j + 1).Range;
                    wordcellrange.Text = options[i - 1].Option;
                    j++;
                    wordcellrange = wordtable2.Cell(i + 1, j + 1).Range;
                    wordcellrange.Text = options[i - 1].Summary;
                    j++;
                    wordcellrange = wordtable2.Cell(i + 1, j + 1).Range;
                    wordcellrange.Text = options[i - 1].Ck.ToString();
                    j++;
                    wordcellrange = wordtable2.Cell(i + 1, j + 1).Range;
                    wordcellrange.Text = options[i - 1].DCj.ToString();
                }
            }
        }

    }
}
