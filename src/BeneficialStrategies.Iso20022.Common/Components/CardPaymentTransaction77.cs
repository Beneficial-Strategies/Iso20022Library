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
[IsoId("_mJH7WST5EeekRMwQV7VbMg")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction77
{
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_mJH7WyT5EeekRMwQV7VbMg")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_mJH7YCT5EeekRMwQV7VbMg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_mJH7XCT5EeekRMwQV7VbMg")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_mJH7XST5EeekRMwQV7VbMg")]
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_mJH7WiT5EeekRMwQV7VbMg")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    [IsoId("_mJH7XyT5EeekRMwQV7VbMg")]
    [DisplayName("Interchange Data")]
    [IsoXmlTag("IntrchngData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InterchangeData { get; init; }

    /// <summary>
    /// Detail of the transaction transported.
    /// </summary>
    [IsoId("_mJH7YST5EeekRMwQV7VbMg")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails28 TransactionDetails { get; init; }

    /// <summary>
    /// Merchant related information provided in the request.
    /// </summary>
    [IsoId("_mJH7XiT5EeekRMwQV7VbMg")]
    [DisplayName("Merchant Reference Data")]
    [IsoXmlTag("MrchntRefData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? MerchantReferenceData { get; init; }
}
