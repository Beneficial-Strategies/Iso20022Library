// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information regarding the total amount of taxes.
/// </summary>
[IsoId("_WKLBTNp-Ed-ak6NoX_4Aeg_-1710794276")]
[DisplayName("Total Taxes")]
public record TotalTaxes5
{
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_WKULMNp-Ed-ak6NoX_4Aeg_-1709874182")]
    [DisplayName("EU Capital Gain")]
    [IsoXmlTag("EUCptlGn")]
    public EUCapitalGain2Code? EUCapitalGain { get; init; }

    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    [IsoId("_WKULMdp-Ed-ak6NoX_4Aeg_-1709874006")]
    [DisplayName("Percentage Of Debt Claim")]
    [IsoXmlTag("PctgOfDebtClm")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; }

    /// <summary>
    /// Information related to a specific tax.
    /// </summary>
    [IsoId("_WKULMtp-Ed-ak6NoX_4Aeg_-1709873727")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    [MinLength(0)]
    [MaxLength(7)]
    public ValueList<Tax20> TaxDetails { get; init; } = [];
}
