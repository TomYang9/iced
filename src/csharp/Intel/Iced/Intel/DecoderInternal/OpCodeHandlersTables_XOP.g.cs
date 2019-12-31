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

#if !NO_DECODER
namespace Iced.Intel.DecoderInternal {
	static partial class OpCodeHandlersTables_XOP {
#if HAS_SPAN
		static System.ReadOnlySpan<byte> GetSerializedTables() =>
#else
		static byte[] GetSerializedTables() =>
#endif
			new byte[] {
				// grp_XOP9_01
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x00,// Invalid

				// 1 = 0x01
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x84, 0x20,// XOP_Blcfill_r32_rm32
						0x00,// Invalid

				// 2 = 0x02
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x86, 0x20,// XOP_Blsfill_r32_rm32
						0x00,// Invalid

				// 3 = 0x03
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x88, 0x20,// XOP_Blcs_r32_rm32
						0x00,// Invalid

				// 4 = 0x04
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x8A, 0x20,// XOP_Tzmsk_r32_rm32
						0x00,// Invalid

				// 5 = 0x05
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x8C, 0x20,// XOP_Blcic_r32_rm32
						0x00,// Invalid

				// 6 = 0x06
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x8E, 0x20,// XOP_Blsic_r32_rm32
						0x00,// Invalid

				// 7 = 0x07
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x90, 0x20,// XOP_T1mskc_r32_rm32
						0x00,// Invalid

				// grp_XOP9_02
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x00,// Invalid

				// 1 = 0x01
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x92, 0x20,// XOP_Blcmsk_r32_rm32
						0x00,// Invalid

				// 2 = 0x02
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 6 = 0x06
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x94, 0x20,// XOP_Blci_r32_rm32
						0x00,// Invalid

				// 7 = 0x07
				0x00,// Invalid

				// grp_XOP9_12
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x22,// RdRq
							0x96, 0x20,// XOP_Llwpcb_r32
						0x00,// Invalid

				// 1 = 0x01
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x22,// RdRq
							0x98, 0x20,// XOP_Slwpcb_r32
						0x00,// Invalid

				// 2 = 0x02
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// grp_XOPA_12
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1B,// Hv_Ed_Id
							0xC9, 0x20,// XOP_Lwpins_r32_rm32_imm32
						0x00,// Invalid

				// 1 = 0x01
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1B,// Hv_Ed_Id
							0xCB, 0x20,// XOP_Lwpval_r32_rm32_imm32
						0x00,// Invalid

				// 2 = 0x02
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// XOP8
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x02,// Dup
					0x85, 0x01,// 133
					0x00,// Invalid

				// 133 = 0x85
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xE6, 0x1F,// XOP_Vpmacssww_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 134 = 0x86
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xE7, 0x1F,// XOP_Vpmacsswd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 135 = 0x87
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xE8, 0x1F,// XOP_Vpmacssdql_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 136 = 0x88
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// 142 = 0x8E
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xE9, 0x1F,// XOP_Vpmacssdd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 143 = 0x8F
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xEA, 0x1F,// XOP_Vpmacssdqh_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 144 = 0x90
				0x02,// Dup
					0x05,// 5
					0x00,// Invalid

				// 149 = 0x95
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xEB, 0x1F,// XOP_Vpmacsww_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 150 = 0x96
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xEC, 0x1F,// XOP_Vpmacswd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 151 = 0x97
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xED, 0x1F,// XOP_Vpmacsdql_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 152 = 0x98
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// 158 = 0x9E
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xEE, 0x1F,// XOP_Vpmacsdd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 159 = 0x9F
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xEF, 0x1F,// XOP_Vpmacsdqh_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 160 = 0xA0
				0x01,// Invalid2

				// 162 = 0xA2
				0x0A,// MandatoryPrefix2_1
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF0, 0x1F,// XOP_Vpcmov_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xF1, 0x1F,// XOP_Vpcmov_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xF2, 0x1F,// XOP_Vpcmov_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xF3, 0x1F,// XOP_Vpcmov_ymm_ymm_ymm_ymmm256

				// 163 = 0xA3
				0x0A,// MandatoryPrefix2_1
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF4, 0x1F,// XOP_Vpperm_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xF5, 0x1F,// XOP_Vpperm_xmm_xmm_xmm_xmmm128
							0x00,// Invalid

				// 164 = 0xA4
				0x01,// Invalid2

				// 166 = 0xA6
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF6, 0x1F,// XOP_Vpmadcsswd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 167 = 0xA7
				0x02,// Dup
					0x0F,// 15
					0x00,// Invalid

				// 182 = 0xB6
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF7, 0x1F,// XOP_Vpmadcswd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 183 = 0xB7
				0x02,// Dup
					0x09,// 9
					0x00,// Invalid

				// 192 = 0xC0
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x39,// VWIb_2
								0x4D,// XMM0
								0xF8, 0x1F,// XOP_Vprotb_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 193 = 0xC1
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x39,// VWIb_2
								0x4D,// XMM0
								0xF9, 0x1F,// XOP_Vprotw_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 194 = 0xC2
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x39,// VWIb_2
								0x4D,// XMM0
								0xFA, 0x1F,// XOP_Vprotd_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 195 = 0xC3
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x39,// VWIb_2
								0x4D,// XMM0
								0xFB, 0x1F,// XOP_Vprotq_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 196 = 0xC4
				0x02,// Dup
					0x08,// 8
					0x00,// Invalid

				// 204 = 0xCC
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0xFC, 0x1F,// XOP_Vpcomb_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 205 = 0xCD
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0xFD, 0x1F,// XOP_Vpcomw_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 206 = 0xCE
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0xFE, 0x1F,// XOP_Vpcomd_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 207 = 0xCF
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0xFF, 0x1F,// XOP_Vpcomq_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 208 = 0xD0
				0x02,// Dup
					0x1C,// 28
					0x00,// Invalid

				// 236 = 0xEC
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x80, 0x20,// XOP_Vpcomub_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 237 = 0xED
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x81, 0x20,// XOP_Vpcomuw_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 238 = 0xEE
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x82, 0x20,// XOP_Vpcomud_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 239 = 0xEF
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x83, 0x20,// XOP_Vpcomuq_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 240 = 0xF0
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// XOP9
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x00,// Invalid

				// 1 = 0x01
				0x08,// Group
					0x06,// ArrayReference
						0x00,// 0x0 = grp_XOP9_01

				// 2 = 0x02
				0x08,// Group
					0x06,// ArrayReference
						0x01,// 0x1 = grp_XOP9_02

				// 3 = 0x03
				0x02,// Dup
					0x0F,// 15
					0x00,// Invalid

				// 18 = 0x12
				0x08,// Group
					0x06,// ArrayReference
						0x02,// 0x2 = grp_XOP9_12

				// 19 = 0x13
				0x02,// Dup
					0x6D,// 109
					0x00,// Invalid

				// 128 = 0x80
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0x9A, 0x20,// XOP_Vfrczps_xmm_xmmm128
							0x00,// Invalid
						0x09,// W
							0x36,// VW_2
								0x6D,// YMM0
								0x9B, 0x20,// XOP_Vfrczps_ymm_ymmm256
							0x00,// Invalid

				// 129 = 0x81
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0x9C, 0x20,// XOP_Vfrczpd_xmm_xmmm128
							0x00,// Invalid
						0x09,// W
							0x36,// VW_2
								0x6D,// YMM0
								0x9D, 0x20,// XOP_Vfrczpd_ymm_ymmm256
							0x00,// Invalid

				// 130 = 0x82
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0x9E, 0x20,// XOP_Vfrczss_xmm_xmmm32
							0x00,// Invalid
						0x00,// Invalid

				// 131 = 0x83
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0x9F, 0x20,// XOP_Vfrczsd_xmm_xmmm64
							0x00,// Invalid
						0x00,// Invalid

				// 132 = 0x84
				0x02,// Dup
					0x0C,// 12
					0x00,// Invalid

				// 144 = 0x90
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xA0, 0x20,// XOP_Vprotb_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xA1, 0x20,// XOP_Vprotb_xmm_xmm_xmmm128
						0x00,// Invalid

				// 145 = 0x91
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xA2, 0x20,// XOP_Vprotw_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xA3, 0x20,// XOP_Vprotw_xmm_xmm_xmmm128
						0x00,// Invalid

				// 146 = 0x92
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xA4, 0x20,// XOP_Vprotd_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xA5, 0x20,// XOP_Vprotd_xmm_xmm_xmmm128
						0x00,// Invalid

				// 147 = 0x93
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xA6, 0x20,// XOP_Vprotq_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xA7, 0x20,// XOP_Vprotq_xmm_xmm_xmmm128
						0x00,// Invalid

				// 148 = 0x94
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xA8, 0x20,// XOP_Vpshlb_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xA9, 0x20,// XOP_Vpshlb_xmm_xmm_xmmm128
						0x00,// Invalid

				// 149 = 0x95
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xAA, 0x20,// XOP_Vpshlw_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xAB, 0x20,// XOP_Vpshlw_xmm_xmm_xmmm128
						0x00,// Invalid

				// 150 = 0x96
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xAC, 0x20,// XOP_Vpshld_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xAD, 0x20,// XOP_Vpshld_xmm_xmm_xmmm128
						0x00,// Invalid

				// 151 = 0x97
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xAE, 0x20,// XOP_Vpshlq_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xAF, 0x20,// XOP_Vpshlq_xmm_xmm_xmmm128
						0x00,// Invalid

				// 152 = 0x98
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xB0, 0x20,// XOP_Vpshab_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xB1, 0x20,// XOP_Vpshab_xmm_xmm_xmmm128
						0x00,// Invalid

				// 153 = 0x99
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xB2, 0x20,// XOP_Vpshaw_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xB3, 0x20,// XOP_Vpshaw_xmm_xmm_xmmm128
						0x00,// Invalid

				// 154 = 0x9A
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xB4, 0x20,// XOP_Vpshad_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xB5, 0x20,// XOP_Vpshad_xmm_xmm_xmmm128
						0x00,// Invalid

				// 155 = 0x9B
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xB6, 0x20,// XOP_Vpshaq_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xB7, 0x20,// XOP_Vpshaq_xmm_xmm_xmmm128
						0x00,// Invalid

				// 156 = 0x9C
				0x02,// Dup
					0x25,// 37
					0x00,// Invalid

				// 193 = 0xC1
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xB8, 0x20,// XOP_Vphaddbw_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 194 = 0xC2
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xB9, 0x20,// XOP_Vphaddbd_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 195 = 0xC3
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xBA, 0x20,// XOP_Vphaddbq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 196 = 0xC4
				0x01,// Invalid2

				// 198 = 0xC6
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xBB, 0x20,// XOP_Vphaddwd_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 199 = 0xC7
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xBC, 0x20,// XOP_Vphaddwq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 200 = 0xC8
				0x02,// Dup
					0x03,// 3
					0x00,// Invalid

				// 203 = 0xCB
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xBD, 0x20,// XOP_Vphadddq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 204 = 0xCC
				0x02,// Dup
					0x05,// 5
					0x00,// Invalid

				// 209 = 0xD1
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xBE, 0x20,// XOP_Vphaddubw_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 210 = 0xD2
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xBF, 0x20,// XOP_Vphaddubd_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 211 = 0xD3
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC0, 0x20,// XOP_Vphaddubq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 212 = 0xD4
				0x01,// Invalid2

				// 214 = 0xD6
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC1, 0x20,// XOP_Vphadduwd_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 215 = 0xD7
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC2, 0x20,// XOP_Vphadduwq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 216 = 0xD8
				0x02,// Dup
					0x03,// 3
					0x00,// Invalid

				// 219 = 0xDB
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC3, 0x20,// XOP_Vphaddudq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 220 = 0xDC
				0x02,// Dup
					0x05,// 5
					0x00,// Invalid

				// 225 = 0xE1
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC4, 0x20,// XOP_Vphsubbw_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 226 = 0xE2
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC5, 0x20,// XOP_Vphsubwd_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 227 = 0xE3
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC6, 0x20,// XOP_Vphsubdq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 228 = 0xE4
				0x02,// Dup
					0x1C,// 28
					0x00,// Invalid

				// XOPA
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// 16 = 0x10
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x14,// Gv_Ev_Id
							0xC7, 0x20,// XOP_Bextr_r32_rm32_imm32
						0x00,// Invalid

				// 17 = 0x11
				0x00,// Invalid

				// 18 = 0x12
				0x08,// Group
					0x06,// ArrayReference
						0x03,// 0x3 = grp_XOPA_12

				// 19 = 0x13
				0x02,// Dup
					0xED, 0x01,// 237
					0x00,// Invalid
			};
		const uint XOP8Index = 4;
		const uint XOP9Index = 5;
		const uint XOPAIndex = 6;
	}
}
#endif
