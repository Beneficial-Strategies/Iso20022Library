// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information if contract results from a post trade risk reduction operation.
/// </summary>
[IsoId("_1GhnIfbdEeyInphUKJZxtQ")]
[DisplayName("PTRR Event")]
public partial record PTRREvent2
{
    #nullable enable
    
    /// <summary>
    /// Indicator of a type of a post trade risk reduction operation for the purpose of reporting. 
    /// Portfolio Compression without a third-party service provider: An arrangement to reduce risk in existing portfolios of trades using non-price forming trades mainly to reduce notional amount outstanding, the number of transactions or otherwise harmonise the terms, by wholly or partially terminate trades and commonly to replace the terminated derivatives with new replacement trades.
    /// Portfolio Compression with a third-party service provider or CCP: A post trade risk reduction service provided by a service provider or CCP to reduce risk in existing portfolios of trades using non-price forming trades mainly to reduce notional amount outstanding, the number of transactions or otherwise harmonise the terms, by wholly or partially terminate trades and commonly to replace the terminated derivatives with new replacement trades.
    /// Portfolio Rebalancing/Margin management: A PTRR service provided by a service provider to reduce risk in an existing portfolio of trades by adding new non-price forming trades and where no existing trades in the portfolio are terminated or replaced and the notional is increased rather than decreased.
    /// Other Portfolio post trade risk reduction services: A post trade risk reduction service provided by a service provider to reduce risk in existing portfolios of trades using non-price forming trades and where such service does not qualify as Portfolio Compression or Portfolio Rebalancing.
    /// </summary>
    [IsoId("_1HX7sfbdEeyInphUKJZxtQ")]
    [DisplayName("Technique")]
    [IsoXmlTag("Tchnq")]
    public required RiskReductionService1Code Technique { get; init; } 
    
    /// <summary>
    /// Identification of the post trade risk reduction service provider.
    /// </summary>
    [IsoId("_1HX7s_bdEeyInphUKJZxtQ")]
    [DisplayName("Service Provider")]
    [IsoXmlTag("SvcPrvdr")]
    public OrganisationIdentification15Choice_? ServiceProvider { get; init; } 
    
    
    #nullable disable
    
}
