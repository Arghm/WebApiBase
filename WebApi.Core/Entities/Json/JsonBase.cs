using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WebApi.Core
{
    public abstract class JsonBase<T>
    {
        #region метода проверки, конвертации данных
        protected string ToTitleCase(string name)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower()).Trim();
        }
        #endregion

        /// <summary>
        /// Преобразование в Dto класс
        /// </summary>
        public abstract T ToDtoClass();
    }
}
