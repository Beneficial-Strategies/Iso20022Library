// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the penalty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_M1fo0DkQEem897H7zB2RJg")]
[Description(@"Specifies the status of the penalty.")]
[Derivations(typeof(PenaltyStatus2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyStatusCode>))]
public enum PenaltyStatusCode
{
    /// <summary>
    /// Penalty is active for the party.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_O4n-MDkQEem897H7zB2RJg")]
    [Description(@"Penalty is active for the party.")]
    Active,

    /// <summary>
    /// Penalty could not be computed.
    /// Encoded/decoded by serializers as &quot;NCOM&quot;.
    /// </summary>
    [EnumMember(Value = "NCOM")]
    [IsoId("_PIQ8sDkQEem897H7zB2RJg")]
    [Description(@"Penalty could not be computed.")]
    NotComputed,

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_WFXRsDkQEem897H7zB2RJg")]
    [Description(@"Other. See Narrative.")]
    Other,

    /// <summary>
    /// Penalty has been re-included.
    /// Encoded/decoded by serializers as &quot;REIC&quot;.
    /// </summary>
    [EnumMember(Value = "REIC")]
    [IsoId("_PJ57cDkQEem897H7zB2RJg")]
    [Description(@"Penalty has been re-included.")]
    ReIncluded,

    /// <summary>
    /// Removal of a cash penalty where settlement cannot be performed for reasons that are independent from any of the CSD participants or the CSD.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_ZVYQ8DkQEem897H7zB2RJg")]
    [Description(
        @"Removal of a cash penalty where settlement cannot be performed for reasons that are independent from any of the CSD participants or the CSD."
    )]
    Removed,

    /// <summary>
    /// Penalty has been reallocated.
    /// Encoded/decoded by serializers as &quot;RLOC&quot;.
    /// </summary>
    [EnumMember(Value = "RLOC")]
    [IsoId("_bYEhcDkQEem897H7zB2RJg")]
    [Description(@"Penalty has been reallocated.")]
    Reallocated,

    /// <summary>
    /// Penalty has been switched.
    /// Encoded/decoded by serializers as &quot;SWIC&quot;.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_dzCvEDkQEem897H7zB2RJg")]
    [Description(@"Penalty has been switched.")]
    Switched,
}
