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

#if !NO_INSTR_INFO
namespace Iced.Intel {
	/// <summary>Flow control</summary>
	public enum FlowControl {
		/// <summary>The next instruction that will be executed is the next instruction in the instruction stream</summary>
		Next,
		/// <summary>It&apos;s an unconditional branch instruction: <c>JMP NEAR</c>, <c>JMP FAR</c></summary>
		UnconditionalBranch,
		/// <summary>It&apos;s an unconditional indirect branch: <c>JMP NEAR reg</c>, <c>JMP NEAR [mem]</c>, <c>JMP FAR [mem]</c></summary>
		IndirectBranch,
		/// <summary>It&apos;s a conditional branch instruction: <c>Jcc SHORT</c>, <c>Jcc NEAR</c>, <c>LOOP</c>, <c>LOOPcc</c>, <c>JRCXZ</c></summary>
		ConditionalBranch,
		/// <summary>It&apos;s a return instruction: <c>RET NEAR</c>, <c>RET FAR</c>, <c>IRET</c>, <c>SYSRET</c>, <c>SYSEXIT</c>, <c>RSM</c>, <c>VMLAUNCH</c>, <c>VMRESUME</c>, <c>VMRUN</c>, <c>SKINIT</c></summary>
		Return,
		/// <summary>It&apos;s a call instruction: <c>CALL NEAR</c>, <c>CALL FAR</c>, <c>SYSCALL</c>, <c>SYSENTER</c>, <c>VMCALL</c>, <c>VMMCALL</c></summary>
		Call,
		/// <summary>It&apos;s an indirect call instruction: <c>CALL NEAR reg</c>, <c>CALL NEAR [mem]</c>, <c>CALL FAR [mem]</c></summary>
		IndirectCall,
		/// <summary>It&apos;s an interrupt instruction: <c>INT n</c>, <c>INT3</c>, <c>INT1</c>, <c>INTO</c></summary>
		Interrupt,
		/// <summary>It&apos;s <c>XBEGIN</c>, <c>XABORT</c> or <c>XEND</c></summary>
		XbeginXabortXend,
		/// <summary>It&apos;s an invalid instruction, eg. <see cref="Code.INVALID"/>, <c>UD0</c>, <c>UD1</c>, <c>UD2</c></summary>
		Exception,
	}
}
#endif
