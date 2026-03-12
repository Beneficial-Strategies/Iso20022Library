// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used to calculate the tax.
/// </summary>
[IsoId("_VSSXBdp-Ed-ak6NoX_4Aeg_-1673886358")]
[DisplayName("Tax Calculation Information")]
public partial record TaxCalculationInformation2
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_VSSXBtp-Ed-ak6NoX_4Aeg_-1625862857")]
    [DisplayName("EU Capital Gain")]
    [IsoXmlTag("EUCptlGn")]
    public EUCapitalGain1? EUCapitalGain { get; init; } 
    
    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    [IsoId("_VSSXB9p-Ed-ak6NoX_4Aeg_-1140089322")]
    [DisplayName("Percentage Of Debt Claim")]
    [IsoXmlTag("PctgOfDebtClm")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; } 
    
    /// <summary>
    /// Percentage of grandfathered debt claim.
    /// </summary>
    [IsoId("_VSSXCNp-Ed-ak6NoX_4Aeg_-1286004635")]
    [DisplayName("Percentage Grandfathered Debt")]
    [IsoXmlTag("PctgGrdfthdDebt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageGrandfatheredDebt { get; init; } 
    
    
    #nullable disable
    
}
