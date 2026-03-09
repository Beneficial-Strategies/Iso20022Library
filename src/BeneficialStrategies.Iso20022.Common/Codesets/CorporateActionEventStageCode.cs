// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the stage of the CA event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bD_P4Np-Ed-ak6NoX_4Aeg_-1886893264")]
[Description(@"Specifies the stage of the CA event.")]
[Derivations(typeof(CorporateActionEventStage1Code),typeof(CorporateActionEventStage2Code))]
public enum CorporateActionEventStageCode
{
    /// <summary>
    /// Approved at the relevant meeting, eg, dividend.
    /// Encoded/decoded by serializers as &quot;APPD&quot;.
    /// </summary>
    [EnumMember(Value = "APPD")]
    [IsoId("_bD_P4dp-Ed-ak6NoX_4Aeg_-1858264134")]
    [Description(@"Approved at the relevant meeting, eg, dividend.")]
    Approved,
    
    /// <summary>
    /// The offer is closed for acceptance.
    /// Encoded/decoded by serializers as &quot;CLDE&quot;.
    /// </summary>
    [EnumMember(Value = "CLDE")]
    [IsoId("_bD_P4tp-Ed-ak6NoX_4Aeg_-1858264083")]
    [Description(@"The offer is closed for acceptance.")]
    Deactivated,
    
    /// <summary>
    /// An original or supplemental lottery is being reversed.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_bD_P49p-Ed-ak6NoX_4Aeg_-422836046")]
    [Description(@"An original or supplemental lottery is being reversed.")]
    FullReversalLotteryNotification,
    
    /// <summary>
    /// The event/offer conditions have not been met and the event/offer is terminated or lapsed.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_bD_P5Np-Ed-ak6NoX_4Aeg_-357266452")]
    [Description(@"The event/offer conditions have not been met and the event/offer is terminated or lapsed.")]
    Lapsed,
    
    /// <summary>
    /// Original call amount is reduced by the agent. The original announcement is cancelled and a new original lottery is issued.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_bD_P5dp-Ed-ak6NoX_4Aeg_-241824969")]
    [Description(@"Original call amount is reduced by the agent. The original announcement is cancelled and a new original lottery is issued.")]
    PartialReversalLotteryNotification,
    
    /// <summary>
    /// Open for acceptance until the next specified deadline in the announcement (if any).
    /// Encoded/decoded by serializers as &quot;PWAL&quot;.
    /// </summary>
    [EnumMember(Value = "PWAL")]
    [IsoId("_bD_P5tp-Ed-ak6NoX_4Aeg_-1858264144")]
    [Description(@"Open for acceptance until the next specified deadline in the announcement (if any).")]
    ActionPeriod,
    
    /// <summary>
    /// Original and or supplemental lottery details have changed and the lottery is being cancelled.
    /// Encoded/decoded by serializers as &quot;RESC&quot;.
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_bD_P59p-Ed-ak6NoX_4Aeg_74019586")]
    [Description(@"Original and or supplemental lottery details have changed and the lottery is being cancelled.")]
    RescissionReversalLotteryNotification,
    
    /// <summary>
    /// Subject to approval at the relevant meeting, eg, dividend.
    /// Encoded/decoded by serializers as &quot;SUAP&quot;.
    /// </summary>
    [EnumMember(Value = "SUAP")]
    [IsoId("_bD_P6Np-Ed-ak6NoX_4Aeg_-1858264135")]
    [Description(@"Subject to approval at the relevant meeting, eg, dividend.")]
    SubjectToApproval,
    
    /// <summary>
    /// The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil.
    /// Encoded/decoded by serializers as &quot;UNAC&quot;.
    /// </summary>
    [EnumMember(Value = "UNAC")]
    [IsoId("_bD_P6dp-Ed-ak6NoX_4Aeg_-1858264113")]
    [Description(@"The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil.")]
    UnconditionalAsToAcceptance,
    
    /// <summary>
    /// Wholly unconditional; all conditions specified in the offer document have been satisfied.
    /// Encoded/decoded by serializers as &quot;WHOU&quot;.
    /// </summary>
    [EnumMember(Value = "WHOU")]
    [IsoId("_bEJA4Np-Ed-ak6NoX_4Aeg_-1858264104")]
    [Description(@"Wholly unconditional; all conditions specified in the offer document have been satisfied.")]
    WhollyUnconditional,
    
}
