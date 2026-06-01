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
[IsoId("_pLYVwDkPEem897H7zB2RJg")]
[Description(@"Specifies the type of penalty.")]
[Derivations(typeof(PenaltyType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyTypeCode>))]
public enum PenaltyTypeCode
{
    /// <summary>
    /// Applies from the intended settlement date until the matching date.
    /// Encoded/decoded by serializers as &quot;LMFP&quot;.
    /// </summary>
    [EnumMember(Value = "LMFP")]
    [IsoId("_rruLkDkPEem897H7zB2RJg")]
    [Description(
        @"Applies from the intended settlement date until the matching date. The penalty is charged to the participant who was last to enter or modify the relevant settlement instruction."
    )]
    LateMatchingFailedPenalty,

    /// <summary>
    /// Penalties apply to instructions that fail to settle on the intended settlement date.
    /// Encoded/decoded by serializers as &quot;SEFP&quot;.
    /// </summary>
    [EnumMember(Value = "SEFP")]
    [IsoId("_rmgUYDkPEem897H7zB2RJg")]
    [Description(
        @"Penalties apply to instructions that fail to settle on the intended settlement date. A settlement instruction that fails to settle must be understood as a settlement instruction that is not cancelled and remaining to be settled, fully or partially, by the time of the end of processing of the relevant cut-off."
    )]
    SettlementFailedPenalty,
}
