// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the stage of the CA event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDsU8Np-Ed-ak6NoX_4Aeg_1114905444")]
[Description(@"Specifies the stage of the CA event.")]
[DerivedFrom(typeof(CorporateActionEventStageCode))]
public enum CorporateActionEventStage1Code
{
    /// <summary>
    /// Approved at the relevant meeting, eg, dividend.
    /// Encoded/decoded by serializers as &quot;APPD&quot;.
    /// </summary>
    [EnumMember(Value = "APPD")]
    [IsoId("_bDsU8dp-Ed-ak6NoX_4Aeg_1114905475")]
    [Description(@"Approved at the relevant meeting, eg, dividend.")]
    Approved = CorporateActionEventStageCode.Approved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The offer is closed for acceptance.
    /// Encoded/decoded by serializers as &quot;CLDE&quot;.
    /// </summary>
    [EnumMember(Value = "CLDE")]
    [IsoId("_bDsU8tp-Ed-ak6NoX_4Aeg_1114905505")]
    [Description(@"The offer is closed for acceptance.")]
    Deactivated = CorporateActionEventStageCode.Deactivated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Open for acceptance until the next specified deadline in the announcement (if any).
    /// Encoded/decoded by serializers as &quot;PWAL&quot;.
    /// </summary>
    [EnumMember(Value = "PWAL")]
    [IsoId("_bDsU89p-Ed-ak6NoX_4Aeg_1114905506")]
    [Description(
        @"Open for acceptance until the next specified deadline in the announcement (if any)."
    )]
    ActionPeriod = CorporateActionEventStageCode.ActionPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subject to approval at the relevant meeting, eg, dividend.
    /// Encoded/decoded by serializers as &quot;SUAP&quot;.
    /// </summary>
    [EnumMember(Value = "SUAP")]
    [IsoId("_bDsU9Np-Ed-ak6NoX_4Aeg_1114905536")]
    [Description(@"Subject to approval at the relevant meeting, eg, dividend.")]
    SubjectToApproval = CorporateActionEventStageCode.SubjectToApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil.
    /// Encoded/decoded by serializers as &quot;UNAC&quot;.
    /// </summary>
    [EnumMember(Value = "UNAC")]
    [IsoId("_bDsU9dp-Ed-ak6NoX_4Aeg_1114905537")]
    [Description(
        @"The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil."
    )]
    UnconditionalAsToAcceptance = CorporateActionEventStageCode.UnconditionalAsToAcceptance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Wholly unconditional; all conditions specified in the offer document have been satisfied.
    /// Encoded/decoded by serializers as &quot;WHOU&quot;.
    /// </summary>
    [EnumMember(Value = "WHOU")]
    [IsoId("_bDsU9tp-Ed-ak6NoX_4Aeg_1114905566")]
    [Description(
        @"Wholly unconditional; all conditions specified in the offer document have been satisfied."
    )]
    WhollyUnconditional = CorporateActionEventStageCode.WhollyUnconditional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An original or supplemental lottery is being reversed.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_bDsU99p-Ed-ak6NoX_4Aeg_1114905567")]
    [Description(@"An original or supplemental lottery is being reversed.")]
    FullReversalLotteryNotification = CorporateActionEventStageCode.FullReversalLotteryNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The event/offer conditions have not been met and the event/offer is terminated or lapsed.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_bDsU-Np-Ed-ak6NoX_4Aeg_1114905597")]
    [Description(
        @"The event/offer conditions have not been met and the event/offer is terminated or lapsed."
    )]
    Lapsed = CorporateActionEventStageCode.Lapsed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original call amount is reduced by the agent. The original announcement is cancelled and a new original lottery is issued.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_bD1e4Np-Ed-ak6NoX_4Aeg_1114905598")]
    [Description(
        @"Original call amount is reduced by the agent. The original announcement is cancelled and a new original lottery is issued."
    )]
    PartialReversalLotteryNotification =
        CorporateActionEventStageCode.PartialReversalLotteryNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original and or supplemental lottery details have changed and the lottery is being cancelled.
    /// Encoded/decoded by serializers as &quot;RESC&quot;.
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_bD1e4dp-Ed-ak6NoX_4Aeg_1114905627")]
    [Description(
        @"Original and or supplemental lottery details have changed and the lottery is being cancelled."
    )]
    RescissionReversalLotteryNotification =
        CorporateActionEventStageCode.RescissionReversalLotteryNotification, // same ordinal as derivation source for type conversions
}
