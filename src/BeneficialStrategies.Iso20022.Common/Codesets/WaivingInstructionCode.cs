// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the form of the rebate when commission is waived.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y9uuAdp-Ed-ak6NoX_4Aeg_-1758874043")]
[Description(@"Specifies the form of the rebate when commission is waived.")]
[Derivations(typeof(WaivingInstruction2Code), typeof(WaivingInstruction1Code))]
public enum WaivingInstructionCode
{
    /// <summary>
    /// Form of commission waived is cash.
    /// Encoded/decoded by serializers as &quot;WICA&quot;.
    /// </summary>
    [EnumMember(Value = "WICA")]
    [IsoId("_Y9uuAtp-Ed-ak6NoX_4Aeg_165921005")]
    [Description(@"Form of commission waived is cash.")]
    WaiveInCash,

    /// <summary>
    /// Form of commission waived is additional units of a financial instrument.
    /// Encoded/decoded by serializers as &quot;WIUN&quot;.
    /// </summary>
    [EnumMember(Value = "WIUN")]
    [IsoId("_Y9uuA9p-Ed-ak6NoX_4Aeg_633220258")]
    [Description(@"Form of commission waived is additional units of a financial instrument.")]
    WaiveInUnits,

    /// <summary>
    /// Another type of commission waiving.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Y9uuBNp-Ed-ak6NoX_4Aeg_-268156093")]
    [Description(@"Another type of commission waiving.")]
    Other,
}
