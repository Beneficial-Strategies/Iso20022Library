// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) specific options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_146xITL3EeKU9IrkkToqcw_1729100634")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) specific options.")]
[DerivedFrom(typeof(ExtendedOptionFeatureCode))]
public enum ExtendedOptionFeature1Code
{
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. Option to select unfavourable tax rate. The Foreign Tax Unfavourable option is the default option.
    /// Encoded/decoded by serializers as &quot;FORU&quot;.
    /// </summary>
    [EnumMember(Value = "FORU")]
    [IsoId("_146xIjL3EeKU9IrkkToqcw_-255037301")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. Option to select unfavourable tax rate. The Foreign Tax Unfavourable option is the default option.")]
    ForeignTaxUnfavorable = ExtendedOptionFeatureCode.ForeignTaxUnfavorable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. An election into this option ensures the participant receives their payment at a favourable tax withholding rate.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_146xIzL3EeKU9IrkkToqcw_-1138270588")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. An election into this option ensures the participant receives their payment at a favourable tax withholding rate.")]
    ForeignTaxFavorable = ExtendedOptionFeatureCode.ForeignTaxFavorable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. An election into this option ensures the participant is exempt from any tax withholding.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_146xJDL3EeKU9IrkkToqcw_199049968")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. An election into this option ensures the participant is exempt from any tax withholding.")]
    ForeignTaxExempt = ExtendedOptionFeatureCode.ForeignTaxExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the unfavourable tax rate.
    /// Encoded/decoded by serializers as &quot;DRPU&quot;.
    /// </summary>
    [EnumMember(Value = "DRPU")]
    [IsoId("_146xJTL3EeKU9IrkkToqcw_-684183319")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the unfavourable tax rate.")]
    DRIPUnfavorable = ExtendedOptionFeatureCode.DRIPUnfavorable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the favourable tax rate.
    /// Encoded/decoded by serializers as &quot;DRPF&quot;.
    /// </summary>
    [EnumMember(Value = "DRPF")]
    [IsoId("_15EiIDL3EeKU9IrkkToqcw_784996994")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the favourable tax rate.")]
    DRIPFavorable = ExtendedOptionFeatureCode.DRIPFavorable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and the Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and will be exempt from any tax withholding.
    /// Encoded/decoded by serializers as &quot;DRPX&quot;.
    /// </summary>
    [EnumMember(Value = "DRPX")]
    [IsoId("_15EiITL3EeKU9IrkkToqcw_-2036135404")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and the Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and will be exempt from any tax withholding.")]
    DRIPExempt = ExtendedOptionFeatureCode.DRIPExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for Foreign Currency Payment service at DTC. Participants electing this option will receive their distribution in the foreign currency instructed.
    /// Encoded/decoded by serializers as &quot;FCPP&quot;.
    /// </summary>
    [EnumMember(Value = "FCPP")]
    [IsoId("_15EiIjL3EeKU9IrkkToqcw_1375598605")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for Foreign Currency Payment service at DTC. Participants electing this option will receive their distribution in the foreign currency instructed.")]
    ForeignCurrencyPayment = ExtendedOptionFeatureCode.ForeignCurrencyPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing this option will receive their distribution in a foreign currency and the tax withholding on that distribution will be subject to unfavourable tax withholding.
    /// Encoded/decoded by serializers as &quot;FCPU&quot;.
    /// </summary>
    [EnumMember(Value = "FCPU")]
    [IsoId("_15EiIzL3EeKU9IrkkToqcw_-604784726")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing this option will receive their distribution in a foreign currency and the tax withholding on that distribution will be subject to unfavourable tax withholding.")]
    ForeignCurrencyPaymentUnfavorable = ExtendedOptionFeatureCode.ForeignCurrencyPaymentUnfavorable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing the option will receive their distribution in foreign currency and the tax withholding on that distribution will be subject to favourable tax withholding.
    /// Encoded/decoded by serializers as &quot;FCPF&quot;.
    /// </summary>
    [EnumMember(Value = "FCPF")]
    [IsoId("_15EiJDL3EeKU9IrkkToqcw_-1488018013")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing the option will receive their distribution in foreign currency and the tax withholding on that distribution will be subject to favourable tax withholding.")]
    ForeignCurrencyPaymentFavorable = ExtendedOptionFeatureCode.ForeignCurrencyPaymentFavorable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing this option will receive their distribution in a foreign currency and will be exempt from any tax withholding.
    /// Encoded/decoded by serializers as &quot;FCPX&quot;.
    /// </summary>
    [EnumMember(Value = "FCPX")]
    [IsoId("_15EiJTL3EeKU9IrkkToqcw_809451896")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing this option will receive their distribution in a foreign currency and will be exempt from any tax withholding.")]
    ForeignCurrencyPaymentExempt = ExtendedOptionFeatureCode.ForeignCurrencyPaymentExempt, // same ordinal as derivation source for type conversions
    
}
