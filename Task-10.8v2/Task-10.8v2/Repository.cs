using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{
    internal class Repository
    {
        public Repository() { }

        public void CreateNewFileXLSX(string filePathAndName, string sheetName)
        {
            //Создаем фаил excel
            IWorkbook workbook = new XSSFWorkbook();

            //Создаем новый лист
            ISheet sheet = workbook.CreateSheet(sheetName);

            //Сохраняем документ excel
            using (FileStream fileStream = new FileStream(filePathAndName, FileMode.Create))
            {
                workbook.Write(fileStream, false);
            }
        }

        public void AddNewClientInFileXLSX(string filePathAndName, string sheetName, Client client)
        {
            //Открытие существующей рабочей книги
            IWorkbook workbook;

            using (FileStream fileStream = new FileStream(filePathAndName, FileMode.Open, FileAccess.Read))
            {
                workbook = new XSSFWorkbook(fileStream);
            }

            //Получение листа
            ISheet sheet = workbook.GetSheetAt(0);

            //Добавляем данные в ячейки
            IRow cells = sheet.CreateRow(0);
            cells.CreateCell(0).SetCellValue((IRichTextString)client);

            //Сохраняем документ excel
            using (FileStream fileStream = new FileStream(filePathAndName, FileMode.Create))
            {
                workbook.Write(fileStream, false);
            }
        }

        public void ReadFileXLSX(string filePathAndName)
        {
            //Открытие существующей рабочей книги
            IWorkbook workbook;

            using (FileStream fileStream = new FileStream(filePathAndName, FileMode.Open, FileAccess.Read))
            {
                workbook = new XSSFWorkbook(fileStream);
            }

            //Получение листа
            ISheet sheet = workbook.GetSheetAt(0);

            //Чтение данных из ячейки
            IRow row = sheet.GetRow(0);
            string cellValue = row.GetCell(0).StringCellValue;

            //Вывод данных в терминал
            Console.WriteLine(cellValue);
        }

        public void ReWriteDataInFileXLSX(string filePathAndName, int sheetForChanged, string changedTextOrObject)
        {
            //Открываем книгу и получаем лист
            IWorkbook workbook;

            using (FileStream fileStream = new FileStream(filePathAndName, FileMode.Open, FileAccess.Read))
            {
                workbook = new XSSFWorkbook(fileStream);
            }

            ISheet sheet = workbook.GetSheetAt(sheetForChanged);

            //Обновляем данные ячейки
            IRow row = sheet.GetRow(sheetForChanged);
            row.GetCell(0).SetCellValue(changedTextOrObject);

            //Сохраняем документ
            using (FileStream fileStream = new FileStream(filePathAndName, FileMode.Create))
            {
                workbook.Write(fileStream, false);
            }

        }
    }
}
