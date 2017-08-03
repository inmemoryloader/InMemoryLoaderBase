﻿//
// HashAlgorithmKind.cs
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

namespace InMemoryLoaderBase
{
	/// <summary>
	/// Aufzählung für die unterstützten Hashing-Algorithmen
	/// </summary>
	public enum HashAlgorithmKind
	{
		/// <summary>
		/// MD5-Verfahren, das einen Hash mit einer Länge von 128 Bit erzeugt
		/// </summary>
		MD5,

		/// <summary>
		/// CNG-(Cryptography Next Generation)Implementierung des MD5-Verfahrens
		/// </summary>
		MD5Cng,

		/// <summary>
		/// RIPEMD-Verfahren, das einen Hash mit einer Länge von 160 Bit erzeugt
		/// </summary>
		/// <remarks>
		/// Entwickelt als Ersatz für MD4 und MD5
		/// </remarks>
		RIPEMD160,

		/// <summary>
		/// SHA-Verfahren, das einen Hash mit einer Länge von 160 Bit erzeugt
		/// </summary>
		SHA1,

		/// <summary>
		/// CNG (Cryptography Next Generation)-Implementierung des SHA-Verfahrens
		/// </summary>
		SHA1Cng,

		/// <summary>
		/// SHA-Verfahren, das einen Hash mit einer Länge von 256 Bit erzeugt
		/// </summary>
		SHA256,

		/// <summary>
		/// CNG (Cryptography Next Generation)-Implementierung des SHA256-Verfahrens
		/// </summary>
		SHA256Cng,

		/// <summary>
		/// SHA-Verfahren, das einen Hash mit einer Länge von 384 Bit erzeugt
		/// </summary>
		SHA384,

		/// <summary>
		/// CNG (Cryptography Next Generation)-Implementierung des SHA384-Verfahrens
		/// </summary>
		SHA384Cng,

		/// <summary>
		/// SHA-Verfahren, das einen Hash mit einer Länge von 512 Bit erzeugt
		/// </summary>
		SHA512,

		/// <summary>
		/// CNG (Cryptography Next Generation)-Implementierung des SHA512-Verfahrens
		/// </summary>
		SHA512Cng,

		/// <summary>
		/// Hash-based Message Authentication Code (HMAC) über das RIPEMD160-Verfahren
		/// </summary>
		/// <remarks>
		/// HMAC verwendet einen privaten Schlüssel, der mit den Daten vermischt wird.
		/// Das Ergebnis wird über das Hashing-Verfahren in einem Hash umgewandelt,
		/// der Hashcode wird wieder mit dem privaten Schlüssel vermengt und die
		/// Hashfunktion wird ein zweites Mal auf diese Datenmenge angewendet.
		/// HMACMD5 verwendet das MD5-Verfahren, das einen Hash der Länge 128 Bit erzeugt.
		/// </remarks>
		HMACMD5,

		/// <summary>
		/// Hash-based Message Authentication Code (HMAC) über das RIPEMD160-Verfahren
		/// </summary>
		/// <remarks>
		/// HMAC verwendet einen privaten Schlüssel, der mit den Daten vermischt wird.
		/// Das Ergebnis wird über das Hashing-Verfahren in einem Hash umgewandelt,
		/// der Hashcode wird wieder mit dem privaten Schlüssel vermengt und die
		/// Hashfunktion wird ein zweites Mal auf diese Datenmenge angewendet.
		/// HMACRIPEMD160 verwendet das RIPEMD160-Verfahren, das einen Hash der Länge 160 Bit erzeugt.
		/// </remarks>
		HMACRIPEMD160,

		/// <summary>
		/// Hash-based Message Authentication Code (HMAC) über das SHA1-Verfahren
		/// </summary>
		/// <remarks>
		/// HMAC verwendet einen privaten Schlüssel, der mit den Daten vermischt wird.
		/// Das Ergebnis wird über das Hashing-Verfahren in einem Hash umgewandelt,
		/// der Hashcode wird wieder mit dem privaten Schlüssel vermengt und die
		/// Hashfunktion wird ein zweites Mal auf diese Datenmenge angewendet.
		/// HMACSHA1 verwendet das SHA1-Verfahren, das einen Hash der Länge 160 Bit erzeugt.
		/// </remarks>
		HMACSHA1,

		/// <summary>
		/// Hash-based Message Authentication Code (HMAC) über das SHA256-Verfahren
		/// </summary>
		/// <remarks>
		/// HMAC verwendet einen privaten Schlüssel, der mit den Daten vermischt wird.
		/// Das Ergebnis wird über das Hashing-Verfahren in einem Hash umgewandelt,
		/// der Hashcode wird wieder mit dem privaten Schlüssel vermengt und die
		/// Hashfunktion wird ein zweites Mal auf diese Datenmenge angewendet.
		/// HMACSHA256 verwendet das SHA1-Verfahren, das einen Hash der Länge 256 Bit erzeugt.
		/// </remarks>
		HMACSHA256,

		/// <summary>
		/// Hash-based Message Authentication Code (HMAC) über das SHA384-Verfahren
		/// </summary>
		/// <remarks>
		/// HMAC verwendet einen privaten Schlüssel, der mit den Daten vermischt wird.
		/// Das Ergebnis wird über das Hashing-Verfahren in einem Hash umgewandelt,
		/// der Hashcode wird wieder mit dem privaten Schlüssel vermengt und die
		/// Hashfunktion wird ein zweites Mal auf diese Datenmenge angewendet.
		/// HMACSHA384 verwendet das SHA1-Verfahren, das einen Hash der Länge 384 Bit erzeugt.
		/// </remarks>
		HMACSHA384,

		/// <summary>
		/// Hash-based Message Authentication Code (HMAC) über das SHA512-Verfahren
		/// </summary>
		/// <remarks>
		/// HMAC verwendet einen privaten Schlüssel, der mit den Daten vermischt wird.
		/// Das Ergebnis wird über das Hashing-Verfahren in einem Hash umgewandelt,
		/// der Hashcode wird wieder mit dem privaten Schlüssel vermengt und die
		/// Hashfunktion wird ein zweites Mal auf diese Datenmenge angewendet.
		/// HMACSHA512 verwendet das SHA1-Verfahren, das einen Hash der Länge 512 Bit erzeugt.
		/// </remarks>
		HMACSHA512,

		/// <summary>
		/// Message Authentication Code (MAC) über das TripleDES-Verfahren
		/// </summary>
		/// <remarks>
		/// MACTripleDES setzt das TripleDES-Verfahren ein und erzeugt eunen Hash von 
		/// 64 Bit Länge
		/// </remarks>
		MACTripleDES
	}
}