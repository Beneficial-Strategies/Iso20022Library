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
[IsoId("_xS2U8SduEfCJ9IDAfAjwLA")]
[DisplayName("Context26")]
public record Context26
{
    /// <summary>
    /// Entry mode of the card data for the transaction.
    /// </summary>
    [IsoId("_xVmG8SduEfCJ9IDAfAjwLA")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public required CardDataReading11Code CardDataEntryMode { get; init; }

    /// <summary>
    /// Method used to present a QR Code at the point of service.
    /// </summary>
    [IsoId("_xVmHByduEfCJ9IDAfAjwLA")]
    [DisplayName("QR Code Presentment Mode")]
    [IsoXmlTag("QRCdPresntmntMd")]
    public QRCodePresentmentMode2Code? QRCodePresentmentMode { get; init; }

    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    [IsoId("_xVmHCyduEfCJ9IDAfAjwLA")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public required ISO18245MerchantCategoryCode MerchantCategoryCode { get; init; }

    /// <summary>
    /// Further details about the merchant that is used with the merchant category code for the particular purchase.
    /// </summary>
    [IsoId("_xVmHGSduEfCJ9IDAfAjwLA")]
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    public IsoMax35Text? MerchantCategorySpecificData { get; init; }

    /// <summary>
    /// Other merchant category assigned by local or national scheme.
    /// </summary>
    [IsoId("_xVmHGyduEfCJ9IDAfAjwLA")]
    [DisplayName("Other Merchant Category")]
    [IsoXmlTag("OthrMrchntCtgy")]
    public IsoMax35Text? OtherMerchantCategory { get; init; }

    /// <summary>
    /// A code identifying transaction conditions at the point-of-sale or point of service.
    /// </summary>
    [IsoId("_kU5BACd_EfCJ9IDAfAjwLA")]
    [DisplayName("POS Condition Code")]
    [IsoXmlTag("POSCondCd")]
    public ISO8583POSConditionCode? POSConditionCode { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_xVmHHSduEfCJ9IDAfAjwLA")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    public IsoTrueFalseIndicator? CardPresent { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_xVmHKyduEfCJ9IDAfAjwLA")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; }

    /// <summary>
    /// Indicates whether the automated device was operated solely by the cardholder or not.
    /// </summary>
    [IsoId("_xVmHOSduEfCJ9IDAfAjwLA")]
    [DisplayName("Cardholder Activated")]
    [IsoXmlTag("CrdhldrActvtd")]
    public IsoTrueFalseIndicator? CardholderActivated { get; init; }

    /// <summary>
    /// Transaction initiated through a transponder or not.
    /// </summary>
    [IsoId("_xVmHQSduEfCJ9IDAfAjwLA")]
    [DisplayName("Transponder Initiated")]
    [IsoXmlTag("TrnspndrInittd")]
    public IsoTrueFalseIndicator? TransponderInitiated { get; init; }

    /// <summary>
    /// Indicates a transit transaction.
    /// </summary>
    [IsoId("_xVmHQyduEfCJ9IDAfAjwLA")]
    [DisplayName("Transit")]
    [IsoXmlTag("Trnst")]
    public IsoTrueFalseIndicator? Transit { get; init; }

    /// <summary>
    /// Indicates the transportation mode for a transit transaction.
    /// </summary>
    [IsoId("_wnOCMCnYEfCD0_iZ8tw-zA")]
    [DisplayName("Transportation Mode")]
    [IsoXmlTag("TrnsprtnMd")]
    public IsoMax2NumericText? TransportationMode { get; init; }

    /// <summary>
    /// Indicate the transaction includes EV charging.
    /// </summary>
    [IsoId("_o8RCgCeEEfCJ9IDAfAjwLA")]
    [DisplayName("EV Charging")]
    [IsoXmlTag("EVChrgg")]
    public IsoTrueFalseIndicator? EVCharging { get; init; }

    /// <summary>
    /// Card acceptor representative in attendance at the point of service during the transaction.
    /// </summary>
    [IsoId("_xVmHRSduEfCJ9IDAfAjwLA")]
    [DisplayName("Attended")]
    [IsoXmlTag("Attndd")]
    public IsoTrueFalseIndicator? Attended { get; init; }

    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [IsoId("_xVmHWSduEfCJ9IDAfAjwLA")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Indicates whether the point of service is an e-commerce one or not.
    /// </summary>
    [IsoId("_xVmHWyduEfCJ9IDAfAjwLA")]
    [DisplayName("E Commerce")]
    [IsoXmlTag("EComrc")]
    public IsoTrueFalseIndicator? ECommerce { get; init; }

    /// <summary>
    /// Contains the proposed level of security of e-commerce transaction.
    /// </summary>
    [IsoId("_xVmHXSduEfCJ9IDAfAjwLA")]
    [DisplayName("E Commerce Indicator Proposed")]
    [IsoXmlTag("EComrcIndPropsd")]
    public IsoMax35Text? ECommerceIndicatorProposed { get; init; }

    /// <summary>
    /// Contains the applied level of security of e-commerce transaction.
    /// </summary>
    [IsoId("_xVmHZSduEfCJ9IDAfAjwLA")]
    [DisplayName("E Commerce Indicator Applied")]
    [IsoXmlTag("EComrcIndApld")]
    public IsoMax35Text? ECommerceIndicatorApplied { get; init; }

    /// <summary>
    /// Contains electronic commerce data.
    /// </summary>
    [IsoId("_xVmHbSduEfCJ9IDAfAjwLA")]
    [DisplayName("E Commerce Data")]
    [IsoXmlTag("EComrcData")]
    public LaxProcessing? ECommerceData { get; init; }

    /// <summary>
    /// A code that identifies the type of MOTO transaction.
    /// </summary>
    [IsoId("_xVmHbyduEfCJ9IDAfAjwLA")]
    [DisplayName("MOTO Code")]
    [IsoXmlTag("MOTOCd")]
    public MOTO2Code? MOTOCode { get; init; }

    /// <summary>
    /// Identifies final authorisation messages for the purpose of managing open-to buy or available balance.
    /// </summary>
    [IsoId("_xVmHcSduEfCJ9IDAfAjwLA")]
    [DisplayName("Final Authorisation")]
    [IsoXmlTag("FnlAuthstn")]
    public IsoTrueFalseIndicator? FinalAuthorisation { get; init; }

    /// <summary>
    /// Notifies the express consent of the customer for a given service.
    /// </summary>
    [IsoId("_xVmHcyduEfCJ9IDAfAjwLA")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_xVmHdSduEfCJ9IDAfAjwLA")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; }

    /// <summary>
    /// Indicates a delayed charge.
    /// </summary>
    [IsoId("_xVmHdyduEfCJ9IDAfAjwLA")]
    [DisplayName("Delayed Charges")]
    [IsoXmlTag("DelydChrgs")]
    public IsoTrueFalseIndicator? DelayedCharges { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee.
    /// </summary>
    [IsoId("_xVmHeSduEfCJ9IDAfAjwLA")]
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; }

    /// <summary>
    /// Indicates a reauthorisation.
    /// </summary>
    [IsoId("_xVmHeyduEfCJ9IDAfAjwLA")]
    [DisplayName("Reauthorisation")]
    [IsoXmlTag("Reauthstn")]
    public IsoTrueFalseIndicator? Reauthorisation { get; init; }

    /// <summary>
    /// Indicates a resubmission.
    /// </summary>
    [IsoId("_xVmHfSduEfCJ9IDAfAjwLA")]
    [DisplayName("Re Submission")]
    [IsoXmlTag("ReSubmissn")]
    public IsoTrueFalseIndicator? ReSubmission { get; init; }

    /// <summary>
    /// Indicates whether the authorisation was delayed due to an on-board initiated transaction.
    /// </summary>
    [IsoId("_xVmHfyduEfCJ9IDAfAjwLA")]
    [DisplayName("Delayed Authorisation")]
    [IsoXmlTag("DelydAuthstn")]
    public IsoTrueFalseIndicator? DelayedAuthorisation { get; init; }

    /// <summary>
    /// Indicates a late presentment as defined by each specific implementation.
    /// </summary>
    [IsoId("_xVmHgSduEfCJ9IDAfAjwLA")]
    [DisplayName("Late Presentment")]
    [IsoXmlTag("LatePresntmnt")]
    public IsoTrueFalseIndicator? LatePresentment { get; init; }

    /// <summary>
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// </summary>
    [IsoId("_xVmHgyduEfCJ9IDAfAjwLA")]
    [DisplayName("Deferred Delivery")]
    [IsoXmlTag("DfrrdDlvry")]
    public IsoTrueFalseIndicator? DeferredDelivery { get; init; }

    /// <summary>
    /// Indicates the partial shipment.
    /// </summary>
    [IsoId("_xVmHhSduEfCJ9IDAfAjwLA")]
    [DisplayName("Partial Shipment")]
    [IsoXmlTag("PrtlShipmnt")]
    public IsoTrueFalseIndicator? PartialShipment { get; init; }

    /// <summary>
    /// Indicates whether the payment transaction is a partial payment of the sale transaction.
    /// </summary>
    [IsoId("_xVmHhyduEfCJ9IDAfAjwLA")]
    [DisplayName("Split Payment")]
    [IsoXmlTag("SpltPmt")]
    public IsoTrueFalseIndicator? SplitPayment { get; init; }

    /// <summary>
    /// Indicates whether the point of service supports partial approval or not.
    /// </summary>
    [IsoId("_xVmHiSduEfCJ9IDAfAjwLA")]
    [DisplayName("Partial Approval Supported")]
    [IsoXmlTag("PrtlApprvlSpprtd")]
    public IsoTrueFalseIndicator? PartialApprovalSupported { get; init; }

    /// <summary>
    /// Security characteristics of the communication link in the card acceptance process.
    /// </summary>
    [IsoId("_xVmHiyduEfCJ9IDAfAjwLA")]
    [DisplayName("Security Characteristics")]
    [IsoXmlTag("SctyChrtcs")]
    public SimpleValueList<SecurityCharacteristics2Code> SecurityCharacteristics { get; init; } = [];

    /// <summary>
    /// Terminal has reused temporary secure stored card data.
    /// </summary>
    [IsoId("_xVmHlSduEfCJ9IDAfAjwLA")]
    [DisplayName("Temporary Secure Card Data Reused")]
    [IsoXmlTag("TempScrCardDataReusd")]
    public IsoTrueFalseIndicator? TemporarySecureCardDataReused { get; init; }

    /// <summary>
    /// Storage location of payment credential (for example, Acceptor or third party wallet).
    /// </summary>
    [IsoId("_xVmHlyduEfCJ9IDAfAjwLA")]
    [DisplayName("Storage Location")]
    [IsoXmlTag("StorgLctn")]
    public IsoMax35Text? StorageLocation { get; init; }

    /// <summary>
    /// Indicates the relationship between payment credential and merchant.
    /// </summary>
    [IsoId("_xVmHmSduEfCJ9IDAfAjwLA")]
    [DisplayName("Payment Credential Merchant Relationship")]
    [IsoXmlTag("PmtCrdntlMrchntRltsh")]
    public IsoTrueFalseIndicator? PaymentCredentialMerchantRelationship { get; init; }

    /// <summary>
    /// PIN pad is inoperable.
    /// </summary>
    [IsoId("_Vklrwa9CEfCwC48u9hnlfA")]
    [DisplayName("PIN Pad Inoperable")]
    [IsoXmlTag("PINPadInprbl")]
    public IsoTrueFalseIndicator? PINPadInoperable { get; init; }

    /// <summary>
    /// Indicate the PIN entry bypass.
    /// </summary>
    [IsoId("_xVmHnSduEfCJ9IDAfAjwLA")]
    [DisplayName("PIN Entry Bypass")]
    [IsoXmlTag("PINNtryBpss")]
    public IsoTrueFalseIndicator? PINEntryBypass { get; init; }

    /// <summary>
    /// Indicates a chip data fallback.
    /// </summary>
    [IsoId("_xVmHnyduEfCJ9IDAfAjwLA")]
    [DisplayName("ICC Fallback")]
    [IsoXmlTag("ICCFllbck")]
    public IsoTrueFalseIndicator? ICCFallback { get; init; }

    /// <summary>
    /// A code that provides the reason of ICC fallback.
    /// </summary>
    [IsoId("_xVmHoSduEfCJ9IDAfAjwLA")]
    [DisplayName("ICC Fallback Reason Code")]
    [IsoXmlTag("ICCFllbckRsnCd")]
    public ICCFallbackReason2Code? ICCFallbackReasonCode { get; init; }

    /// <summary>
    /// Indicates a magnetic stripe fallback.
    /// </summary>
    [IsoId("_xVmHpSduEfCJ9IDAfAjwLA")]
    [DisplayName("Magnetic Stripe Fallback")]
    [IsoXmlTag("MgntcStrpFllbck")]
    public IsoTrueFalseIndicator? MagneticStripeFallback { get; init; }

    /// <summary>
    /// Indicates that the consumer authentication process is temporarily unavailable in the acceptance, acquirer or agent environment for this request.
    /// </summary>
    [IsoId("_xVmHpyduEfCJ9IDAfAjwLA")]
    [DisplayName("Authentication Outage")]
    [IsoXmlTag("AuthntcnOutg")]
    public IsoTrueFalseIndicator? AuthenticationOutage { get; init; }

    /// <summary>
    /// Indicate the transaction is completed through pay by link method.
    /// </summary>
    [IsoId("_HHqKcCeCEfCJ9IDAfAjwLA")]
    [DisplayName("Pay By Link")]
    [IsoXmlTag("PayByLk")]
    public IsoTrueFalseIndicator? PayByLink { get; init; }

    /// <summary>
    /// Indicate the acquirer and the issuer of the transaction are same entity.
    /// </summary>
    [IsoId("_0S4nYCeCEfCJ9IDAfAjwLA")]
    [DisplayName("On US")]
    [IsoXmlTag("OnUS")]
    public IsoTrueFalseIndicator? OnUS { get; init; }

    /// <summary>
    /// Indicate PAN data entered through auto fill.
    /// </summary>
    [IsoId("_9b2hkCeDEfCJ9IDAfAjwLA")]
    [DisplayName("Auto Fill")]
    [IsoXmlTag("AutoFill")]
    public IsoTrueFalseIndicator? AutoFill { get; init; }

    /// <summary>
    /// Indicate the merchant's preference of the party to create VAT documentation.
    /// </summary>
    [IsoId("_ALOnACeGEfCJ9IDAfAjwLA")]
    [DisplayName("VAT Documentation Request")]
    [IsoXmlTag("VATDcmnttnReq")]
    public IsoMax10Text? VATDocumentationRequest { get; init; }

    /// <summary>
    /// Indicate the issuer's decision of the party to create VAT documentation.
    /// </summary>
    [IsoId("_Chc3gSeGEfCJ9IDAfAjwLA")]
    [DisplayName("VAT Documentation Response")]
    [IsoXmlTag("VATDcmnttnRspn")]
    public IsoMax10Text? VATDocumentationResponse { get; init; }

    /// <summary>
    /// Indicates the merchant request to extend authorisation validity period.
    /// </summary>
    [IsoId("_MNhewCeHEfCJ9IDAfAjwLA")]
    [DisplayName("Extended Authorisation")]
    [IsoXmlTag("XtndedAuthstn")]
    public IsoTrueFalseIndicator? ExtendedAuthorisation { get; init; }

    /// <summary>
    /// Date the transaction was completed and captured.
    /// </summary>
    [IsoId("_xVmHuyduEfCJ9IDAfAjwLA")]
    [DisplayName("Capture Date")]
    [IsoXmlTag("CaptrDt")]
    public IsoISODate? CaptureDate { get; init; }

    /// <summary>
    /// The date on which the sale or purchase is expected to occur.
    /// </summary>
    [IsoId("_xVmHwyduEfCJ9IDAfAjwLA")]
    [DisplayName("Date Anticipated")]
    [IsoXmlTag("DtAntcptd")]
    public IsoISODate? DateAnticipated { get; init; }

    /// <summary>
    /// Contains network or scheme calculated maximum processing date when the clearing will occur.
    /// </summary>
    [IsoId("_8WF2YCnTEfCD0_iZ8tw-zA")]
    [DisplayName("Maximum Processing Date")]
    [IsoXmlTag("MaxPrcgDt")]
    public IsoJulianDate? MaximumProcessingDate { get; init; }

    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    [IsoId("_xVmHyyduEfCJ9IDAfAjwLA")]
    [DisplayName("ECR Identification")]
    [IsoXmlTag("ECRId")]
    public IsoMax35Text? ECRIdentification { get; init; }

    /// <summary>
    /// Identify a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_xVmHzSduEfCJ9IDAfAjwLA")]
    [DisplayName("Sale Reference Number")]
    [IsoXmlTag("SaleRefNb")]
    public IsoMax35Text? SaleReferenceNumber { get; init; }

    /// <summary>
    /// Type of goods and/or services.
    /// </summary>
    [IsoId("_xVmHzyduEfCJ9IDAfAjwLA")]
    [DisplayName("Goods And Services Type")]
    [IsoXmlTag("GoodsAndSvcsTp")]
    public GoodsAndServices1Code? GoodsAndServicesType { get; init; }

    /// <summary>
    /// Sub type of goods and/or services.
    /// </summary>
    [IsoId("_xVmH0SduEfCJ9IDAfAjwLA")]
    [DisplayName("Goods And Services Sub Type")]
    [IsoXmlTag("GoodsAndSvcsSubTp")]
    public GoodsAndServicesSubType2Code? GoodsAndServicesSubType { get; init; }

    /// <summary>
    /// Code that specifies the good or service delivery channel.
    /// </summary>
    [IsoId("_xVmH1SduEfCJ9IDAfAjwLA")]
    [DisplayName("Good And Service Delivery Channel")]
    [IsoXmlTag("GoodAndSvcDlvryChanl")]
    public GoodAndServiceDeliveryChannel2Code? GoodAndServiceDeliveryChannel { get; init; }

    /// <summary>
    /// Code that specifies the good or service delivery schedule.
    /// </summary>
    [IsoId("_xVmH2SduEfCJ9IDAfAjwLA")]
    [DisplayName("Good And Service Delivery Schedule")]
    [IsoXmlTag("GoodAndSvcDlvrySchdl")]
    public GoodAndServiceDeliverySchedule2Code? GoodAndServiceDeliverySchedule { get; init; }

    /// <summary>
    /// Indicates whether a receipt from the goods or services provider was requested.
    /// </summary>
    [IsoId("_xVmH3SduEfCJ9IDAfAjwLA")]
    [DisplayName("Receipt Request")]
    [IsoXmlTag("RctReq")]
    public IsoTrueFalseIndicator? ReceiptRequest { get; init; }

    /// <summary>
    /// Type of receipt requested or communication channel used.
    /// </summary>
    [IsoId("_xVmH3yduEfCJ9IDAfAjwLA")]
    [DisplayName("Receipt Type")]
    [IsoXmlTag("RctTp")]
    public SimpleValueList<ReceiptType1Code> ReceiptType { get; init; } = [];

    /// <summary>
    /// Destination of the receipt (for example, e-mail address, SMS number, etc.).
    /// </summary>
    [IsoId("_xVmH4SduEfCJ9IDAfAjwLA")]
    [DisplayName("Receipt Destination")]
    [IsoXmlTag("RctDstn")]
    public IsoMax70Text? ReceiptDestination { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_nfpKskVYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_nfpKs0VYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
