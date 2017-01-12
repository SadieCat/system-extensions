﻿/**
 * System Extensions
 *
 *   Copyright (C) 2014-2017 Peter "SaberUK" Powell <petpow@saberuk.com>
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
 * in compliance with the License. You may obtain a copy of the License at
 *
 *   https://www.apache.org/licenses/LICENSE-2.0.html
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the License
 * is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and limitations under
 * the License.
 */

using SystemExt.Log;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SystemExt.Tests.Log
{

    /// <summary>
    /// Implements tests for the <see cref="LoggerInfo"/> class.
    /// </summary>
    [TestClass]
    public sealed class LoggerInfo_Test
    {

        /// <summary>
        /// Test the <see cref="LoggerInfo.CanLog"/> method.
        /// </summary>
        [TestMethod]
        public void CanLog()
        {
            var info = new LoggerInfo("FOO", LogLevel.Warning, null);

            // Test we get the correct response for each level.
            for (var level = LogLevel.None; level <= LogLevel.Verbose; level++)
            {
                Assert.AreEqual(info.CanLog(level, "FOO"), level <= LogLevel.Warning);
            }

            // Test we always get a falsy value when logging to a type not in the filter.
            for (var level = LogLevel.None; level <= LogLevel.Verbose; level++)
            {
                Assert.IsFalse(info.CanLog(level, "BAR"));
            }
        }
    }
}
