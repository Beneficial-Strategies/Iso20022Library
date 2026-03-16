// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Informative Tax2.
/// </summary>
[IsoId("_1qys2RwMEe6O0NdiBuX__w")]
[DisplayName("Informative Tax2")]
public partial record InformativeTax2
{
    #nullable enable

    /// <summary>
    /// EU Capital Gain.
    /// </summary>
    [DisplayName("EU Capital Gain")]
    [IsoXmlTag("EUCptlGn")]
    public EUCapitalGain3Choice_? EUCapitalGain { get; init; } 

    /// <summary>
    /// EU Dividend Status.
    /// </summary>
    [DisplayName("EU Dividend Status")]
    [IsoXmlTag("EUDvddSts")]
    public EUDividendStatusType2Choice_? EUDividendStatus { get; init; } 

    /// <summary>
    /// Individual Tax.
    /// </summary>
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public ValueList<Tax40> IndividualTax { get; init; } = [];

    /// <summary>
    /// Percentage Of Debt Claim.
    /// </summary>
    [DisplayName("Percentage Of Debt Claim")]
    [IsoXmlTag("PctgOfDebtClm")]
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; } 

    /// <summary>
    /// Taxable Income Per Dividend.
    /// </summary>
    [DisplayName("Taxable Income Per Dividend")]
    [IsoXmlTag("TaxblIncmPerDvdd")]
    public ActiveCurrencyAndAmount? TaxableIncomePerDividend { get; init; } 

    
    #nullable disable
    
}
