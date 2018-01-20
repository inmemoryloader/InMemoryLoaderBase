//
// TestHelper.cs
//
// Author: Kay Stuckenschmidt <mailto.kaysta@gmail.com>
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
using InMemoryLoaderBase;
using InMemoryLoaderBase.HelperEnum;

namespace InMemoryLoaderBaseNunit
{
    /// <summary>
    /// Test helper.
    /// </summary>
    internal class TestHelper : IAbstractComponent
    {
        internal readonly string AppKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryLoaderBaseNunit.TestHelper"/> class.
        /// </summary>
        internal TestHelper ()
        {
            AppKey = AbstractComponent.Key;
        }

        public bool Init (string paramArgument)
        {
            return AppKey.Equals (paramArgument);
        }

        internal bool IterateDateInterval ()
        {
            var values = Enum.GetValues (typeof (DateInterval));
            return values.Length > 1;
        }

        internal bool IterateDateTimeAmPmType ()
        {
            var values = Enum.GetValues (typeof (DateTimeAmPmType));
            return values.Length > 1;
        }

        internal bool IterateFileCompareMethod ()
        {
            var values = Enum.GetValues (typeof (FileCompareMethod));
            return values.Length > 1;
        }

        internal bool IterateHashAlgorithmKind ()
        {
            var values = Enum.GetValues (typeof (HashAlgorithmKind));
            return values.Length > 1;
        }

        internal bool IterateStringDirection ()
        {
            var values = Enum.GetValues (typeof (StringDirection));
            return values.Length > 1;
        }

    }

}