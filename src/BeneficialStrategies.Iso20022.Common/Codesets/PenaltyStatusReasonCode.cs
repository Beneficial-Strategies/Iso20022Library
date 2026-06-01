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
[IsoId("_FCpP_B-JEeuwwezkzufkMw")]
[Description(@"Specifies the reason for the status of the penalty.")]
[Derivations(typeof(PenaltyStatusReason2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyStatusReasonCode>))]
public enum PenaltyStatusReasonCode
{
    /// <summary>
    /// Specifies that due to a specific corporate action, the security does no longer exists.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_FCpQBx-JEeuwwezkzufkMw")]
    [Description(@"Specifies that due to a specific corporate action, the security does no longer exists.")]
    CorporateAction,

    /// <summary>
    /// Penalty was removed because insolvency proceedings are opened against the failing participant.
    /// Encoded/decoded by serializers as &quot;INSO&quot;.
    /// </summary>
    [EnumMember(Value = "INSO")]
    [IsoId("_FCpQAR-JEeuwwezkzufkMw")]
    [Description(
        @"Penalty was removed becuase insolvency proceedings are opened against the failing participant."
    )]
    Insolvency,

    /// <summary>
    /// Penalty is not computed because the settlement has been internalised.
    /// Encoded/decoded by serializers as &quot;INTS&quot;.
    /// </summary>
    [EnumMember(Value = "INTS")]
    [IsoId("_RHrIER-JEeuwwezkzufkMw")]
    [Description(@"Penalty is not computed because the settlement has been internalised.")]
    InternalisedSettlement,

    /// <summary>
    /// Penalty is new.
    /// Encoded/decoded by serializers as &quot;NEWP&quot;.
    /// </summary>
    [EnumMember(Value = "NEWP")]
    [IsoId("_FCpQAB-JEeuwwezkzufkMw")]
    [Description(@"Penalty is new.")]
    NewPenalty,

    /// <summary>
    /// Penalty is not computed or removed because the security is not subject to penalties.
    /// Encoded/decoded by serializers as &quot;NOSU&quot;.
    /// </summary>
    [EnumMember(Value = "NOSU")]
    [IsoId("_UavaUB-UEeuwwezkzufkMw")]
    [Description(@"Penalty is not computed or removed because the security is not subject to penalties.")]
    NotSubject,

    /// <summary>
    /// See narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_FCpP_h-JEeuwwezkzufkMw")]
    [Description(@"See narrative.")]
    Other,

    /// <summary>
    /// Re-allocation of a late matching fail penalty from the instructing party to the delivering/receiving party.
    /// Encoded/decoded by serializers as &quot;RALO&quot;.
    /// </summary>
    [EnumMember(Value = "RALO")]
    [IsoId("_FCpQAx-JEeuwwezkzufkMw")]
    [Description(
        @"Re-allocation of a late matching fail penalty from the instructing party to the delivering/receiving party."
    )]
    Reallocated,

    /// <summary>
    /// Settlement on multiple platforms where one of the platforms is closed for settlement (either cash or securities).
    /// Encoded/decoded by serializers as &quot;SEMP&quot;.
    /// </summary>
    [EnumMember(Value = "SEMP")]
    [IsoId("_FCpP_x-JEeuwwezkzufkMw")]
    [Description(
        @"Settlement on multiple platforms where one of the platforms is closed for settlement (either cash or securities)."
    )]
    SettlementOnMultiplePlatforms,

    /// <summary>
    /// Penalty was removed because of ISIN suspension from settlement due to a reconciliation issue under Article 65 (2) and (6) of the RTS on CSD Requirements.
    /// Encoded/decoded by serializers as &quot;SESU&quot;.
    /// </summary>
    [EnumMember(Value = "SESU")]
    [IsoId("_FCpQAh-JEeuwwezkzufkMw")]
    [Description(
        @"Penalty was removed becuase of ISIN suspension from settlement due to a reconciliation issue under Article 65 (2) and (6) of the RTS on CSD Requirements."
    )]
    SettlementSuspended,

    /// <summary>
    /// Penalty was removed because of ISIN suspension from trading.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_FCpP_R-JEeuwwezkzufkMw")]
    [Description(@"Penalty was removed becuase of ISIN suspension from trading.")]
    TradingSuspended,

    /// <summary>
    /// Penalty has been switched between the failing and non-failing party.
    /// Encoded/decoded by serializers as &quot;SWIC&quot;.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_FCpQBR-JEeuwwezkzufkMw")]
    [Description(@"Penalty has been switched between the failing and non-failing party.")]
    Switched,

    /// <summary>
    /// Penalty was removed because there were technical impossibilities at the CSD level that prevent settlement.
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_FCpQBh-JEeuwwezkzufkMw")]
    [Description(
        @"Penalty was removed becuase there were thecnical imposssibilities at the CSD level that prevent settlement, such as: a failure of the infrastructure components, a cyber-attack, network problems."
    )]
    TechnicalImpossibilities,

    /// <summary>
    /// Penalty has been updated.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_FCpQBB-JEeuwwezkzufkMw")]
    [Description(@"Penalty has been updated.")]
    Updated,
}
