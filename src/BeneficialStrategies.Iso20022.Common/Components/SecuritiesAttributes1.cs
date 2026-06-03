// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the securities trades that make up the payment.
/// </summary>
[IsoId("15df450f-df3b-4230-9d9a-8fba15b89a4e")]
[DisplayName("Securities Attributes1")]
public record SecuritiesAttributes1
{
    /// <summary>
    /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction.
    /// </summary>
    [IsoId("990f0523-22dd-4e09-9b3d-eddb7308c0f8")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public required IsoUTIIdentifier UniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Amount of money for the trade.
    /// </summary>
    [IsoId("a264d9c2-b9dd-4b00-9d6c-9225ff512c45")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }
}
