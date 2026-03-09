// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the stage of the corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bD1e4tp-Ed-ak6NoX_4Aeg_1234993213")]
[Description(@"Specifies the stage of the corporate action event.")]
[DerivedFrom(typeof(CorporateActionEventStageCode))]
public enum CorporateActionEventStage2Code
{
    /// <summary>
    /// Open for acceptance until the next specified deadline in the announcement (if any).
    /// Encoded/decoded by serializers as &quot;PWAL&quot;.
    /// </summary>
    [EnumMember(Value = "PWAL")]
    [IsoId("_bD1e49p-Ed-ak6NoX_4Aeg_1234993231")]
    [Description(@"Open for acceptance until the next specified deadline in the announcement (if any).")]
    ActionPeriod = CorporateActionEventStageCode.ActionPeriod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Subject to approval at the relevant meeting, eg, dividend.
    /// Encoded/decoded by serializers as &quot;SUAP&quot;.
    /// </summary>
    [EnumMember(Value = "SUAP")]
    [IsoId("_bD1e5Np-Ed-ak6NoX_4Aeg_1234993256")]
    [Description(@"Subject to approval at the relevant meeting, eg, dividend.")]
    SubjectToApproval = CorporateActionEventStageCode.SubjectToApproval, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Approved at the relevant meeting, eg, dividend.
    /// Encoded/decoded by serializers as &quot;APPD&quot;.
    /// </summary>
    [EnumMember(Value = "APPD")]
    [IsoId("_bD1e5dp-Ed-ak6NoX_4Aeg_1234993257")]
    [Description(@"Approved at the relevant meeting, eg, dividend.")]
    Approved = CorporateActionEventStageCode.Approved, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil.
    /// Encoded/decoded by serializers as &quot;UNAC&quot;.
    /// </summary>
    [EnumMember(Value = "UNAC")]
    [IsoId("_bD1e5tp-Ed-ak6NoX_4Aeg_1234993273")]
    [Description(@"The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil.")]
    UnconditionalAsToAcceptance = CorporateActionEventStageCode.UnconditionalAsToAcceptance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wholly unconditional; all conditions specified in the offer document have been satisfied.
    /// Encoded/decoded by serializers as &quot;WHOU&quot;.
    /// </summary>
    [EnumMember(Value = "WHOU")]
    [IsoId("_bD1e59p-Ed-ak6NoX_4Aeg_1234993291")]
    [Description(@"Wholly unconditional; all conditions specified in the offer document have been satisfied.")]
    WhollyUnconditional = CorporateActionEventStageCode.WhollyUnconditional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The offer is closed for acceptance.
    /// Encoded/decoded by serializers as &quot;CLDE&quot;.
    /// </summary>
    [EnumMember(Value = "CLDE")]
    [IsoId("_bD1e6Np-Ed-ak6NoX_4Aeg_1234993308")]
    [Description(@"The offer is closed for acceptance.")]
    Deactivated = CorporateActionEventStageCode.Deactivated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The event/offer conditions have not been met and the event/offer is terminated or lapsed.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_bD1e6dp-Ed-ak6NoX_4Aeg_1234993326")]
    [Description(@"The event/offer conditions have not been met and the event/offer is terminated or lapsed.")]
    Lapsed = CorporateActionEventStageCode.Lapsed, // same ordinal as derivation source for type conversions
    
}
