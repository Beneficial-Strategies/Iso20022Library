// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a loyalty service. A loyalty request contents : the loyalty transaction request and the loyalty data if any.
/// </summary>
[IsoId("_e-jnMXGvEe2TbaNWBpRZpQ")]
[DisplayName("Loyalty Request")]
public record LoyaltyRequest5
{
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    [IsoId("_fE1OUXGvEe2TbaNWBpRZpQ")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }

    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    [IsoId("_fE1OU3GvEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required LoyaltyTransaction5 Transaction { get; init; }

    /// <summary>
    /// Data related to a Loyalty program or account.
    /// </summary>
    [IsoId("_fE1OVXGvEe2TbaNWBpRZpQ")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public LoyaltyRequestData3? Data { get; init; }
}
