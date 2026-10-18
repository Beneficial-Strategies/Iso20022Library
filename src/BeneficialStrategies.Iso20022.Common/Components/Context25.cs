// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card payment transaction is performed.
/// </summary>
[IsoId("_nY3pIRTYEfC_aaedwHHlmw")]
[DisplayName("Context25")]
public record Context25
{
    /// <summary>
    /// Entry mode of the card data for the transaction.
    /// </summary>
    [IsoId("_nfvtMRTYEfC_aaedwHHlmw")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading11Code? CardDataEntryMode { get; init; }

    /// <summary>
    /// Other type of card data entry mode.
    /// </summary>
    [IsoId("_nfvtRRTYEfC_aaedwHHlmw")]
    [DisplayName("Other Card Data Entry Mode")]
    [IsoXmlTag("OthrCardDataNtryMd")]
    public Max35Text? OtherCardDataEntryMode { get; init; }

    /// <summary>
    /// Method used to present a QR Code at the point of service.
    /// </summary>
    [IsoId("_nfvtRxTYEfC_aaedwHHlmw")]
    [DisplayName("QR Code Presentment Mode")]
    [IsoXmlTag("QRCdPresntmntMd")]
    public QRCodePresentmentMode2Code? QRCodePresentmentMode { get; init; }

    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    [IsoId("_nfvtSxTYEfC_aaedwHHlmw")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public ISO18245MerchantCategoryCode? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Further details about the merchant that is used with the merchant category code for the particular purchase.
    /// </summary>
    [IsoId("_nfvtWRTYEfC_aaedwHHlmw")]
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    public Max35Text? MerchantCategorySpecificData { get; init; }

    /// <summary>
    /// Other merchant category assigned by local or national scheme.
    /// </summary>
    [IsoId("_nfvtWxTYEfC_aaedwHHlmw")]
    [DisplayName("Other Merchant Category")]
    [IsoXmlTag("OthrMrchntCtgy")]
    public Max35Text? OtherMerchantCategory { get; init; }

    /// <summary>
    /// A code identifying transaction conditions at the point-of-sale or point of service.
    /// </summary>
    [IsoId("_Gd_ykWQAEfCX7uJiAWHfoQ")]
    [DisplayName("POS Condition Code")]
    [IsoXmlTag("POSCondCd")]
    public ISO8583POSConditionCode? POSConditionCode { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_nfvtXRTYEfC_aaedwHHlmw")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    public TrueFalseIndicator? CardPresent { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_nfvtaxTYEfC_aaedwHHlmw")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    public TrueFalseIndicator? CardholderPresent { get; init; }

    /// <summary>
    /// Indicates whether the automated device was operated solely by the cardholder or not.
    /// </summary>
    [IsoId("_nfvteRTYEfC_aaedwHHlmw")]
    [DisplayName("Cardholder Activated")]
    [IsoXmlTag("CrdhldrActvtd")]
    public TrueFalseIndicator? CardholderActivated { get; init; }

    /// <summary>
    /// Transaction initiated through a transponder or not.
    /// </summary>
    [IsoId("_nfvtgRTYEfC_aaedwHHlmw")]
    [DisplayName("Transponder Initiated")]
    [IsoXmlTag("TrnspndrInittd")]
    public TrueFalseIndicator? TransponderInitiated { get; init; }

    /// <summary>
    /// Indicates a transit transaction.
    /// </summary>
    [IsoId("_nfvtgxTYEfC_aaedwHHlmw")]
    [DisplayName("Transit")]
    [IsoXmlTag("Trnst")]
    public TrueFalseIndicator? Transit { get; init; }

    /// <summary>
    /// Card acceptor representative in attendance at the point of service during the transaction.
    /// </summary>
    [IsoId("_nfvthRTYEfC_aaedwHHlmw")]
    [DisplayName("Attended")]
    [IsoXmlTag("Attndd")]
    public TrueFalseIndicator? Attended { get; init; }

    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [IsoId("_nfvtmRTYEfC_aaedwHHlmw")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    public Max35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Indicates whether the point of service is an e-commerce one or not.
    /// </summary>
    [IsoId("_nfvtmxTYEfC_aaedwHHlmw")]
    [DisplayName("E Commerce")]
    [IsoXmlTag("EComrc")]
    public TrueFalseIndicator? ECommerce { get; init; }

    /// <summary>
    /// Contains the applied level of security of e-commerce transaction.
    /// </summary>
    [IsoId("_nfvtnRTYEfC_aaedwHHlmw")]
    [DisplayName("E Commerce Indicator Applied")]
    [IsoXmlTag("EComrcIndApld")]
    public Max35Text? ECommerceIndicatorApplied { get; init; }

    /// <summary>
    /// Contains electronic commerce data.
    /// </summary>
    [IsoId("_nfvtpRTYEfC_aaedwHHlmw")]
    [DisplayName("E Commerce Data")]
    [IsoXmlTag("EComrcData")]
    public LaxProcessing? ECommerceData { get; init; }

    /// <summary>
    /// A code that identifies the type of MOTO transaction.
    /// </summary>
    [IsoId("_nfvtpxTYEfC_aaedwHHlmw")]
    [DisplayName("MOTO Code")]
    [IsoXmlTag("MOTOCd")]
    public MOTO2Code? MOTOCode { get; init; }

    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_nfvtqRTYEfC_aaedwHHlmw")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; }

    /// <summary>
    /// Indicates a delayed charge.
    /// </summary>
    [IsoId("_nfvtqxTYEfC_aaedwHHlmw")]
    [DisplayName("Delayed Charges")]
    [IsoXmlTag("DelydChrgs")]
    public TrueFalseIndicator? DelayedCharges { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee.
    /// </summary>
    [IsoId("_nfvtrRTYEfC_aaedwHHlmw")]
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public TrueFalseIndicator? NoShow { get; init; }

    /// <summary>
    /// Indicates a reauthorisation.
    /// </summary>
    [IsoId("_nfvtrxTYEfC_aaedwHHlmw")]
    [DisplayName("Reauthorisation")]
    [IsoXmlTag("Reauthstn")]
    public TrueFalseIndicator? Reauthorisation { get; init; }

    /// <summary>
    /// Indicates a resubmission.
    /// </summary>
    [IsoId("_nfvtsRTYEfC_aaedwHHlmw")]
    [DisplayName("Re Submission")]
    [IsoXmlTag("ReSubmissn")]
    public TrueFalseIndicator? ReSubmission { get; init; }

    /// <summary>
    /// Indicates whether the authorisation was delayed due to an on-board initiated transaction.
    /// </summary>
    [IsoId("_nfvtsxTYEfC_aaedwHHlmw")]
    [DisplayName("Delayed Authorisation")]
    [IsoXmlTag("DelydAuthstn")]
    public TrueFalseIndicator? DelayedAuthorisation { get; init; }

    /// <summary>
    /// Indicates a late presentment as defined by each specific implementation.
    /// </summary>
    [IsoId("_nfvttRTYEfC_aaedwHHlmw")]
    [DisplayName("Late Presentment")]
    [IsoXmlTag("LatePresntmnt")]
    public TrueFalseIndicator? LatePresentment { get; init; }

    /// <summary>
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// </summary>
    [IsoId("_nfvttxTYEfC_aaedwHHlmw")]
    [DisplayName("Deferred Delivery")]
    [IsoXmlTag("DfrrdDlvry")]
    public TrueFalseIndicator? DeferredDelivery { get; init; }

    /// <summary>
    /// Indicates the partial shipment.
    /// </summary>
    [IsoId("_nfvtuRTYEfC_aaedwHHlmw")]
    [DisplayName("Partial Shipment")]
    [IsoXmlTag("PrtlShipmnt")]
    public TrueFalseIndicator? PartialShipment { get; init; }

    /// <summary>
    /// Indicates whether the payment transaction is a partial payment of the sale transaction.
    /// </summary>
    [IsoId("_nfvtuxTYEfC_aaedwHHlmw")]
    [DisplayName("Split Payment")]
    [IsoXmlTag("SpltPmt")]
    public TrueFalseIndicator? SplitPayment { get; init; }

    /// <summary>
    /// Indicates whether the point of service supports partial approval or not.
    /// </summary>
    [IsoId("_nfvtvRTYEfC_aaedwHHlmw")]
    [DisplayName("Partial Approval Supported")]
    [IsoXmlTag("PrtlApprvlSpprtd")]
    public TrueFalseIndicator? PartialApprovalSupported { get; init; }

    /// <summary>
    /// Security characteristics of the communication link in the card acceptance process.
    /// </summary>
    [IsoId("_nfvtvxTYEfC_aaedwHHlmw")]
    [DisplayName("Security Characteristics")]
    [IsoXmlTag("SctyChrtcs")]
    public SimpleValueList<SecurityCharacteristics2Code> SecurityCharacteristics { get; init; } = [];

    /// <summary>
    /// Storage location of payment credential (for example, Acceptor or third party wallet).
    /// </summary>
    [IsoId("_nfvtyRTYEfC_aaedwHHlmw")]
    [DisplayName("Storage Location")]
    [IsoXmlTag("StorgLctn")]
    public Max35Text? StorageLocation { get; init; }

    /// <summary>
    /// Indicates that the consumer authentication process is temporarily unavailable in the acceptance, acquirer or agent environment for this request.
    /// </summary>
    [IsoId("_nfvtyxTYEfC_aaedwHHlmw")]
    [DisplayName("Authentication Outage")]
    [IsoXmlTag("AuthntcnOutg")]
    public TrueFalseIndicator? AuthenticationOutage { get; init; }

    /// <summary>
    /// Indicates the relationship between payment credential and merchant.
    /// </summary>
    [IsoId("_nfvt3xTYEfC_aaedwHHlmw")]
    [DisplayName("Payment Credential Merchant Relationship")]
    [IsoXmlTag("PmtCrdntlMrchntRltsh")]
    public TrueFalseIndicator? PaymentCredentialMerchantRelationship { get; init; }

    /// <summary>
    /// Date the transaction was completed and captured.
    /// </summary>
    [IsoId("_nfvt4RTYEfC_aaedwHHlmw")]
    [DisplayName("Capture Date")]
    [IsoXmlTag("CaptrDt")]
    public DateOnly? CaptureDate { get; init; }

    /// <summary>
    /// The date on which the sale or purchase is expected to occur.
    /// </summary>
    [IsoId("_nfvt4xTYEfC_aaedwHHlmw")]
    [DisplayName("Date Anticipated")]
    [IsoXmlTag("DtAntcptd")]
    public DateOnly? DateAnticipated { get; init; }

    /// <summary>
    /// Indicates a chip data fallback.
    /// </summary>
    [IsoId("_y7hM8RTYEfC_aaedwHHlmw")]
    [DisplayName("ICC Fallback")]
    [IsoXmlTag("ICCFllbck")]
    public TrueFalseIndicator? ICCFallback { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_f-zyQa8eEfCnL-2fAG0ssA")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_f-zyQq8eEfCnL-2fAG0ssA")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
