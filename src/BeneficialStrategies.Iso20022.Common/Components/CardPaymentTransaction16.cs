// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the cancellation advice.
/// </summary>
[IsoId("_s9kR0R0hEeK5OKMB21JFBg")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction16
{
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_tKD1tR0hEeK5OKMB21JFBg")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; }

    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_tKD1uR0hEeK5OKMB21JFBg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_tKD1vR0hEeK5OKMB21JFBg")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public CardPaymentTransaction17? OriginalTransaction { get; init; }

    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    [IsoId("_tKD1wR0hEeK5OKMB21JFBg")]
    [DisplayName("Transaction Success")]
    [IsoXmlTag("TxSucss")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; }

    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been approved by the acquirer.
    /// </summary>
    [IsoId("_tKD1xR0hEeK5OKMB21JFBg")]
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Reversal { get; init; }

    /// <summary>
    /// List of incidents during the transaction.
    /// </summary>
    [IsoId("_tKD1yR0hEeK5OKMB21JFBg")]
    [DisplayName("Failure Reason")]
    [IsoXmlTag("FailrRsn")]
    public SimpleValueList<FailureReason2Code> FailureReason { get; init; } = [];

    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_tKD1zR0hEeK5OKMB21JFBg")]
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_tKD10R0hEeK5OKMB21JFBg")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    [IsoId("_tKD11R0hEeK5OKMB21JFBg")]
    [DisplayName("Interchange Data")]
    [IsoXmlTag("IntrchngData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InterchangeData { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_tKD12R0hEeK5OKMB21JFBg")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public required CardPaymentTransactionDetails7 TransactionDetails { get; init; }

    /// <summary>
    /// Outcome of the authorisation.
    /// </summary>
    [IsoId("_tKD13R0hEeK5OKMB21JFBg")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult2? AuthorisationResult { get; init; }

    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_tKD14R0hEeK5OKMB21JFBg")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    public SimpleValueList<IsoMax70Text> AdditionalTransactionData { get; init; } = [];
}
