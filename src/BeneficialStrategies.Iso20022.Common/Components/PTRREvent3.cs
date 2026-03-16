// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information if contract results from a post trade risk reduction operation.
/// </summary>
[IsoId("_CElm0Vo4Ee23K4GXSpBSeg")]
[DisplayName("PTRR Event")]
public record PTRREvent3
{
    /// <summary>
    /// Indicator of a type of a post trade risk reduction operation for the purpose of reporting.
    /// Portfolio Compression without a third-party service provider: An arrangement to reduce risk in existing portfolios of trades using non-price forming trades mainly to reduce notional amount outstanding, the number of transactions or otherwise harmonise the terms, by wholly or partially terminate trades and commonly to replace the terminated derivatives with new replacement trades.
    /// Portfolio Compression with a third-party service provider or CCP: A post trade risk reduction service provided by a service provider or CCP to reduce risk in existing portfolios of trades using non-price forming trades mainly to reduce notional amount outstanding, the number of transactions or otherwise harmonise the terms, by wholly or partially terminate trades and commonly to replace the terminated derivatives with new replacement trades.
    /// Portfolio Rebalancing/Margin management: A PTRR service provided by a service provider to reduce risk in an existing portfolio of trades by adding new non-price forming trades and where no existing trades in the portfolio are terminated or replaced and the notional is increased rather than decreased.
    /// Other Portfolio post trade risk reduction services: A post trade risk reduction service provided by a service provider to reduce risk in existing portfolios of trades using non-price forming trades and where such service does not qualify as Portfolio Compression or Portfolio Rebalancing.
    /// </summary>
    [IsoId("_CF_VAVo4Ee23K4GXSpBSeg")]
    [DisplayName("Technique")]
    [IsoXmlTag("Tchnq")]
    public RiskReductionService1Code? Technique { get; init; }

    /// <summary>
    /// Identification of the post trade risk reduction service provider.
    /// </summary>
    [IsoId("_CF_VA1o4Ee23K4GXSpBSeg")]
    [DisplayName("Service Provider")]
    [IsoXmlTag("SvcPrvdr")]
    public OrganisationIdentification15Choice_? ServiceProvider { get; init; }
}
