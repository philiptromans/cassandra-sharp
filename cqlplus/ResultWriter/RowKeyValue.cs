﻿// cassandra-sharp - a .NET client for Apache Cassandra
// Copyright (c) 2011-2012 Pierre Chalamet
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace cqlplus.ResultWriter
{
    using System.Collections.Generic;
    using System.IO;

    public class RowKeyValue : IResultWriter
    {
        public void Write(TextWriter txtWriter, IEnumerable<IDictionary<string, object>> rowSet)
        {
            int rowNum = 0;
            foreach (var row in rowSet)
            {
                txtWriter.Write("{0,-2}: ", rowNum++);
                string offset = "";
                foreach (var col in row)
                {
                    string sValue = ValueFormatter.Format(col.Value);
                    txtWriter.WriteLine("{0}{1} : {2} ", offset, col.Key, sValue);
                    offset = "    ";
                }
                txtWriter.WriteLine();
            }
        }
    }
}