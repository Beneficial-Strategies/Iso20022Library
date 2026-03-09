// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specified the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YlcJ1dp-Ed-ak6NoX_4Aeg_1304530864")]
[Description(@"Specified the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.")]
[Derivations(typeof(TaxWithholdingMethod1Code),typeof(TaxWithholdingMethod2Code),typeof(TaxWithholdingMethod3Code))]
public enum TaxWithholdingMethodCode
{
    /// <summary>
    /// Tax is withheld at source.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_YlcJ1tp-Ed-ak6NoX_4Aeg_-1878814849")]
    [Description(@"Tax is withheld at source.")]
    WithholdTax,
    
    /// <summary>
    /// Tax information is reported to the tax authorities and therefore not withheld at source.
    /// Encoded/decoded by serializers as &quot;REPT&quot;.
    /// </summary>
    [EnumMember(Value = "REPT")]
    [IsoId("_YlcJ19p-Ed-ak6NoX_4Aeg_-1857573882")]
    [Description(@"Tax information is reported to the tax authorities and therefore not withheld at source.")]
    ReportTax,
    
    /// <summary>
    /// Tax certificate is provided by the beneficiary from its tax authority in its country of residence. Therefore, the obligation of withholding tax is waived and tax information will be reported to the tax authorities.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_YlcJ2Np-Ed-ak6NoX_4Aeg_-1834484700")]
    [Description(@"Tax certificate is provided by the beneficiary from its tax authority in its country of residence. Therefore, the obligation of withholding tax is waived and tax information will be reported to the tax authorities.")]
    TaxCertificate,
    
    /// <summary>
    /// Tax is withheld at source and the tax information is also reported to the tax authorities.
    /// Encoded/decoded by serializers as &quot;WTRE&quot;.
    /// </summary>
    [EnumMember(Value = "WTRE")]
    [IsoId("_Yll60Np-Ed-ak6NoX_4Aeg_-941251968")]
    [Description(@"Tax is withheld at source and the tax information is also reported to the tax authorities.")]
    WithholdTaxAndReport,
    
    /// <summary>
    /// Withholding tax is applied to a corporate.
    /// Encoded/decoded by serializers as &quot;WHCO&quot;.
    /// </summary>
    [EnumMember(Value = "WHCO")]
    [IsoId("_ImTWgBOtEeKd9pI2QZcqvg_533348726")]
    [Description(@"Withholding tax is applied to a corporate.")]
    WithholdingCorporateTax,
    
    /// <summary>
    /// Dividend tax is exempt.
    /// Encoded/decoded by serializers as &quot;EXMT&quot;.
    /// </summary>
    [EnumMember(Value = "EXMT")]
    [IsoId("_Vjp_wL-IEeWfsa741pI6WA")]
    [Description(@"Dividend tax is exempt.")]
    Exempt,
    
    /// <summary>
    /// Dividend tax is exempt according to the accountant.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_VpdFwL-IEeWfsa741pI6WA")]
    [Description(@"Dividend tax is exempt according to the accountant.")]
    Accountant,
    
    /// <summary>
    /// Withholding tax is applied to an investment company.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_VvQy0L-IEeWfsa741pI6WA")]
    [Description(@"Withholding tax is applied to an investment company.")]
    InvestmentCompany,
    
    /// <summary>
    /// Minority interest tax is withheld.
    /// Encoded/decoded by serializers as &quot;MITX&quot;.
    /// </summary>
    [EnumMember(Value = "MITX")]
    [IsoId("_V51EEL-IEeWfsa741pI6WA")]
    [Description(@"Minority interest tax is withheld.")]
    MinorityInterestTax,
    
}
