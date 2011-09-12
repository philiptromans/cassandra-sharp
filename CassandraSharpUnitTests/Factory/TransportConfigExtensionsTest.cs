﻿// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
// limitations under the License.
namespace CassandraSharpUnitTests.Factory
{
    using CassandraSharp.Config;
    using CassandraSharp.Factory;
    using CassandraSharp.Transport;
    using NUnit.Framework;

    [TestFixture]
    public class TransportConfigExtensionsTest
    {
        [Test]
        public void TestCreateBuffered()
        {
            TransportConfig config = new TransportConfig();
            config.Type = TransportConfig.TransportType.Buffered;

            ITransportFactory transport = config.Create();
            Assert.IsTrue(transport is BufferedTransportFactory);
        }

        [Test]
        public void TestCreateFramed()
        {
            TransportConfig config = new TransportConfig();
            config.Type = TransportConfig.TransportType.Framed;

            ITransportFactory transport = config.Create();
            Assert.IsTrue(transport is FramedTransportFactory);
        }
    }
}