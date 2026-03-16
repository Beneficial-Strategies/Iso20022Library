// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the stage of the CA event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0WDegCUeEeOxdNEux54C3Q")]
[Description(@"Specifies the stage of the CA event.")]
[DerivedFrom(typeof(CorporateActionEventStageV2Code))]
public enum CorporateActionEventStage3Code
{
    /// <summary>
    /// Approved at the relevant meeting, for example, dividend.
    /// Encoded/decoded by serializers as &quot;APPD&quot;.
    /// </summary>
    [EnumMember(Value = "APPD")]
    [IsoId("_JJnNASUfEeOxdNEux54C3Q")]
    [Description(@"Approved at the relevant meeting, for example, dividend.")]
    Approved = CorporateActionEventStageV2Code.Approved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer is closed for acceptance.
    /// Encoded/decoded by serializers as &quot;CLDE&quot;.
    /// </summary>
    [EnumMember(Value = "CLDE")]
    [IsoId("_KRBhASUfEeOxdNEux54C3Q")]
    [Description(@"Offer is closed for acceptance.")]
    Deactivated = CorporateActionEventStageV2Code.Deactivated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation and re-run of an original lottery or an original and supplemental lottery. A subsequent lottery will be performed under a new event.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_LD5vcSUfEeOxdNEux54C3Q")]
    [Description(
        @"Cancellation and re-run of an original lottery or an original and supplemental lottery. A subsequent lottery will be performed under a new event."
    )]
    CancellationAndReRun = CorporateActionEventStageV2Code.CancellationAndReRun, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event/offer conditions have not been met and the event/offer is terminated or lapsed.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_LiQfYSUfEeOxdNEux54C3Q")]
    [Description(
        @"Event/offer conditions have not been met and the event/offer is terminated or lapsed."
    )]
    Lapsed = CorporateActionEventStageV2Code.Lapsed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation and re-run of a supplemental lottery only. A subsequent new supplemental lottery will be performed under the original event.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_MFz4YSUfEeOxdNEux54C3Q")]
    [Description(
        @"Cancellation and re-run of a supplemental lottery only. A subsequent new supplemental lottery will be performed under the original event."
    )]
    SupplementalCancellationAndReRun =
        CorporateActionEventStageV2Code.SupplementalCancellationAndReRun, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Open for acceptance until the next specified deadline in the announcement (if any).
    /// Encoded/decoded by serializers as &quot;PWAL&quot;.
    /// </summary>
    [EnumMember(Value = "PWAL")]
    [IsoId("_MoCbsSUfEeOxdNEux54C3Q")]
    [Description(
        @"Open for acceptance until the next specified deadline in the announcement (if any)."
    )]
    ActionPeriod = CorporateActionEventStageV2Code.ActionPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A supplemental lottery is being cancelled by the issuer. No subsequent lottery will be performed.
    /// Encoded/decoded by serializers as &quot;RESC&quot;.
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_N53P8SUfEeOxdNEux54C3Q")]
    [Description(
        @"A supplemental lottery is being cancelled by the issuer. No subsequent lottery will be performed."
    )]
    SupplementalCancellation = CorporateActionEventStageV2Code.SupplementalCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subject to approval at the relevant meeting, for example, dividend.
    /// Encoded/decoded by serializers as &quot;SUAP&quot;.
    /// </summary>
    [EnumMember(Value = "SUAP")]
    [IsoId("_OFeDASUfEeOxdNEux54C3Q")]
    [Description(@"Subject to approval at the relevant meeting, for example, dividend.")]
    SubjectToApproval = CorporateActionEventStageV2Code.SubjectToApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil.
    /// Encoded/decoded by serializers as &quot;UNAC&quot;.
    /// </summary>
    [EnumMember(Value = "UNAC")]
    [IsoId("_OokwESUfEeOxdNEux54C3Q")]
    [Description(
        @"The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil."
    )]
    UnconditionalAsToAcceptance = CorporateActionEventStageV2Code.UnconditionalAsToAcceptance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Wholly unconditional; all conditions specified in the offer document have been satisfied.
    /// Encoded/decoded by serializers as &quot;WHOU&quot;.
    /// </summary>
    [EnumMember(Value = "WHOU")]
    [IsoId("_O8g_wSUfEeOxdNEux54C3Q")]
    [Description(
        @"Wholly unconditional; all conditions specified in the offer document have been satisfied."
    )]
    WhollyUnconditional = CorporateActionEventStageV2Code.WhollyUnconditional, // same ordinal as derivation source for type conversions
}
