﻿using System;

namespace Caliberweb.Core.IO.Csv
{
    class DateValue : CsvValue<DateTime>
    {
        public DateValue(string columnName, string stringValue) : base(columnName, stringValue)
        {}

        public override DateTime Value
        {
            get { return DateTime.Parse(stringValue); }
        }
    }
}