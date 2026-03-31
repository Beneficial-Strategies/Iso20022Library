// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of interest rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_b3lpIO7nEeK-Kt3xkpFJcA_1739924161")]
[Description(@"Specifies the type of interest rate.")]
[Derivations(typeof(RateType7Code), typeof(RateType1Code), typeof(InterestRateType1Code))]
public enum InterestRateTypeCode
{
    /// <summary>
    /// Rate is fixed.
    /// Encoded/decoded by serializers as &quot;FIXE&quot;.
    /// </summary>
    [EnumMember(Value = "FIXE")]
    [IsoId("_b3lpIe7nEeK-Kt3xkpFJcA_207640149")]
    [Description(@"Rate is fixed.")]
    Fixed,

    /// <summary>
    /// No specific repurchase rate applies to the transaction Repo, only a forfeit.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_b3uzEO7nEeK-Kt3xkpFJcA_-1709364962")]
    [Description(@"No specific repurchase rate applies to the transaction Repo, only a forfeit.")]
    Forfeit,

    /// <summary>
    /// Rate is variable.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_b3uzE-7nEeK-Kt3xkpFJcA_-1666520361")]
    [Description(@"Rate is variable.")]
    Variable,

    /// <summary>
    /// Rate of the scheduled payment.
    /// Encoded/decoded by serializers as &quot;SCHD&quot;.
    /// </summary>
    [EnumMember(Value = "SCHD")]
    [IsoId("_b3uzEe7nEeK-Kt3xkpFJcA_1933373909")]
    [Description(@"Rate of the scheduled payment.")]
    Scheduled,

    /// <summary>
    /// Rate of the unscheduled payment.
    /// Encoded/decoded by serializers as &quot;USCD&quot;.
    /// </summary>
    [EnumMember(Value = "USCD")]
    [IsoId("_b3uzEu7nEeK-Kt3xkpFJcA_1718331141")]
    [Description(@"Rate of the unscheduled payment.")]
    Unscheduled,

    /// <summary>
    /// Interest rate type is Discount.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_OlFpwCRtEemoiMEiwtMpyw")]
    [Description(@"Interest rate type is Discount.")]
    Discount,

    /// <summary>
    /// Interest rate type is Fixed rate underlying exposure (for life).
    /// Encoded/decoded by serializers as &quot;FXRL&quot;.
    /// </summary>
    [EnumMember(Value = "FXRL")]
    [IsoId("_SiYlwCRtEemoiMEiwtMpyw")]
    [Description(@"Interest rate type is Fixed rate underlying exposure (for life).")]
    FixedRateUnderlyingExposureForLife,

    /// <summary>
    /// Interest rate type is Fixed rate underlying exposure with compulsory future switch to floating.
    /// Encoded/decoded by serializers as &quot;FLCF&quot;.
    /// </summary>
    [EnumMember(Value = "FLCF")]
    [IsoId("_VFNH0CRtEemoiMEiwtMpyw")]
    [Description(
        @"Interest rate type is Fixed rate underlying exposure with compulsory future switch to floating."
    )]
    FixedRateUnderlyingExposureWithCompulsoryFutureSwitchToFloating,

    /// <summary>
    /// Interest rate type is Fixed with future periodic resets.
    /// Encoded/decoded by serializers as &quot;FXPR&quot;.
    /// </summary>
    [EnumMember(Value = "FXPR")]
    [IsoId("_Y1woUCRtEemoiMEiwtMpyw")]
    [Description(@"Interest rate type is Fixed with future periodic resets.")]
    FixedWithFuturePeriodicResets,

    /// <summary>
    /// Interest rate type is Floating rate underlying exposure linked to one index that will revert to another index in the future.
    /// Encoded/decoded by serializers as &quot;FINX&quot;.
    /// </summary>
    [EnumMember(Value = "FINX")]
    [IsoId("_b1yq0CRtEemoiMEiwtMpyw")]
    [Description(
        @"Interest rate type is Floating rate underlying exposure linked to one index that will revert to another index in the future."
    )]
    FloatingLinkedToIndex,

    /// <summary>
    /// Interest rate type is Floating rate underlying exposure (for life).
    /// Encoded/decoded by serializers as &quot;FLIF&quot;.
    /// </summary>
    [EnumMember(Value = "FLIF")]
    [IsoId("_eYTq4CRtEemoiMEiwtMpyw")]
    [Description(@"Interest rate type is Floating rate underlying exposure (for life).")]
    FloatingRateUnderlyingExposureForLife,

    /// <summary>
    /// Interest rate type is Floating rate underlying exposure with cap.
    /// Encoded/decoded by serializers as &quot;CAPP&quot;.
    /// </summary>
    [EnumMember(Value = "CAPP")]
    [IsoId("_g6qS4CRtEemoiMEiwtMpyw")]
    [Description(@"Interest rate type is Floating rate underlying exposure with cap.")]
    FloatingRateUnderlyingExposureWithCap,

    /// <summary>
    /// Interest rate type is Floating rate underlying exposure with floor.
    /// Encoded/decoded by serializers as &quot;FLFL&quot;.
    /// </summary>
    [EnumMember(Value = "FLFL")]
    [IsoId("_jfr0YCRtEemoiMEiwtMpyw")]
    [Description(@"Interest rate type is Floating rate underlying exposure with floor.")]
    FloatingRateUnderlyingExposureWithFloor,

    /// <summary>
    /// Interest rate type is Floating rate underlying exposure with both floor and cap.
    /// Encoded/decoded by serializers as &quot;FLCA&quot;.
    /// </summary>
    [EnumMember(Value = "FLCA")]
    [IsoId("_l9Fq8CRtEemoiMEiwtMpyw")]
    [Description(
        @"Interest rate type is Floating rate underlying exposure with both floor and cap."
    )]
    FloatingRateUnderlyingExposureWithFloorAndCap,

    /// <summary>
    /// Interest rate type is Modular.
    /// Encoded/decoded by serializers as &quot;MODE&quot;.
    /// </summary>
    [EnumMember(Value = "MODE")]
    [IsoId("_pAGwACRtEemoiMEiwtMpyw")]
    [Description(@"Interest rate type is Modular.")]
    Modular,

    /// <summary>
    /// Interest rate type is Obligor Swapped.
    /// Encoded/decoded by serializers as &quot;OBLS&quot;.
    /// </summary>
    [EnumMember(Value = "OBLS")]
    [IsoId("_rCZ-8CRtEemoiMEiwtMpyw")]
    [Description(@"Interest rate type is Obligor Swapped.")]
    ObligorSwapped,

    /// <summary>
    /// Any other type of interest rate that can be applied.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_tvX7gCRtEemoiMEiwtMpyw")]
    [Description(@"Any other type of interest rate that can be applied.")]
    Other,

    /// <summary>
    /// Interest rate type is Switch Optionality.
    /// Encoded/decoded by serializers as &quot;SWIC&quot;.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_3jp5ACRtEemoiMEiwtMpyw")]
    [Description(@"Interest rate type is Switch Optionality.")]
    SwicthOptionality,
}
