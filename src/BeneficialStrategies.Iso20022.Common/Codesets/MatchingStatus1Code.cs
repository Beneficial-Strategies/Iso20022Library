// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the matching status of the instruction at the time the settlement instruction was sent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVDGQ9p-Ed-ak6NoX_4Aeg_132545126")]
[Description(
    @"Provides the matching status of the instruction at the time the settlement instruction was sent."
)]
[DerivedFrom(typeof(MatchingStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MatchingStatus1Code>))]
#endif
public enum MatchingStatus1Code
{
    /// <summary>
    /// Instruction has been matched.
    /// Encoded/decoded by serializers as &quot;MACH&quot;.
    /// </summary>
    [EnumMember(Value = "MACH")]
    [IsoId("_aVDGRNp-Ed-ak6NoX_4Aeg_189804200")]
    [Description(@"Instruction has been matched.")]
    Matched = MatchingStatusCode.Matched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_aVDGRdp-Ed-ak6NoX_4Aeg_234135671")]
    [Description(@"Instruction has not been matched.")]
    Unmatched = MatchingStatusCode.Unmatched, // same ordinal as derivation source for type conversions
}
