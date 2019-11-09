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

// This file was generated by GENERATOR

#nullable enable

#if !NO_INTEL_FORMATTER && !NO_FORMATTER
using System;

namespace Iced.Intel.IntelFormatterInternal {
	[Flags]
	enum InstrOpInfoFlags : ushort {
		None = 0x00000000,
		MemSize_Nothing = 0x00000001,
		ShowNoMemSize_ForceSize = 0x00000002,
		ShowMinMemSize_ForceSize = 0x00000004,
		BranchSizeInfoShift = 0x00000003,
		BranchSizeInfoMask = 0x00000001,
		BranchSizeInfo_Short = 0x00000008,
		SizeOverrideMask = 0x00000003,
		OpSizeShift = 0x00000004,
		OpSize16 = 0x00000010,
		OpSize32 = 0x00000020,
		OpSize64 = 0x00000030,
		AddrSizeShift = 0x00000006,
		AddrSize16 = 0x00000040,
		AddrSize32 = 0x00000080,
		AddrSize64 = 0x000000C0,
		IgnoreOpMask = 0x00000100,
		FarMnemonic = 0x00000200,
		JccNotTaken = 0x00000400,
		JccTaken = 0x00000800,
		BndPrefix = 0x00001000,
		IgnoreIndexReg = 0x00002000,
		IgnoreSegmentPrefix = 0x00004000,
		MnemonicIsDirective = 0x00008000,
	}
}
#endif
