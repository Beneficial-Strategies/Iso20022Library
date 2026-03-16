// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) specific options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExtendedOptionFeature2Code")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) specific options.")]
[DerivedFrom(typeof(ExtendedOptionFeatureCode))]
public enum ExtendedOptionFeature2Code
{
    /// <summary>
    /// DTC only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the favourable tax rate.
    /// Encoded/decoded by serializers as &quot;DRPF&quot;.
    /// </summary>
    [EnumMember(Value = "DRPF")]
    [IsoId("_ExtendedOptionFeature2Code_DRIPFavorable")]
    [Description(
        @"DTC only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the favourable tax rate."
    )]
    DRIPFavorable = ExtendedOptionFeatureCode.DRIPFavorable,

    /// <summary>
    /// DTC only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the unfavourable tax rate.
    /// Encoded/decoded by serializers as &quot;DRPU&quot;.
    /// </summary>
    [EnumMember(Value = "DRPU")]
    [IsoId("_ExtendedOptionFeature2Code_DRIPUnfavorable")]
    [Description(
        @"DTC only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the unfavourable tax rate."
    )]
    DRIPUnfavorable = ExtendedOptionFeatureCode.DRIPUnfavorable,

    /// <summary>
    /// DTC only option. The event and security are eligible for both the Dividend Reinvestment and the Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and will be exempt from any tax withholding.
    /// Encoded/decoded by serializers as &quot;DRPX&quot;.
    /// </summary>
    [EnumMember(Value = "DRPX")]
    [IsoId("_ExtendedOptionFeature2Code_DRIPExempt")]
    [Description(
        @"DTC only option. The event and security are eligible for both the Dividend Reinvestment and the Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and will be exempt from any tax withholding."
    )]
    DRIPExempt = ExtendedOptionFeatureCode.DRIPExempt,

    /// <summary>
    /// DTC only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing the option will receive their distribution in foreign currency and the tax withholding will be subject to favourable tax withholding.
    /// Encoded/decoded by serializers as &quot;FCPF&quot;.
    /// </summary>
    [EnumMember(Value = "FCPF")]
    [IsoId("_ExtendedOptionFeature2Code_ForeignCurrencyPaymentFavorable")]
    [Description(
        @"DTC only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing the option will receive their distribution in foreign currency and the tax withholding will be subject to favourable tax withholding."
    )]
    ForeignCurrencyPaymentFavorable = ExtendedOptionFeatureCode.ForeignCurrencyPaymentFavorable,

    /// <summary>
    /// DTC only option. The event and security are eligible for Foreign Currency Payment service at DTC. Participants electing this option will receive their distribution in the foreign currency instructed.
    /// Encoded/decoded by serializers as &quot;FCPP&quot;.
    /// </summary>
    [EnumMember(Value = "FCPP")]
    [IsoId("_ExtendedOptionFeature2Code_ForeignCurrencyPayment")]
    [Description(
        @"DTC only option. The event and security are eligible for Foreign Currency Payment service at DTC. Participants electing this option will receive their distribution in the foreign currency instructed."
    )]
    ForeignCurrencyPayment = ExtendedOptionFeatureCode.ForeignCurrencyPayment,

    /// <summary>
    /// DTC only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing this option will receive their distribution in a foreign currency and the tax withholding will be subject to unfavourable tax withholding.
    /// Encoded/decoded by serializers as &quot;FCPU&quot;.
    /// </summary>
    [EnumMember(Value = "FCPU")]
    [IsoId("_ExtendedOptionFeature2Code_ForeignCurrencyPaymentUnfavorable")]
    [Description(
        @"DTC only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing this option will receive their distribution in a foreign currency and the tax withholding will be subject to unfavourable tax withholding."
    )]
    ForeignCurrencyPaymentUnfavorable = ExtendedOptionFeatureCode.ForeignCurrencyPaymentUnfavorable,

    /// <summary>
    /// DTC only option. Participants electing this option will receive their distribution in a foreign currency and will be exempt from any tax withholding.
    /// Encoded/decoded by serializers as &quot;FCPX&quot;.
    /// </summary>
    [EnumMember(Value = "FCPX")]
    [IsoId("_ExtendedOptionFeature2Code_ForeignCurrencyPaymentExempt")]
    [Description(
        @"DTC only option. Participants electing this option will receive their distribution in a foreign currency and will be exempt from any tax withholding."
    )]
    ForeignCurrencyPaymentExempt = ExtendedOptionFeatureCode.ForeignCurrencyPaymentExempt,

    /// <summary>
    /// DTC only option. Eligible for the Foreign Tax Relief service at DTC. An election ensures the participant receives their payment at a favourable tax withholding rate.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ExtendedOptionFeature2Code_ForeignTaxFavorable")]
    [Description(
        @"DTC only option. Eligible for the Foreign Tax Relief service at DTC. An election ensures the participant receives their payment at a favourable tax withholding rate."
    )]
    ForeignTaxFavorable = ExtendedOptionFeatureCode.ForeignTaxFavorable,

    /// <summary>
    /// DTC only option. Eligible for the Foreign Tax Relief service at DTC. Option to select unfavourable tax rate.
    /// Encoded/decoded by serializers as &quot;FORU&quot;.
    /// </summary>
    [EnumMember(Value = "FORU")]
    [IsoId("_ExtendedOptionFeature2Code_ForeignTaxUnfavorable")]
    [Description(
        @"DTC only option. Eligible for the Foreign Tax Relief service at DTC. Option to select unfavourable tax rate."
    )]
    ForeignTaxUnfavorable = ExtendedOptionFeatureCode.ForeignTaxUnfavorable,

    /// <summary>
    /// DTC only option. Eligible for the Foreign Tax Relief service at DTC. An election ensures the participant is exempt from any tax withholding.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_ExtendedOptionFeature2Code_ForeignTaxExempt")]
    [Description(
        @"DTC only option. Eligible for the Foreign Tax Relief service at DTC. An election ensures the participant is exempt from any tax withholding."
    )]
    ForeignTaxExempt = ExtendedOptionFeatureCode.ForeignTaxExempt,

    /// <summary>
    /// Indicates option in which holders must not provide a shareholder number if provided will be rejected.
    /// Encoded/decoded by serializers as &quot;NSHR&quot;.
    /// </summary>
    [EnumMember(Value = "NSHR")]
    [IsoId("_ExtendedOptionFeature2Code_ShareholderNumberNotAllowed")]
    [Description(
        @"Indicates option in which holders must not provide a shareholder number if provided will be rejected."
    )]
    ShareholderNumberNotAllowed,
}
