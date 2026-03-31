// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nyrU8L-IEeWfsa741pI6WA")]
[Description(
    @"Specifies the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary."
)]
[DerivedFrom(typeof(TaxWithholdingMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TaxWithholdingMethod3Code>))]
#endif
public enum TaxWithholdingMethod3Code
{
    /// <summary>
    /// Minority interest tax is withheld.
    /// Encoded/decoded by serializers as &quot;MITX&quot;.
    /// </summary>
    [EnumMember(Value = "MITX")]
    [IsoId("_rHlbQb-IEeWfsa741pI6WA")]
    [Description(@"Minority interest tax is withheld.")]
    MinorityInterestTax = TaxWithholdingMethodCode.MinorityInterestTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withholding tax is applied to an investment company.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_sBdCgb-IEeWfsa741pI6WA")]
    [Description(@"Withholding tax is applied to an investment company.")]
    InvestmentCompany = TaxWithholdingMethodCode.InvestmentCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend tax is exempt according to the accountant.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_shvsIb-IEeWfsa741pI6WA")]
    [Description(@"Dividend tax is exempt according to the accountant.")]
    Accountant = TaxWithholdingMethodCode.Accountant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend tax is exempt.
    /// Encoded/decoded by serializers as &quot;EXMT&quot;.
    /// </summary>
    [EnumMember(Value = "EXMT")]
    [IsoId("_tfyBsb-IEeWfsa741pI6WA")]
    [Description(@"Dividend tax is exempt.")]
    Exempt = TaxWithholdingMethodCode.Exempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax information is reported to the tax authorities and therefore not withheld at source.
    /// Encoded/decoded by serializers as &quot;REPT&quot;.
    /// </summary>
    [EnumMember(Value = "REPT")]
    [IsoId("_y3UHEb-IEeWfsa741pI6WA")]
    [Description(
        @"Tax information is reported to the tax authorities and therefore not withheld at source."
    )]
    ReportTax = TaxWithholdingMethodCode.ReportTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax certificate is provided by the beneficiary from its tax authority in its country of residence. Therefore, the obligation of withholding tax is waived and tax information will be reported to the tax authorities.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_y_WBsb-IEeWfsa741pI6WA")]
    [Description(
        @"Tax certificate is provided by the beneficiary from its tax authority in its country of residence. Therefore, the obligation of withholding tax is waived and tax information will be reported to the tax authorities."
    )]
    TaxCertificate = TaxWithholdingMethodCode.TaxCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withholding tax is applied to a corporate.
    /// Encoded/decoded by serializers as &quot;WHCO&quot;.
    /// </summary>
    [EnumMember(Value = "WHCO")]
    [IsoId("_zLZgsb-IEeWfsa741pI6WA")]
    [Description(@"Withholding tax is applied to a corporate.")]
    WithholdingCorporateTax = TaxWithholdingMethodCode.WithholdingCorporateTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is withheld at source.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_zSr0cb-IEeWfsa741pI6WA")]
    [Description(@"Tax is withheld at source.")]
    WithholdTax = TaxWithholdingMethodCode.WithholdTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is withheld at source and the tax information is also reported to the tax authorities.
    /// Encoded/decoded by serializers as &quot;WTRE&quot;.
    /// </summary>
    [EnumMember(Value = "WTRE")]
    [IsoId("_zauWIL-IEeWfsa741pI6WA")]
    [Description(
        @"Tax is withheld at source and the tax information is also reported to the tax authorities."
    )]
    WithholdTaxAndReport = TaxWithholdingMethodCode.WithholdTaxAndReport, // same ordinal as derivation source for type conversions
}
