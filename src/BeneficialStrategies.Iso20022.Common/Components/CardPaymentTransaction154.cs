// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the authorisation response.
/// </summary>
[IsoId("_ZL4EsbZXEfCUZfsQO4rYeA")]
[DisplayName("Card Payment Transaction154")]
public record CardPaymentTransaction154
{
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_ZM8btbZXEfCUZfsQO4rYeA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_ZM8bu7ZXEfCUZfsQO4rYeA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_ZM8bwbZXEfCUZfsQO4rYeA")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_ZM8bx7ZXEfCUZfsQO4rYeA")]
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    public IsoMax140Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_ZM8bzbZXEfCUZfsQO4rYeA")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    [IsoId("_ZM8b07ZXEfCUZfsQO4rYeA")]
    [DisplayName("Interchange Data")]
    [IsoXmlTag("IntrchngData")]
    public IsoMax140Text? InterchangeData { get; init; }

    /// <summary>
    /// Detail of the transaction transported.
    /// </summary>
    [IsoId("_ZM8b2bZXEfCUZfsQO4rYeA")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails54 TransactionDetails { get; init; }

    /// <summary>
    /// Merchant related information provided in the request.
    /// </summary>
    [IsoId("_ZM8b37ZXEfCUZfsQO4rYeA")]
    [DisplayName("Merchant Reference Data")]
    [IsoXmlTag("MrchntRefData")]
    public IsoMax70Text? MerchantReferenceData { get; init; }

    /// <summary>
    /// Message from a merchant to be displayed on the cardholder bank statement.
    /// </summary>
    [IsoId("_e5OpEbZXEfCUZfsQO4rYeA")]
    [DisplayName("Message From Merchant")]
    [IsoXmlTag("MsgFrMrchnt")]
    public ValueList<Action18> MessageFromMerchant { get; init; } = [];
}
