// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether there is cash in the account awaiting investment.
/// </summary>
[IsoId("_lCZdAJP6EemyZbjY08A1Vw")]
[DisplayName("Residual Cash")]
public partial record ResidualCash1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether there is cash in the account awaiting investment.
    /// </summary>
    [IsoId("_sjPYQZP6EemyZbjY08A1Vw")]
    [DisplayName("Residual Cash Indicator")]
    [IsoXmlTag("RsdlCshInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ResidualCashIndicator { get; init; } 
    
    /// <summary>
    /// Currency of the cash.
    /// </summary>
    [IsoId("___3wEJP6EemyZbjY08A1Vw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    
    #nullable disable
    
}
