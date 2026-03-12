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
[IsoId("_TImttNp-Ed-ak6NoX_4Aeg_128911716")]
[DisplayName("Amounts And Value Date")]
public partial record AmountsAndValueDate3
{
    #nullable enable
    
    /// <summary>
    /// Call amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TImttdp-Ed-ak6NoX_4Aeg_128911718")]
    [DisplayName("Call Amount")]
    [IsoXmlTag("CallAmt")]
    public required ActiveOrHistoricCurrencyAndAmount CallAmount { get; init; } 
    
    /// <summary>
    /// Put amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TImtttp-Ed-ak6NoX_4Aeg_128911993")]
    [DisplayName("Put Amount")]
    [IsoXmlTag("PutAmt")]
    public required ActiveOrHistoricCurrencyAndAmount PutAmount { get; init; } 
    
    /// <summary>
    /// Date on which the trade is settled, ie, the amounts are due.
    /// </summary>
    [IsoId("_TImtt9p-Ed-ak6NoX_4Aeg_128911758")]
    [DisplayName("Final Settlement Date")]
    [IsoXmlTag("FnlSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalSettlementDate { get; init; } 
    
    
    #nullable disable
    
}
