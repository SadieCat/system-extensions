﻿/**
 * System Extensions
 *
 *   Copyright (C) 2014-2016 Peter "SaberUK" Powell <petpow@saberuk.com>
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

using System;

namespace SystemExt.Extensions
{

    /// <summary>
    /// Extension methods for the <see cref="object"/> class.
    /// </summary>
    public static class System_Object
    {

        /// <summary>
        /// Attempt to execute a function and return the result or null if it throws an exception.
        /// </summary>
        /// <typeparam name="TReturn">
        /// The type of the return value.
        /// </typeparam>
        /// <typeparam name="TException">
        /// The exception type to catch.
        /// </typeparam>
        /// <param name="self">
        /// An instance of the <see cref="object"/> class.
        /// </param>
        /// <param name="function">
        /// A function to call.
        /// </param>
        /// <returns>
        /// Either the result of the <paramref name="function"/> function or null if it throws a <typeparamref name="TException"/>.
        /// </returns>
        public static TReturn TryCatch<TReturn, TException>(this object self, Func<TReturn> function)
            where TReturn : class
            where TException : Exception
        {
            try
            {
                return function();
            }
            catch (TException)
            {
                return null;
            }
        }
    }
}
