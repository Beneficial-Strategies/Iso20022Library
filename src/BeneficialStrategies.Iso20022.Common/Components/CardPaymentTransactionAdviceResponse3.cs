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
[IsoId("_9evdESpyEeKu3rbsflh_TQ")]
[DisplayName("Card Payment Transaction Advice Response")]
public record CardPaymentTransactionAdviceResponse3
{
    /// <summary>
    /// Unique identification of the transaction by the POI.
    /// </summary>
    [IsoId("_-CJsISpyEeKu3rbsflh_TQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_MFx-8CpzEeKu3rbsflh_TQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Result of a requested service.
    /// </summary>
    [IsoId("_-CJsJSpyEeKu3rbsflh_TQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response1Code Response { get; init; }
}
