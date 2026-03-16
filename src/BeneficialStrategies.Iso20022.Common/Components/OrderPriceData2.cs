// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order Price Data2.
/// </summary>
[IsoId("_K7FZARA4Ee6N57R8Wekj-w")]
[DisplayName("Order Price Data2")]
public partial record OrderPriceData2
{
    #nullable enable

    /// <summary>
    /// Additional Limit Price.
    /// </summary>
    [DisplayName("Additional Limit Price")]
    [IsoXmlTag("AddtlLmtPric")]
    public SecuritiesTransactionPrice2Choice_? AdditionalLimitPrice { get; init; } 

    /// <summary>
    /// Currency Second Leg.
    /// </summary>
    [DisplayName("Currency Second Leg")]
    [IsoXmlTag("CcyScndLeg")]
    public ActiveOrHistoricCurrencyCode? CurrencySecondLeg { get; init; } 

    /// <summary>
    /// Limit Price.
    /// </summary>
    [DisplayName("Limit Price")]
    [IsoXmlTag("LmtPric")]
    public SecuritiesTransactionPrice2Choice_? LimitPrice { get; init; } 

    /// <summary>
    /// Pegged Price.
    /// </summary>
    [DisplayName("Pegged Price")]
    [IsoXmlTag("PggdPric")]
    public SecuritiesTransactionPrice2Choice_? PeggedPrice { get; init; } 

    /// <summary>
    /// Stop Price.
    /// </summary>
    [DisplayName("Stop Price")]
    [IsoXmlTag("StopPric")]
    public SecuritiesTransactionPrice2Choice_? StopPrice { get; init; } 

    
    #nullable disable
    
}
