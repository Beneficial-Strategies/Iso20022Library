// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to commodities and related informations used as a collateral.
/// </summary>
[IsoId("_X74TEcg7EeuWwaMSwXJLEA")]
[DisplayName("Commodity")]
public partial record Commodity43
{
    #nullable enable
    
    /// <summary>
    /// Details on commodities assignments to sectors.
    /// </summary>
    [IsoId("_X-T8A8g7EeuWwaMSwXJLEA")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public AssetClassCommodity5Choice_? Classification { get; init; } 
    
    /// <summary>
    /// Quantity of the commodity.
    /// </summary>
    [IsoId("_X-T8Bcg7EeuWwaMSwXJLEA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity17? Quantity { get; init; } 
    
    /// <summary>
    /// Price of unit of asset or collateral component, including accrued interest for interest-bearing securities, used to value the commodity .
    /// </summary>
    [IsoId("_X-T8B8g7EeuWwaMSwXJLEA")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; } 
    
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_X-T8Ccg7EeuWwaMSwXJLEA")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public AmountAndDirection53? MarketValue { get; init; } 
    
    
    #nullable disable
    
}
