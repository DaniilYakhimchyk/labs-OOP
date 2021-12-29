using System.Text.RegularExpressions;

namespace Laba9
{
    public static class StringEditor
    {
        public static string RemovePunctuation(string str) //удаление знаков
        {
            return Regex.Replace(str, "[.,;:]", string.Empty);//регулярное выражение
        }

        public static string AddExclamationMark(string str) //добавление символа
        {
            return str + "!";
        }

        public static string ToUpper(string str) //верхний регитср
        {
            return str.ToUpper();
        }

        public static string ToLower(string str) //нижний регистр
        {
            return str.ToLower();
        }

        public static string RemoveSpace(string str)// удаление пробелов
        {
            return str.Replace(" ", string.Empty);
        }
    }
}