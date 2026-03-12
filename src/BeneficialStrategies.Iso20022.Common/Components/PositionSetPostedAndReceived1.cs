// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_9h9p68WLEeiRga8tPu1L4Q")]
[DisplayName("Position Set Posted And Received")]
public partial record PositionSetPostedAndReceived1
{
    #nullable enable
    
    /// <summary>
    /// Value posted by the reporting counterparty. 
    /// Usage: This field should include the overall value posted for the portfolio.
    /// </summary>
    [IsoId("_9h9p7MWLEeiRga8tPu1L4Q")]
    [DisplayName("Posted")]
    [IsoXmlTag("Pstd")]
    public ActiveOrHistoricCurrencyAnd20Amount? Posted { get; init; } 
    
    /// <summary>
    /// Value received by the reporting counterparty. 
    /// Usage: This field should include the overall value received for the portfolio.
    /// </summary>
    [IsoId("_9h9p7cWLEeiRga8tPu1L4Q")]
    [DisplayName("Received")]
    [IsoXmlTag("Rcvd")]
    public ActiveOrHistoricCurrencyAnd20Amount? Received { get; init; } 
    
    
    #nullable disable
    
}
