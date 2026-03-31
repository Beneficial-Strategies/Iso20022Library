// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment completion advice response from the acquirer.
/// </summary>
[IsoId("_pUF2EU4UEeORpcABTQJgwA")]
[DisplayName("Card Payment Transaction Advice Response")]
public record CardPaymentTransactionAdviceResponse5
{
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_xigpAE4UEeORpcABTQJgwA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_peg9YU4UEeORpcABTQJgwA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Result of a requested service.
    /// </summary>
    [IsoId("_peg9Y04UEeORpcABTQJgwA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response1Code Response { get; init; }
}
