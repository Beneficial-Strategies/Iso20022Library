// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric variables calculated on market exposures.
/// </summary>
[IsoId("_e45Eca5QEeuo-IflVgGqiA")]
[DisplayName("Exposure Metrics")]
public partial record ExposureMetrics5
{
    #nullable enable
    
    /// <summary>
    /// Amount of funds provided as collateral for borrowing the securities or commodities.
    /// </summary>
    [IsoId("_fHfhIa5QEeuo-IflVgGqiA")]
    [DisplayName("Cash Collateral Amount")]
    [IsoXmlTag("CshCollAmt")]
    public AmountAndDirection53? CashCollateralAmount { get; init; } 
    
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_fHfhI65QEeuo-IflVgGqiA")]
    [DisplayName("Collateral Market Value")]
    [IsoXmlTag("CollMktVal")]
    public AmountAndDirection53? CollateralMarketValue { get; init; } 
    
    
    #nullable disable
    
}
