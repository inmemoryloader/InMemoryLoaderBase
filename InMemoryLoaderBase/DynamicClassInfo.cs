﻿//
// DynamicClassInfo.cs
//
// Author: Kay Stuckenschmidt
//
// Copyright (c) 2017 responsive-kaysta
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Reflection;

namespace InMemoryLoaderBase
{
    /// <inheritdoc />
    public class DynamicClassInfo : IDynamicClassInfo
    {
        /// <inheritdoc />
        public Type ClassType { get; set; }

        /// <inheritdoc />
        public Object ClassObject { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryLoaderBase.DynamicClassInfo"/> class.
        /// </summary>
        public DynamicClassInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryLoaderBase.DynamicClassInfo"/> class.
        /// </summary>
        /// <param name="paramType">Parameter type.</param>
        /// <param name="paramObject">Parameter object.</param>
        public DynamicClassInfo(Type paramType, Object paramObject)
        {
            ClassType = paramType;
            ClassObject = paramObject;
        }

        /// <inheritdoc />
        static MethodInfo[] _methods;

        /// <inheritdoc />
        public MethodInfo[] GetMethods()
        {
            return (_methods ?? (_methods = ClassType.GetMethods(BindingFlags.Public | BindingFlags.Instance)));
        }
    }
}