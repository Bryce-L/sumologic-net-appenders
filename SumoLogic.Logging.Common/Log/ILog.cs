﻿/**
 *    _____ _____ _____ _____    __    _____ _____ _____ _____
 *   |   __|  |  |     |     |  |  |  |     |   __|     |     |
 *   |__   |  |  | | | |  |  |  |  |__|  |  |  |  |-   -|   --|
 *   |_____|_____|_|_|_|_____|  |_____|_____|_____|_____|_____|
 *
 *                UNICORNS AT WARP SPEED SINCE 2010
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
namespace SumoLogic.Logging.Common.Log
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Interface log.
    /// </summary>
    public interface ILog
    {           
        /// <summary>
        /// Gets a value indicating whether logging is enabled for the Trace level.
        /// </summary>
        /// <returns> A value of true if logging is enabled for the Trace level, otherwise it returns false.</returns>     
        bool IsTraceEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether logging is enabled for the Debug level.
        /// </summary>
        /// <returns> A value of true if logging is enabled for the Debug level, otherwise it returns false.</returns>     
        bool IsDebugEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether logging is enabled for the Info level.
        /// </summary>
        /// <returns> A value of true if logging is enabled for the Info level, otherwise it returns false.</returns>     
        bool IsInfoEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether logging is enabled for the Warn level.
        /// </summary>
        /// <returns> A value of true if logging is enabled for the Warn level, otherwise it returns false.</returns>     
        bool IsWarnEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether logging is enabled for the Error level.
        /// </summary>
        /// <returns> A value of true if logging is enabled for the Error level, otherwise it returns false.</returns>     
        bool IsErrorEnabled { get; }

        /// <summary>
        /// Logs the specified message with TRACE level.
        /// </summary>
        /// <param name="msg">The message.</param>
        void Trace(string msg);

        /// <summary>
        /// Logs the specified message with DEBUG level.
        /// </summary>
        /// <param name="msg">The message.</param>
        void Debug(string msg);

        /// <summary>
        /// Logs the specified message with INFO level.
        /// </summary>
        /// <param name="msg">The message.</param>
        void Info(string msg);

        /// <summary>
        /// Logs the specified message with WARN level.
        /// </summary>
        /// <param name="msg">The message.</param>
        void Warn(string msg);

        /// <summary>
        /// Logs the specified message with ERROR level.
        /// </summary>
        /// <param name="msg">The message.</param>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Error", Justification = "Common logger method name")]
        void Error(string msg);
    }
}
