// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the form of the rebate when commission is waived.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y9k9B9p-Ed-ak6NoX_4Aeg_-1179652008")]
[Description(@"Specifies the form of the rebate when commission is waived.")]
[DerivedFrom(typeof(WaivingInstructionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<WaivingInstruction1Code>))]
#endif
public enum WaivingInstruction1Code
{
    /// <summary>
    /// Form of commission waived is cash.
    /// Encoded/decoded by serializers as &quot;WICA&quot;.
    /// </summary>
    [EnumMember(Value = "WICA")]
    [IsoId("_Y9k9CNp-Ed-ak6NoX_4Aeg_1408944804")]
    [Description(@"Form of commission waived is cash.")]
    WaiveInCash = WaivingInstructionCode.WaiveInCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Form of commission waived is additional units of a financial instrument.
    /// Encoded/decoded by serializers as &quot;WIUN&quot;.
    /// </summary>
    [EnumMember(Value = "WIUN")]
    [IsoId("_Y9uuANp-Ed-ak6NoX_4Aeg_1408944916")]
    [Description(@"Form of commission waived is additional units of a financial instrument.")]
    WaiveInUnits = WaivingInstructionCode.WaiveInUnits, // same ordinal as derivation source for type conversions
}
