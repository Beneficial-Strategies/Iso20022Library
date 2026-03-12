// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for the first side of the transaction.
/// </summary>
[IsoId("_fRP9iwAFEeqefbt-QjTNnA")]
[DisplayName("Collateral Type")]
public partial record CollateralType16
{
    #nullable enable
    
    /// <summary>
    /// Data specific to securities and related fields used as a collateral.
    /// </summary>
    [IsoId("_fV50AQAFEeqefbt-QjTNnA")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public Security14? Security { get; init; } 
    
    /// <summary>
    /// Amount of funds provided as collateral for borrowing the securities or commodities.
    /// </summary>
    [IsoId("_fV50AwAFEeqefbt-QjTNnA")]
    [DisplayName("Cash")]
    [IsoXmlTag("Csh")]
    public AmountHaircutMargin1? Cash { get; init; } 
    
    /// <summary>
    /// Data specific to commodities and related fields used as a collateral.
    /// </summary>
    [IsoId("_fV50BQAFEeqefbt-QjTNnA")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public Commodity20? Commodity { get; init; } 
    
    
    #nullable disable
    
}
