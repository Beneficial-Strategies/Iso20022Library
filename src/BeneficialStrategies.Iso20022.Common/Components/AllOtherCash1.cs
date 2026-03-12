// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash
/// </summary>
[IsoId("_7JSJsJP8EemyZbjY08A1Vw")]
[DisplayName("All Other Cash")]
public partial record AllOtherCash1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_AUwJAZP9EemyZbjY08A1Vw")]
    [DisplayName("Indicator")]
    [IsoXmlTag("Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Indicator { get; init; } 
    
    /// <summary>
    /// Currency of the cash.
    /// </summary>
    [IsoId("_DNOyAZP9EemyZbjY08A1Vw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    
    #nullable disable
    
}
