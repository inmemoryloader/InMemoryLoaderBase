﻿// -------------------------------------------------------------------------------------------------------------------
// Filename: IDynamicClassSetup.cs
// Author: Kay Stuckenschmidt
//
// Copyright (c) 2019 responsive IT
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
// -------------------------------------------------------------------------------------------------------------------

namespace InMemoryLoaderBase
{
    /// <summary>
    /// This interface is needed to initialize and instatiate an InMemoryLoader-Component
    /// </summary>
	public interface IDynamicClassSetup
	{
        /// <summary>
        /// Full path of the assembly
        /// </summary>
        /// <value>The assembly.</value>
        string Assembly { get; set; }

        /// <summary>
        /// The class used as a component
        /// </summary>
        /// <value>The class.</value>
        string Class { get; set; }

        /// <summary>
        /// The init method, usualy Init
        /// </summary>
        /// <value>The init method.</value>
		string InitMethod { get; }
	}
}