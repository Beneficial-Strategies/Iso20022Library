// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loyalty Request6.
/// </summary>
[IsoId("_6tYQ8ZQxEe6HYLAajyhWIQ")]
[DisplayName("Loyalty Request6")]
public record LoyaltyRequest6
{
    /// <summary>
    /// Customer Order.
    /// </summary>
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }

    /// <summary>
    /// Data.
    /// </summary>
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<LoyaltyRequestData3> Data { get; init; } = [];

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required LoyaltyTransaction6 Transaction { get; init; }
}
