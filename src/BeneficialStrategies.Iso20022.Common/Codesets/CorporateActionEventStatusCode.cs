// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the CA event or option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bESK1dp-Ed-ak6NoX_4Aeg_-625919884")]
[Description(@"Specifies the status of the CA event or option.")]
[Derivations(
    typeof(CorporateActionEventStatus2Code),
    typeof(CorporateActionEventStatus1Code),
    typeof(CorporateActionEventStatus3Code)
)]
public enum CorporateActionEventStatusCode
{
    /// <summary>
    /// The CA event is active.
    /// Encoded/decoded by serializers as &quot;ACTI&quot;.
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_bESK1tp-Ed-ak6NoX_4Aeg_-540954264")]
    [Description(@"The CA event is active.")]
    Active,

    /// <summary>
    /// The CA event is deactivated. The clients cannot send instruction anymore.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_bESK19p-Ed-ak6NoX_4Aeg_-540954263")]
    [Description(@"The CA event is deactivated. The clients cannot send instruction anymore.")]
    Deactivated,

    /// <summary>
    /// The CA event is expired, no more processing, claims, transformations take place.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_bESK2Np-Ed-ak6NoX_4Aeg_-540954242")]
    [Description(
        @"The CA event is expired, no more processing, claims, transformations take place."
    )]
    Expired,

    /// <summary>
    /// The CA event is cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bEb70Np-Ed-ak6NoX_4Aeg_-540954233")]
    [Description(@"The CA event is cancelled.")]
    Cancelled,

    /// <summary>
    /// The CA event is withrawn, ie, cancelled by the market.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_bEb70dp-Ed-ak6NoX_4Aeg_-540954211")]
    [Description(@"The CA event is withrawn, ie, cancelled by the market.")]
    Withdrawn,

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, eg, expired option.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_bEb70tp-Ed-ak6NoX_4Aeg_-1257003871")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, eg, expired option."
    )]
    Inactive,
}
