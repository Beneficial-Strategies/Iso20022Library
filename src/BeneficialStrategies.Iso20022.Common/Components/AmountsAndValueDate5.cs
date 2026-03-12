// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value date and the amounts traded in a foreign exchange option trade.
/// </summary>
[IsoId("_TIwetNp-Ed-ak6NoX_4Aeg_-974658214")]
[DisplayName("Amounts And Value Date")]
public partial record AmountsAndValueDate5
{
    #nullable enable
    
    /// <summary>
    /// Call amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TIwetdp-Ed-ak6NoX_4Aeg_-974658188")]
    [DisplayName("Call Amount")]
    [IsoXmlTag("CallAmt")]
    public required ActiveOrHistoricCurrencyAndAmount CallAmount { get; init; } 
    
    /// <summary>
    /// Put amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TIwettp-Ed-ak6NoX_4Aeg_-974658137")]
    [DisplayName("Put Amount")]
    [IsoXmlTag("PutAmt")]
    public required ActiveOrHistoricCurrencyAndAmount PutAmount { get; init; } 
    
    /// <summary>
    /// Agreement between two parties in which one party buys a currency and the other party sells a different currency.
    /// </summary>
    [IsoId("_TIwet9p-Ed-ak6NoX_4Aeg_-831511638")]
    [DisplayName("Option Settlement Currency")]
    [IsoXmlTag("OptnSttlmCcy")]
    public ActiveOrHistoricCurrencyCode? OptionSettlementCurrency { get; init; } 
    
    /// <summary>
    /// Date on which the trade is settled, ie, the amounts are due.
    /// </summary>
    [IsoId("_TIweuNp-Ed-ak6NoX_4Aeg_-974658172")]
    [DisplayName("Final Settlement Date")]
    [IsoXmlTag("FnlSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalSettlementDate { get; init; } 
    
    
    #nullable disable
    
}
