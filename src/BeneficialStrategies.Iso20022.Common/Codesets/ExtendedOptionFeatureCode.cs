// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) specific options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1orVtDL3EeKU9IrkkToqcw_-113809036")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) specific options.")]
[Derivations(typeof(ExtendedOptionFeature1Code))]
public enum ExtendedOptionFeatureCode
{
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. Option to select unfavourable tax rate. The Foreign Tax Unfavourable option is the default option.
    /// Encoded/decoded by serializers as &quot;FORU&quot;.
    /// </summary>
    [EnumMember(Value = "FORU")]
    [IsoId("_1orVtTL3EeKU9IrkkToqcw_-2124589186")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. Option to select unfavourable tax rate. The Foreign Tax Unfavourable option is the default option.")]
    ForeignTaxUnfavorable,
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. An election into this option ensures the participant receives their payment at a favourable tax withholding rate.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_1o1GsDL3EeKU9IrkkToqcw_1138745473")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. An election into this option ensures the participant receives their payment at a favourable tax withholding rate.")]
    ForeignTaxFavorable,
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. An election into this option ensures the participant is exempt from any tax withholding.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_1o1GsTL3EeKU9IrkkToqcw_568886960")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for the Foreign Tax Relief service at DTC. An election into this option ensures the participant is exempt from any tax withholding.")]
    ForeignTaxExempt,
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the unfavourable tax rate.
    /// Encoded/decoded by serializers as &quot;DRPU&quot;.
    /// </summary>
    [EnumMember(Value = "DRPU")]
    [IsoId("_1o1GsjL3EeKU9IrkkToqcw_2040469180")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the unfavourable tax rate.")]
    DRIPUnfavorable,
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the favourable tax rate.
    /// Encoded/decoded by serializers as &quot;DRPF&quot;.
    /// </summary>
    [EnumMember(Value = "DRPF")]
    [IsoId("_1o1GszL3EeKU9IrkkToqcw_-1180070104")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and the tax withholding on those shares will be at the favourable tax rate.")]
    DRIPFavorable,
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and the Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and will be exempt from any tax withholding.
    /// Encoded/decoded by serializers as &quot;DRPX&quot;.
    /// </summary>
    [EnumMember(Value = "DRPX")]
    [IsoId("_1o1GtDL3EeKU9IrkkToqcw_-838720765")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Dividend Reinvestment and the Foreign Tax Relief services at DTC. Participants electing this option will receive additional shares and will be exempt from any tax withholding.")]
    DRIPExempt,
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for Foreign Currency Payment service at DTC. Participants electing this option will receive their distribution in the foreign currency instructed.
    /// Encoded/decoded by serializers as &quot;FCPP&quot;.
    /// </summary>
    [EnumMember(Value = "FCPP")]
    [IsoId("_1o1GtTL3EeKU9IrkkToqcw_-1605791846")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for Foreign Currency Payment service at DTC. Participants electing this option will receive their distribution in the foreign currency instructed.")]
    ForeignCurrencyPayment,
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing this option will receive their distribution in a foreign currency and the tax withholding on that distribution will be subject to unfavourable tax withholding.
    /// Encoded/decoded by serializers as &quot;FCPU&quot;.
    /// </summary>
    [EnumMember(Value = "FCPU")]
    [IsoId("_1o1GtjL3EeKU9IrkkToqcw_1073875968")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing this option will receive their distribution in a foreign currency and the tax withholding on that distribution will be subject to unfavourable tax withholding.")]
    ForeignCurrencyPaymentUnfavorable,
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing the option will receive their distribution in foreign currency and the tax withholding on that distribution will be subject to favourable tax withholding.
    /// Encoded/decoded by serializers as &quot;FCPF&quot;.
    /// </summary>
    [EnumMember(Value = "FCPF")]
    [IsoId("_1o-QoDL3EeKU9IrkkToqcw_-1448458728")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing the option will receive their distribution in foreign currency and the tax withholding on that distribution will be subject to favourable tax withholding.")]
    ForeignCurrencyPaymentFavorable,
    
    /// <summary>
    /// DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing this option will receive their distribution in a foreign currency and will be exempt from any tax withholding.
    /// Encoded/decoded by serializers as &quot;FCPX&quot;.
    /// </summary>
    [EnumMember(Value = "FCPX")]
    [IsoId("_1o-QoTL3EeKU9IrkkToqcw_719726371")]
    [Description(@"DTC (The Depository Trust Company) only option. The event and security are eligible for both the Foreign Currency and Foreign Tax services at DTC. Participants electing this option will receive their distribution in a foreign currency and will be exempt from any tax withholding.")]
    ForeignCurrencyPaymentExempt,
    
}
