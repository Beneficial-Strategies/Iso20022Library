// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the status of the penalty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I6DmYB-JEeuwwezkzufkMw")]
[Description(@"Specifies the reason for the status of the penalty.")]
[DerivedFrom(typeof(PenaltyStatusReasonCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyStatusReason2Code>))]
public enum PenaltyStatusReason2Code
{
    /// <summary>
    /// Specifies that due to a specific corporate action, the security does no longer exists.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_VYrDMR-JEeuwwezkzufkMw")]
    [Description(@"Specifies that due to a specific corporate action, the security does no longer exists.")]
    CorporateAction = PenaltyStatusReasonCode.CorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty was removed because insolvency proceedings are opened against the failing participant.
    /// Encoded/decoded by serializers as &quot;INSO&quot;.
    /// </summary>
    [EnumMember(Value = "INSO")]
    [IsoId("_VSIWUR-JEeuwwezkzufkMw")]
    [Description(
        @"Penalty was removed becuase insolvency proceedings are opened against the failing participant."
    )]
    Insolvency = PenaltyStatusReasonCode.Insolvency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty is not computed because the settlement has been internalised.
    /// Encoded/decoded by serializers as &quot;INTS&quot;.
    /// </summary>
    [EnumMember(Value = "INTS")]
    [IsoId("_VMoLQR-JEeuwwezkzufkMw")]
    [Description(@"Penalty is not computed because the settlement has been internalised.")]
    InternalisedSettlement = PenaltyStatusReasonCode.InternalisedSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty is new.
    /// Encoded/decoded by serializers as &quot;NEWP&quot;.
    /// </summary>
    [EnumMember(Value = "NEWP")]
    [IsoId("_VHRKIR-JEeuwwezkzufkMw")]
    [Description(@"Penalty is new.")]
    NewPenalty = PenaltyStatusReasonCode.NewPenalty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty is not computed or removed because the security is not subject to penalties.
    /// Encoded/decoded by serializers as &quot;NOSU&quot;.
    /// </summary>
    [EnumMember(Value = "NOSU")]
    [IsoId("_b1LLkR-UEeuwwezkzufkMw")]
    [Description(@"Penalty is not computed or removed because the security is not subject to penalties.")]
    NotSubject = PenaltyStatusReasonCode.NotSubject, // same ordinal as derivation source for type conversions

    /// <summary>
    /// See narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VBnOER-JEeuwwezkzufkMw")]
    [Description(@"See narrative.")]
    Other = PenaltyStatusReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Re-allocation of a late matching fail penalty from the instructing party to the delivering/receiving party.
    /// Encoded/decoded by serializers as &quot;RALO&quot;.
    /// </summary>
    [EnumMember(Value = "RALO")]
    [IsoId("_U8Z98R-JEeuwwezkzufkMw")]
    [Description(
        @"Re-allocation of a late matching fail penalty from the instructing party to the delivering/receiving party."
    )]
    Reallocated = PenaltyStatusReasonCode.Reallocated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement on multiple platforms where one of the platforms is closed for settlement (either cash or securities).
    /// Encoded/decoded by serializers as &quot;SEMP&quot;.
    /// </summary>
    [EnumMember(Value = "SEMP")]
    [IsoId("_UmFvsR-JEeuwwezkzufkMw")]
    [Description(
        @"Settlement on multiple platforms where one of the platforms is closed for settlement (either cash or securities)."
    )]
    SettlementOnMultiplePlatforms = PenaltyStatusReasonCode.SettlementOnMultiplePlatforms, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty was removed because of ISIN suspension from settlement due to a reconciliation issue under Article 65 (2) and (6) of the RTS on CSD Requirements.
    /// Encoded/decoded by serializers as &quot;SESU&quot;.
    /// </summary>
    [EnumMember(Value = "SESU")]
    [IsoId("_UgbzoR-JEeuwwezkzufkMw")]
    [Description(
        @"Penalty was removed becuase of ISIN suspension from settlement due to a reconciliation issue under Article 65 (2) and (6) of the RTS on CSD Requirements."
    )]
    SettlementSuspended = PenaltyStatusReasonCode.SettlementSuspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty was removed because of ISIN suspension from trading.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_UPxhcR-JEeuwwezkzufkMw")]
    [Description(@"Penalty was removed becuase of ISIN suspension from trading.")]
    TradingSuspended = PenaltyStatusReasonCode.TradingSuspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty has been switched between the failing and non-failing party.
    /// Encoded/decoded by serializers as &quot;SWIC&quot;.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_UbOjgR-JEeuwwezkzufkMw")]
    [Description(@"Penalty has been switched between the failing and non-failing party.")]
    Switched = PenaltyStatusReasonCode.Switched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty was removed because there were technical impossibilities at the CSD level that prevent settlement.
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_UVuYcR-JEeuwwezkzufkMw")]
    [Description(
        @"Penalty was removed becuase there were thecnical imposssibilities at the CSD level that prevent settlement, such as: a failure of the infrastructure components, a cyber-attack, network problems."
    )]
    TechnicalImpossibilities = PenaltyStatusReasonCode.TechnicalImpossibilities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty has been updated.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_UJrggR-JEeuwwezkzufkMw")]
    [Description(@"Penalty has been updated.")]
    Updated = PenaltyStatusReasonCode.Updated, // same ordinal as derivation source for type conversions
}
