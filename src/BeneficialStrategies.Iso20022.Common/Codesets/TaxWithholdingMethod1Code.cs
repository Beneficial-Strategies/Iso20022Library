// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specified the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YlcJ0Np-Ed-ak6NoX_4Aeg_1746600246")]
[Description(@"Specified the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.")]
[DerivedFrom(typeof(TaxWithholdingMethodCode))]
public enum TaxWithholdingMethod1Code
{
    /// <summary>
    /// Tax is withheld at source.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_YlcJ0dp-Ed-ak6NoX_4Aeg_403829980")]
    [Description(@"Tax is withheld at source.")]
    WithholdTax = TaxWithholdingMethodCode.WithholdTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax information is reported to the tax authorities and therefore not withheld at source.
    /// Encoded/decoded by serializers as &quot;REPT&quot;.
    /// </summary>
    [EnumMember(Value = "REPT")]
    [IsoId("_YlcJ0tp-Ed-ak6NoX_4Aeg_403830040")]
    [Description(@"Tax information is reported to the tax authorities and therefore not withheld at source.")]
    ReportTax = TaxWithholdingMethodCode.ReportTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax certificate is provided by the beneficiary from its tax authority in its country of residence. Therefore, the obligation of withholding tax is waived and tax information will be reported to the tax authorities.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_YlcJ09p-Ed-ak6NoX_4Aeg_403830075")]
    [Description(@"Tax certificate is provided by the beneficiary from its tax authority in its country of residence. Therefore, the obligation of withholding tax is waived and tax information will be reported to the tax authorities.")]
    TaxCertificate = TaxWithholdingMethodCode.TaxCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is withheld at source and the tax information is also reported to the tax authorities.
    /// Encoded/decoded by serializers as &quot;WTRE&quot;.
    /// </summary>
    [EnumMember(Value = "WTRE")]
    [IsoId("_YlcJ1Np-Ed-ak6NoX_4Aeg_403830117")]
    [Description(@"Tax is withheld at source and the tax information is also reported to the tax authorities.")]
    WithholdTaxAndReport = TaxWithholdingMethodCode.WithholdTaxAndReport, // same ordinal as derivation source for type conversions
    
}
