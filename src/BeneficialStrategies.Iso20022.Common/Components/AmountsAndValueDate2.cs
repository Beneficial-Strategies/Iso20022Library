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
[IsoId("_TIc8stp-Ed-ak6NoX_4Aeg_-1119895045")]
[DisplayName("Amounts And Value Date")]
public partial record AmountsAndValueDate2
{
    #nullable enable
    
    /// <summary>
    /// Call amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TIc8s9p-Ed-ak6NoX_4Aeg_-1076491577")]
    [DisplayName("Call Amount")]
    [IsoXmlTag("CallAmt")]
    public required ActiveOrHistoricCurrencyAndAmount CallAmount { get; init; } 
    
    /// <summary>
    /// Put amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TIc8tNp-Ed-ak6NoX_4Aeg_-1076491517")]
    [DisplayName("Put Amount")]
    [IsoXmlTag("PutAmt")]
    public required ActiveOrHistoricCurrencyAndAmount PutAmount { get; init; } 
    
    /// <summary>
    /// Date on which the trade is settled, ie, the amounts are due.
    /// </summary>
    [IsoId("_TIc8tdp-Ed-ak6NoX_4Aeg_-1076491560")]
    [DisplayName("Final Settlement Date")]
    [IsoXmlTag("FnlSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate FinalSettlementDate { get; init; } 
    
    
    #nullable disable
    
}
