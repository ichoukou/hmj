﻿using System;

namespace Hmj.Common.Exceptions
{
    [Serializable]
    public class NoPermissionExecption : Exception
    {
        public NoPermissionExecption()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoPermissionExecption"/> class.
        /// </summary>
        /// <param name="message">异常消息.</param>
        public NoPermissionExecption(string message)
            : base(message)
        { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoPermissionExecption"/> class.
        /// </summary>
        /// <param name="message">异常消息.</param>
        /// <param name="inner">内部异常.</param>
        public NoPermissionExecption(string message, Exception inner)
            : base(message, inner)
        { }
    }
}