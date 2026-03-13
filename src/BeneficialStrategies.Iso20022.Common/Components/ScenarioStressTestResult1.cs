// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the application of a hypothetical scenario on the valuation of a set of portfolios of financial instruments.
/// </summary>
[IsoId("_vWmhcKs9Eeayv9XxdmMwKQ")]
[DisplayName("Scenario Stress Test Result")]
public partial record ScenarioStressTestResult1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the stressed account.
    /// </summary>
    [IsoId("_MERKUKs_Eeayv9XxdmMwKQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification168 Identification { get; init; } 
    
    /// <summary>
    /// Result from the application of a stress test scenario to the positions in a cleared portfolio.
    /// </summary>
    [IsoId("_ZLzBQKs_Eeayv9XxdmMwKQ")]
    [DisplayName("Portfolio Stress Test Result")]
    [IsoXmlTag("PrtflStrssTstRslt")]
    public ValueList<PortfolioStressTestResult1> PortfolioStressTestResult { get; init; } = [];
    // ID for the above is _ZLzBQKs_Eeayv9XxdmMwKQ
    
    
    #nullable disable
    
}
