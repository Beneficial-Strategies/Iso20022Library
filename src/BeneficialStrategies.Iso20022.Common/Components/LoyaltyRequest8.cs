// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a loyalty service. A loyalty request contents: the loyalty transaction request and the loyalty data if any.
/// </summary>
[IsoId("_0qH3obZZEfCUZfsQO4rYeA")]
[DisplayName("Loyalty Request8")]
public record LoyaltyRequest8
{
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    [IsoId("_0rJyZbZZEfCUZfsQO4rYeA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }

    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    [IsoId("_0rJya7ZZEfCUZfsQO4rYeA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required LoyaltyTransaction8 Transaction { get; init; }

    /// <summary>
    /// Data related to a loyalty program or account.
    /// </summary>
    [IsoId("_0rJycbZZEfCUZfsQO4rYeA")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<LoyaltyRequestData3> Data { get; init; } = [];
}
