// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of standing instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPnIN9p-Ed-ak6NoX_4Aeg_977181318")]
[Description(@"Specifies the type of standing instruction.")]
[DerivedFrom(typeof(StandingInstructionGrossNetCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<StandingInstructionGrossNet1Code>))]
#endif
public enum StandingInstructionGrossNet1Code
{
    /// <summary>
    /// Gross payment.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_ZPnIONp-Ed-ak6NoX_4Aeg_1018738724")]
    [Description(@"Gross payment.")]
    Gross = StandingInstructionGrossNetCode.Gross, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net payment.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZPw5MNp-Ed-ak6NoX_4Aeg_1053834510")]
    [Description(@"Net payment.")]
    Net = StandingInstructionGrossNetCode.Net, // same ordinal as derivation source for type conversions
}
