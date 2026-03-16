// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the stage of the corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_C_ElGyUZEeOxdNEux54C3Q")]
[Description(@"Specifies the stage of the corporate action event.")]
[Derivations(typeof(CorporateActionEventStage3Code), typeof(CorporateActionEventStage4Code))]
public enum CorporateActionEventStageV2Code
{
    /// <summary>
    /// Approved at the relevant meeting, for example, dividend.
    /// Encoded/decoded by serializers as &quot;APPD&quot;.
    /// </summary>
    [EnumMember(Value = "APPD")]
    [IsoId("_C_ElHiUZEeOxdNEux54C3Q")]
    [Description(@"Approved at the relevant meeting, for example, dividend.")]
    Approved,

    /// <summary>
    /// Offer is closed for acceptance.
    /// Encoded/decoded by serializers as &quot;CLDE&quot;.
    /// </summary>
    [EnumMember(Value = "CLDE")]
    [IsoId("_C_ElICUZEeOxdNEux54C3Q")]
    [Description(@"Offer is closed for acceptance.")]
    Deactivated,

    /// <summary>
    /// Cancellation and re-run of an original lottery or an original and supplemental lottery. A subsequent lottery will be performed under a new event.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_C_ElJCUZEeOxdNEux54C3Q")]
    [Description(
        @"Cancellation and re-run of an original lottery or an original and supplemental lottery. A subsequent lottery will be performed under a new event."
    )]
    CancellationAndReRun,

    /// <summary>
    /// Event/offer conditions have not been met and the event/offer is terminated or lapsed.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_C_ElHSUZEeOxdNEux54C3Q")]
    [Description(
        @"Event/offer conditions have not been met and the event/offer is terminated or lapsed."
    )]
    Lapsed,

    /// <summary>
    /// Cancellation and re-run of a supplemental lottery only. A subsequent new supplemental lottery will be performed under the original event.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_C_ElIyUZEeOxdNEux54C3Q")]
    [Description(
        @"Cancellation and re-run of a supplemental lottery only. A subsequent new supplemental lottery will be performed under the original event."
    )]
    SupplementalCancellationAndReRun,

    /// <summary>
    /// Open for acceptance until the next specified deadline in the announcement (if any).
    /// Encoded/decoded by serializers as &quot;PWAL&quot;.
    /// </summary>
    [EnumMember(Value = "PWAL")]
    [IsoId("_C_ElHyUZEeOxdNEux54C3Q")]
    [Description(
        @"Open for acceptance until the next specified deadline in the announcement (if any)."
    )]
    ActionPeriod,

    /// <summary>
    /// A supplemental lottery is being cancelled by the issuer. No subsequent lottery will be performed.
    /// Encoded/decoded by serializers as &quot;RESC&quot;.
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_C_ElIiUZEeOxdNEux54C3Q")]
    [Description(
        @"A supplemental lottery is being cancelled by the issuer. No subsequent lottery will be performed."
    )]
    SupplementalCancellation,

    /// <summary>
    /// Subject to approval at the relevant meeting, for example, dividend.
    /// Encoded/decoded by serializers as &quot;SUAP&quot;.
    /// </summary>
    [EnumMember(Value = "SUAP")]
    [IsoId("_C_ElJSUZEeOxdNEux54C3Q")]
    [Description(@"Subject to approval at the relevant meeting, for example, dividend.")]
    SubjectToApproval,

    /// <summary>
    /// The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil.
    /// Encoded/decoded by serializers as &quot;UNAC&quot;.
    /// </summary>
    [EnumMember(Value = "UNAC")]
    [IsoId("_C_ElHCUZEeOxdNEux54C3Q")]
    [Description(
        @"The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil."
    )]
    UnconditionalAsToAcceptance,

    /// <summary>
    /// Wholly unconditional; all conditions specified in the offer document have been satisfied.
    /// Encoded/decoded by serializers as &quot;WHOU&quot;.
    /// </summary>
    [EnumMember(Value = "WHOU")]
    [IsoId("_C_ElISUZEeOxdNEux54C3Q")]
    [Description(
        @"Wholly unconditional; all conditions specified in the offer document have been satisfied."
    )]
    WhollyUnconditional,
}
