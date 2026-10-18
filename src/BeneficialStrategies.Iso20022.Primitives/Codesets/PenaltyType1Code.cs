// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of penalty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4qTh4DkPEem897H7zB2RJg")]
[Description(@"Specifies the type of penalty.")]
[DerivedFrom(typeof(PenaltyTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyType1Code>))]
public enum PenaltyType1Code
{
    /// <summary>
    /// Applies from the intended settlement date until the matching date.
    /// Encoded/decoded by serializers as &quot;LMFP&quot;.
    /// </summary>
    [EnumMember(Value = "LMFP")]
    [IsoId("_52vf0TkPEem897H7zB2RJg")]
    [Description(
        @"Applies from the intended settlement date until the matching date. The penalty is charged to the participant who was last to enter or modify the relevant settlement instruction (for example, ""accepted timestamp"" is later than the one of the counterparty's instruction) for the periods between the intended settlement date and the day of matching of the instruction."
    )]
    LateMatchingFailedPenalty = PenaltyTypeCode.LateMatchingFailedPenalty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalties apply to instructions that fail to settle on the intended settlement date.
    /// Encoded/decoded by serializers as &quot;SEFP&quot;.
    /// </summary>
    [EnumMember(Value = "SEFP")]
    [IsoId("_582u4TkPEem897H7zB2RJg")]
    [Description(
        @"Penalties apply to instructions that fail to settle on the intended settlement date. A settlement instruction that ""fails to settle on that business day"" must be understood as a settlement instruction that is not cancelled and remaining to be settled, fully or partially, by the time of the end of processing of the relevant cut-off."
    )]
    SettlementFailedPenalty = PenaltyTypeCode.SettlementFailedPenalty, // same ordinal as derivation source for type conversions
}
