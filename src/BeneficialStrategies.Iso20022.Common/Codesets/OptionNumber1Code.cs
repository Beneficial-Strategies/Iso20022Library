// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code identifying special corporate action option numbers.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aP1PGNp-Ed-ak6NoX_4Aeg_1091552149")]
[Description(@"Code identifying special corporate action option numbers.")]
[DerivedFrom(typeof(OptionNumberCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OptionNumber1Code>))]
#endif
public enum OptionNumber1Code
{
    /// <summary>
    /// The corporate action instruction is unsolicited, that is, the instruction has not been preceded by a corporate action notification.
    /// Encoded/decoded by serializers as &quot;UNSO&quot;.
    /// </summary>
    [EnumMember(Value = "UNSO")]
    [IsoId("_aP1PGdp-Ed-ak6NoX_4Aeg_6858494")]
    [Description(
        @"The corporate action instruction is unsolicited, that is, the instruction has not been preceded by a corporate action notification."
    )]
    Unsolicited = OptionNumberCode.Unsolicited, // same ordinal as derivation source for type conversions
}
