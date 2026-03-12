// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies how the cash in the account that is awaiting investment is to be dealt with.
/// </summary>
[IsoId("_s2vtoJP7EemyZbjY08A1Vw")]
[DisplayName("Residual Cash")]
public partial record ResidualCash2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the cash in the account awaiting investment is to be transferred.
    /// </summary>
    [IsoId("_xVSVgZP7EemyZbjY08A1Vw")]
    [DisplayName("Indicator")]
    [IsoXmlTag("Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Indicator { get; init; } 
    
    /// <summary>
    /// Currency of the cash.
    /// </summary>
    [IsoId("_3ru6MJP7EemyZbjY08A1Vw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    
    #nullable disable
    
}
