/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

// ⚠️This file was generated by GENERATOR!🦹‍♂️

#nullable enable

namespace Iced.Intel {
	static class IcedConstants {
		internal const int MaxOpCount = 5;
		internal const int MaxInstructionLength = 15;
		internal const int RegisterBits = 8;
		internal const int NumberOfCodeValues = 4236;
		internal const int NumberOfRegisters = 249;
		internal const int NumberOfMemorySizes = 138;
		internal const int NumberOfEncodingKinds = 5;
		internal const int NumberOfOpKinds = 26;
		internal const int NumberOfCodeSizes = 4;
		internal const int NumberOfRoundingControlValues = 5;
		internal const Register VMM_first = Register.ZMM0;
		internal const Register VMM_last = Register.ZMM31;
		internal const int VMM_count = 32;
		internal const Register XMM_last = Register.XMM31;
		internal const Register YMM_last = Register.YMM31;
		internal const Register ZMM_last = Register.ZMM31;
		internal const Register TMM_last = Register.TMM7;
		internal const int MaxCpuidFeatureInternalValues = 156;
		internal const MemorySize FirstBroadcastMemorySize = MemorySize.Broadcast64_UInt32;
	}
}
