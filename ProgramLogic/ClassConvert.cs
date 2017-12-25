using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
   public  class ClassConvert
    {
        // Функция конвертирует строку в значение T
        // (при невозможности конвертации происходит ошибка)
        public static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

        // Функция конвертирует строку в массив элементов T
        // (при невозможности конвертации происходит ошибка)
        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }

        // Функция конвертирует массив элементов T в строку
        // (вторым параметром можно указать разделитель, по умолчанию ", ")
        public static string ArrayToStr<T>(T[] arr, string separator = ", ")
        {
            return arr == null ? "null" : String.Join(separator, arr);

        }
        //из строки в лист
        public static List<T> StrToList<T>(string str)
        {
            return new List<T>(Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)));
        }

        //из листа в строку
        public static string ListToStr<T>(IList<T> list, string separator = ", ")
        {
            return list.Count == 0 ? "null" : string.Join(separator, list.ToArray());
        }
    }
}
