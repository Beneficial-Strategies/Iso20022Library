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
[IsoId("_TE9DmgEcEeCQm6a_G2yO_w_1015310936")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction2
{
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_TE9DmwEcEeCQm6a_G2yO_w_-1447474796")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_TE9DnAEcEeCQm6a_G2yO_w_311259364")]
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_TE9DnQEcEeCQm6a_G2yO_w_1451788064")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    [IsoId("_TE9DngEcEeCQm6a_G2yO_w_1116760785")]
    [DisplayName("Interchange Data")]
    [IsoXmlTag("IntrchngData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InterchangeData { get; init; }

    /// <summary>
    /// Detail of the transaction transported.
    /// </summary>
    [IsoId("_TFGNgAEcEeCQm6a_G2yO_w_-1381976874")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails2 TransactionDetails { get; init; }
}
