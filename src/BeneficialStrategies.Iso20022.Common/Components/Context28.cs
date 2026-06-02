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
[IsoId("_hCVNoWl2EfCyxsm1jzUNug")]
[DisplayName("Context28")]
public record Context28
{
    /// <summary>
    /// Entry mode of the card data for the transaction.
    /// </summary>
    [IsoId("_hE6nkWl2EfCyxsm1jzUNug")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public required CardDataReading11Code CardDataEntryMode { get; init; }

    /// <summary>
    /// Other type of card data entry mode.
    /// </summary>
    [IsoId("_hE6npWl2EfCyxsm1jzUNug")]
    [DisplayName("Other Card Data Entry Mode")]
    [IsoXmlTag("OthrCardDataNtryMd")]
    public IsoMax35Text? OtherCardDataEntryMode { get; init; }

    /// <summary>
    /// Method used to present a QR Code at the point of service.
    /// </summary>
    [IsoId("_hE6np2l2EfCyxsm1jzUNug")]
    [DisplayName("QR Code Presentment Mode")]
    [IsoXmlTag("QRCdPresntmntMd")]
    public QRCodePresentmentMode2Code? QRCodePresentmentMode { get; init; }

    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    [IsoId("_hE6nq2l2EfCyxsm1jzUNug")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public required ISO18245MerchantCategoryCode MerchantCategoryCode { get; init; }

    /// <summary>
    /// Further details about the merchant that is used with the merchant category code for the particular purchase.
    /// </summary>
    [IsoId("_hE6nuWl2EfCyxsm1jzUNug")]
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    public IsoMax35Text? MerchantCategorySpecificData { get; init; }

    /// <summary>
    /// Other merchant category assigned by local or national scheme.
    /// </summary>
    [IsoId("_hE6nu2l2EfCyxsm1jzUNug")]
    [DisplayName("Other Merchant Category")]
    [IsoXmlTag("OthrMrchntCtgy")]
    public IsoMax35Text? OtherMerchantCategory { get; init; }

    /// <summary>
    /// A code identifying transaction conditions at the point-of-sale or point of service.
    /// </summary>
    [IsoId("_jHSvAWl2EfCyxsm1jzUNug")]
    [DisplayName("POS Condition Code")]
    [IsoXmlTag("POSCondCd")]
    public ISO8583POSConditionCode? POSConditionCode { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_hE6nvWl2EfCyxsm1jzUNug")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    public IsoTrueFalseIndicator? CardPresent { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_hE6ny2l2EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; }

    /// <summary>
    /// Indicates whether the automated device was operated solely by the cardholder or not.
    /// </summary>
    [IsoId("_hE6n2Wl2EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Activated")]
    [IsoXmlTag("CrdhldrActvtd")]
    public IsoTrueFalseIndicator? CardholderActivated { get; init; }

    /// <summary>
    /// Transaction initiated through a transponder or not.
    /// </summary>
    [IsoId("_hE6n4Wl2EfCyxsm1jzUNug")]
    [DisplayName("Transponder Initiated")]
    [IsoXmlTag("TrnspndrInittd")]
    public IsoTrueFalseIndicator? TransponderInitiated { get; init; }

    /// <summary>
    /// Indicates a transit transaction.
    /// </summary>
    [IsoId("_hE6n42l2EfCyxsm1jzUNug")]
    [DisplayName("Transit")]
    [IsoXmlTag("Trnst")]
    public IsoTrueFalseIndicator? Transit { get; init; }

    /// <summary>
    /// Card acceptor representative in attendance at the point of service during the transaction.
    /// </summary>
    [IsoId("_hE6n5Wl2EfCyxsm1jzUNug")]
    [DisplayName("Attended")]
    [IsoXmlTag("Attndd")]
    public IsoTrueFalseIndicator? Attended { get; init; }

    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [IsoId("_hE6n-Wl2EfCyxsm1jzUNug")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Contains the proposed level of security of e-commerce transaction.
    /// </summary>
    [IsoId("_hE6n-2l2EfCyxsm1jzUNug")]
    [DisplayName("E Commerce Indicator Proposed")]
    [IsoXmlTag("EComrcIndPropsd")]
    public IsoMax35Text? ECommerceIndicatorProposed { get; init; }

    /// <summary>
    /// Indicates whether the point of service is an e-commerce one or not.
    /// </summary>
    [IsoId("_hE6oA2l2EfCyxsm1jzUNug")]
    [DisplayName("E Commerce")]
    [IsoXmlTag("EComrc")]
    public IsoTrueFalseIndicator? ECommerce { get; init; }

    /// <summary>
    /// Contains the applied level of security of e-commerce transaction.
    /// </summary>
    [IsoId("_hE6oBWl2EfCyxsm1jzUNug")]
    [DisplayName("E Commerce Indicator Applied")]
    [IsoXmlTag("EComrcIndApld")]
    public IsoMax35Text? ECommerceIndicatorApplied { get; init; }

    /// <summary>
    /// Contains electronic commerce data.
    /// </summary>
    [IsoId("_hE6oDWl2EfCyxsm1jzUNug")]
    [DisplayName("E Commerce Data")]
    [IsoXmlTag("EComrcData")]
    public ValueList<ECommerceData1> ECommerceData { get; init; } = [];

    /// <summary>
    /// A code that identifies the type of MOTO transaction.
    /// </summary>
    [IsoId("_hE6oD2l2EfCyxsm1jzUNug")]
    [DisplayName("MOTO Code")]
    [IsoXmlTag("MOTOCd")]
    public MOTO2Code? MOTOCode { get; init; }

    /// <summary>
    /// Identifies final authorisation messages for the purpose of managing open-to buy or available balance.
    /// </summary>
    [IsoId("_hE6oEWl2EfCyxsm1jzUNug")]
    [DisplayName("Final Authorisation")]
    [IsoXmlTag("FnlAuthstn")]
    public IsoTrueFalseIndicator? FinalAuthorisation { get; init; }

    /// <summary>
    /// Notifies the express consent of the customer for a given service.
    /// </summary>
    [IsoId("_hE6oE2l2EfCyxsm1jzUNug")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_hE6oFWl2EfCyxsm1jzUNug")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; }

    /// <summary>
    /// Indicates a delayed charge.
    /// </summary>
    [IsoId("_hE6oF2l2EfCyxsm1jzUNug")]
    [DisplayName("Delayed Charges")]
    [IsoXmlTag("DelydChrgs")]
    public IsoTrueFalseIndicator? DelayedCharges { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee.
    /// </summary>
    [IsoId("_hE6oGWl2EfCyxsm1jzUNug")]
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; }

    /// <summary>
    /// Indicates a reauthorisation.
    /// </summary>
    [IsoId("_hE6oG2l2EfCyxsm1jzUNug")]
    [DisplayName("Reauthorisation")]
    [IsoXmlTag("Reauthstn")]
    public IsoTrueFalseIndicator? Reauthorisation { get; init; }

    /// <summary>
    /// Indicates a resubmission.
    /// </summary>
    [IsoId("_hE6oHWl2EfCyxsm1jzUNug")]
    [DisplayName("Re Submission")]
    [IsoXmlTag("ReSubmissn")]
    public IsoTrueFalseIndicator? ReSubmission { get; init; }

    /// <summary>
    /// Indicates whether the authorisation was delayed due to an on-board initiated transaction.
    /// </summary>
    [IsoId("_hE6oH2l2EfCyxsm1jzUNug")]
    [DisplayName("Delayed Authorisation")]
    [IsoXmlTag("DelydAuthstn")]
    public IsoTrueFalseIndicator? DelayedAuthorisation { get; init; }

    /// <summary>
    /// Indicates a late presentment as defined by each specific implementation.
    /// </summary>
    [IsoId("_hE6oIWl2EfCyxsm1jzUNug")]
    [DisplayName("Late Presentment")]
    [IsoXmlTag("LatePresntmnt")]
    public IsoTrueFalseIndicator? LatePresentment { get; init; }

    /// <summary>
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// </summary>
    [IsoId("_hE6oI2l2EfCyxsm1jzUNug")]
    [DisplayName("Deferred Delivery")]
    [IsoXmlTag("DfrrdDlvry")]
    public IsoTrueFalseIndicator? DeferredDelivery { get; init; }

    /// <summary>
    /// Indicates the partial shipment.
    /// </summary>
    [IsoId("_hE6oJWl2EfCyxsm1jzUNug")]
    [DisplayName("Partial Shipment")]
    [IsoXmlTag("PrtlShipmnt")]
    public IsoTrueFalseIndicator? PartialShipment { get; init; }

    /// <summary>
    /// Indicates whether the payment transaction is a partial payment of the sale transaction.
    /// </summary>
    [IsoId("_hE6oJ2l2EfCyxsm1jzUNug")]
    [DisplayName("Split Payment")]
    [IsoXmlTag("SpltPmt")]
    public IsoTrueFalseIndicator? SplitPayment { get; init; }

    /// <summary>
    /// Indicates whether the point of service supports partial approval or not.
    /// </summary>
    [IsoId("_hE6oKWl2EfCyxsm1jzUNug")]
    [DisplayName("Partial Approval Supported")]
    [IsoXmlTag("PrtlApprvlSpprtd")]
    public IsoTrueFalseIndicator? PartialApprovalSupported { get; init; }

    /// <summary>
    /// Security characteristics of the communication link in the card acceptance process.
    /// </summary>
    [IsoId("_hE6oK2l2EfCyxsm1jzUNug")]
    [DisplayName("Security Characteristics")]
    [IsoXmlTag("SctyChrtcs")]
    public SimpleValueList<SecurityCharacteristics2Code> SecurityCharacteristics { get; init; } = [];

    /// <summary>
    /// Terminal has reused temporary secure stored card data.
    /// </summary>
    [IsoId("_hE6oNWl2EfCyxsm1jzUNug")]
    [DisplayName("Temporary Secure Card Data Reused")]
    [IsoXmlTag("TempScrCardDataReusd")]
    public IsoTrueFalseIndicator? TemporarySecureCardDataReused { get; init; }

    /// <summary>
    /// Storage location of payment credential (for example, Acceptor or third party wallet).
    /// </summary>
    [IsoId("_hE6oN2l2EfCyxsm1jzUNug")]
    [DisplayName("Storage Location")]
    [IsoXmlTag("StorgLctn")]
    public IsoMax35Text? StorageLocation { get; init; }

    /// <summary>
    /// Indicates the relationship between payment credential and merchant.
    /// </summary>
    [IsoId("_hE6oOWl2EfCyxsm1jzUNug")]
    [DisplayName("Payment Credential Merchant Relationship")]
    [IsoXmlTag("PmtCrdntlMrchntRltsh")]
    public IsoTrueFalseIndicator? PaymentCredentialMerchantRelationship { get; init; }

    /// <summary>
    /// PIN pad is inoperable.
    /// </summary>
    [IsoId("_hE6oO2l2EfCyxsm1jzUNug")]
    [DisplayName("PIN Pad Inoperable")]
    [IsoXmlTag("PINPadInprbl")]
    public IsoTrueFalseIndicator? PINPadInoperable { get; init; }

    /// <summary>
    /// Indicate the PIN entry bypass.
    /// </summary>
    [IsoId("_hE6oPWl2EfCyxsm1jzUNug")]
    [DisplayName("PIN Entry Bypass")]
    [IsoXmlTag("PINNtryBpss")]
    public IsoTrueFalseIndicator? PINEntryBypass { get; init; }

    /// <summary>
    /// Indicates a chip data fallback.
    /// </summary>
    [IsoId("_hE6oP2l2EfCyxsm1jzUNug")]
    [DisplayName("ICC Fallback")]
    [IsoXmlTag("ICCFllbck")]
    public IsoTrueFalseIndicator? ICCFallback { get; init; }

    /// <summary>
    /// A code that provides the reason of ICC fallback.
    /// </summary>
    [IsoId("_hE6oQWl2EfCyxsm1jzUNug")]
    [DisplayName("ICC Fallback Reason Code")]
    [IsoXmlTag("ICCFllbckRsnCd")]
    public ICCFallbackReason2Code? ICCFallbackReasonCode { get; init; }

    /// <summary>
    /// Indicates a magnetic stripe fallback.
    /// </summary>
    [IsoId("_hE6oRWl2EfCyxsm1jzUNug")]
    [DisplayName("Magnetic Stripe Fallback")]
    [IsoXmlTag("MgntcStrpFllbck")]
    public IsoTrueFalseIndicator? MagneticStripeFallback { get; init; }

    /// <summary>
    /// Indicates that the consumer authentication process is temporarily unavailable in the acceptance, acquirer or agent environment for this request.
    /// </summary>
    [IsoId("_hE6oR2l2EfCyxsm1jzUNug")]
    [DisplayName("Authentication Outage")]
    [IsoXmlTag("AuthntcnOutg")]
    public IsoTrueFalseIndicator? AuthenticationOutage { get; init; }

    /// <summary>
    /// Date the transaction was completed and captured.
    /// </summary>
    [IsoId("_hE6oW2l2EfCyxsm1jzUNug")]
    [DisplayName("Capture Date")]
    [IsoXmlTag("CaptrDt")]
    public IsoISODate? CaptureDate { get; init; }

    /// <summary>
    /// The date on which the sale or purchase is expected to occur.
    /// </summary>
    [IsoId("_hE6oY2l2EfCyxsm1jzUNug")]
    [DisplayName("Date Anticipated")]
    [IsoXmlTag("DtAntcptd")]
    public IsoISODate? DateAnticipated { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_lTfhUnbeEfCmC4yYaU27Kg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_lTfhU3beEfCmC4yYaU27Kg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
