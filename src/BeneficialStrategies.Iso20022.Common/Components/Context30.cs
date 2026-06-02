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
[IsoId("_JqNGkXbdEfCmC4yYaU27Kg")]
[DisplayName("Context30")]
public record Context30
{
    /// <summary>
    /// Entry mode of the card data for the transaction.
    /// </summary>
    [IsoId("_Jsx5cXbdEfCmC4yYaU27Kg")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading11Code? CardDataEntryMode { get; init; }

    /// <summary>
    /// Method used to present a QR Code at the point of service.
    /// </summary>
    [IsoId("_Jsx5h3bdEfCmC4yYaU27Kg")]
    [DisplayName("QR Code Presentment Mode")]
    [IsoXmlTag("QRCdPresntmntMd")]
    public QRCodePresentmentMode2Code? QRCodePresentmentMode { get; init; }

    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    [IsoId("_Jsx5i3bdEfCmC4yYaU27Kg")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public ISO18245MerchantCategoryCode? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Further details about the merchant that is used with the merchant category code for the particular purchase.
    /// </summary>
    [IsoId("_Jsx5mXbdEfCmC4yYaU27Kg")]
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    public IsoMax35Text? MerchantCategorySpecificData { get; init; }

    /// <summary>
    /// Other merchant category assigned by local or national scheme.
    /// </summary>
    [IsoId("_Jsx5m3bdEfCmC4yYaU27Kg")]
    [DisplayName("Other Merchant Category")]
    [IsoXmlTag("OthrMrchntCtgy")]
    public IsoMax35Text? OtherMerchantCategory { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_Jsx5nXbdEfCmC4yYaU27Kg")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    public IsoTrueFalseIndicator? CardPresent { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_Jsx5q3bdEfCmC4yYaU27Kg")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; }

    /// <summary>
    /// Indicates whether the automated device was operated solely by the cardholder or not.
    /// </summary>
    [IsoId("_Jsx5uXbdEfCmC4yYaU27Kg")]
    [DisplayName("Cardholder Activated")]
    [IsoXmlTag("CrdhldrActvtd")]
    public IsoTrueFalseIndicator? CardholderActivated { get; init; }

    /// <summary>
    /// Transaction initiated through a transponder or not.
    /// </summary>
    [IsoId("_Jsx5wXbdEfCmC4yYaU27Kg")]
    [DisplayName("Transponder Initiated")]
    [IsoXmlTag("TrnspndrInittd")]
    public IsoTrueFalseIndicator? TransponderInitiated { get; init; }

    /// <summary>
    /// Indicates a transit transaction.
    /// </summary>
    [IsoId("_Jsx5w3bdEfCmC4yYaU27Kg")]
    [DisplayName("Transit")]
    [IsoXmlTag("Trnst")]
    public IsoTrueFalseIndicator? Transit { get; init; }

    /// <summary>
    /// Card acceptor representative in attendance at the point of service during the transaction.
    /// </summary>
    [IsoId("_Jsx5xXbdEfCmC4yYaU27Kg")]
    [DisplayName("Attended")]
    [IsoXmlTag("Attndd")]
    public IsoTrueFalseIndicator? Attended { get; init; }

    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [IsoId("_Jsx52XbdEfCmC4yYaU27Kg")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Indicates whether the point of service is an e-commerce one or not.
    /// </summary>
    [IsoId("_Jsx523bdEfCmC4yYaU27Kg")]
    [DisplayName("E Commerce")]
    [IsoXmlTag("EComrc")]
    public IsoTrueFalseIndicator? ECommerce { get; init; }

    /// <summary>
    /// Contains the proposed level of security of e-commerce transaction.
    /// </summary>
    [IsoId("_Jsx53XbdEfCmC4yYaU27Kg")]
    [DisplayName("E Commerce Indicator Proposed")]
    [IsoXmlTag("EComrcIndPropsd")]
    public IsoMax35Text? ECommerceIndicatorProposed { get; init; }

    /// <summary>
    /// Contains the applied level of security of e-commerce transaction.
    /// </summary>
    [IsoId("_Jsx55XbdEfCmC4yYaU27Kg")]
    [DisplayName("E Commerce Indicator Applied")]
    [IsoXmlTag("EComrcIndApld")]
    public IsoMax35Text? ECommerceIndicatorApplied { get; init; }

    /// <summary>
    /// Contains electronic commerce data.
    /// </summary>
    [IsoId("_Jsx57XbdEfCmC4yYaU27Kg")]
    [DisplayName("E Commerce Data")]
    [IsoXmlTag("EComrcData")]
    public ValueList<ECommerceData1> ECommerceData { get; init; } = [];

    /// <summary>
    /// A code that identifies the type of MOTO transaction.
    /// </summary>
    [IsoId("_Jsx573bdEfCmC4yYaU27Kg")]
    [DisplayName("MOTO Code")]
    [IsoXmlTag("MOTOCd")]
    public MOTO2Code? MOTOCode { get; init; }

    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_Jsx58XbdEfCmC4yYaU27Kg")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; }

    /// <summary>
    /// Indicates a delayed charge.
    /// </summary>
    [IsoId("_Jsx583bdEfCmC4yYaU27Kg")]
    [DisplayName("Delayed Charges")]
    [IsoXmlTag("DelydChrgs")]
    public IsoTrueFalseIndicator? DelayedCharges { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee.
    /// </summary>
    [IsoId("_Jsx59XbdEfCmC4yYaU27Kg")]
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; }

    /// <summary>
    /// Indicates a reauthorisation.
    /// </summary>
    [IsoId("_Jsx593bdEfCmC4yYaU27Kg")]
    [DisplayName("Reauthorisation")]
    [IsoXmlTag("Reauthstn")]
    public IsoTrueFalseIndicator? Reauthorisation { get; init; }

    /// <summary>
    /// Indicates a resubmission.
    /// </summary>
    [IsoId("_Jsx5-XbdEfCmC4yYaU27Kg")]
    [DisplayName("Re Submission")]
    [IsoXmlTag("ReSubmissn")]
    public IsoTrueFalseIndicator? ReSubmission { get; init; }

    /// <summary>
    /// Indicates whether the authorisation was delayed due to an on-board initiated transaction.
    /// </summary>
    [IsoId("_Jsx5-3bdEfCmC4yYaU27Kg")]
    [DisplayName("Delayed Authorisation")]
    [IsoXmlTag("DelydAuthstn")]
    public IsoTrueFalseIndicator? DelayedAuthorisation { get; init; }

    /// <summary>
    /// Indicates a late presentment as defined by each specific implementation.
    /// </summary>
    [IsoId("_Jsx5_XbdEfCmC4yYaU27Kg")]
    [DisplayName("Late Presentment")]
    [IsoXmlTag("LatePresntmnt")]
    public IsoTrueFalseIndicator? LatePresentment { get; init; }

    /// <summary>
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// </summary>
    [IsoId("_Jsx5_3bdEfCmC4yYaU27Kg")]
    [DisplayName("Deferred Delivery")]
    [IsoXmlTag("DfrrdDlvry")]
    public IsoTrueFalseIndicator? DeferredDelivery { get; init; }

    /// <summary>
    /// Indicates the partial shipment.
    /// </summary>
    [IsoId("_Jsx6AXbdEfCmC4yYaU27Kg")]
    [DisplayName("Partial Shipment")]
    [IsoXmlTag("PrtlShipmnt")]
    public IsoTrueFalseIndicator? PartialShipment { get; init; }

    /// <summary>
    /// Indicates whether the payment transaction is a partial payment of the sale transaction.
    /// </summary>
    [IsoId("_Jsx6A3bdEfCmC4yYaU27Kg")]
    [DisplayName("Split Payment")]
    [IsoXmlTag("SpltPmt")]
    public IsoTrueFalseIndicator? SplitPayment { get; init; }

    /// <summary>
    /// Indicates whether the point of service supports partial approval or not.
    /// </summary>
    [IsoId("_Jsx6BXbdEfCmC4yYaU27Kg")]
    [DisplayName("Partial Approval Supported")]
    [IsoXmlTag("PrtlApprvlSpprtd")]
    public IsoTrueFalseIndicator? PartialApprovalSupported { get; init; }

    /// <summary>
    /// Security characteristics of the communication link in the card acceptance process.
    /// </summary>
    [IsoId("_Jsx6B3bdEfCmC4yYaU27Kg")]
    [DisplayName("Security Characteristics")]
    [IsoXmlTag("SctyChrtcs")]
    public SimpleValueList<SecurityCharacteristics2Code> SecurityCharacteristics { get; init; } = [];

    /// <summary>
    /// Storage location of payment credential (for example, Acceptor or third party wallet).
    /// </summary>
    [IsoId("_Jsx6EXbdEfCmC4yYaU27Kg")]
    [DisplayName("Storage Location")]
    [IsoXmlTag("StorgLctn")]
    public IsoMax35Text? StorageLocation { get; init; }

    /// <summary>
    /// Indicates that the consumer authentication process is temporarily unavailable in the acceptance, acquirer or agent environment for this request.
    /// </summary>
    [IsoId("_Jsx6E3bdEfCmC4yYaU27Kg")]
    [DisplayName("Authentication Outage")]
    [IsoXmlTag("AuthntcnOutg")]
    public IsoTrueFalseIndicator? AuthenticationOutage { get; init; }

    /// <summary>
    /// Indicates the relationship between payment credential and merchant.
    /// </summary>
    [IsoId("_Jsx6J3bdEfCmC4yYaU27Kg")]
    [DisplayName("Payment Credential Merchant Relationship")]
    [IsoXmlTag("PmtCrdntlMrchntRltsh")]
    public IsoTrueFalseIndicator? PaymentCredentialMerchantRelationship { get; init; }

    /// <summary>
    /// Date the transaction was completed and captured.
    /// </summary>
    [IsoId("_Jsx6KXbdEfCmC4yYaU27Kg")]
    [DisplayName("Capture Date")]
    [IsoXmlTag("CaptrDt")]
    public IsoISODate? CaptureDate { get; init; }

    /// <summary>
    /// The date on which the sale or purchase is expected to occur.
    /// </summary>
    [IsoId("_Jsx6K3bdEfCmC4yYaU27Kg")]
    [DisplayName("Date Anticipated")]
    [IsoXmlTag("DtAntcptd")]
    public IsoISODate? DateAnticipated { get; init; }

    /// <summary>
    /// Identify a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_Jsx6M3bdEfCmC4yYaU27Kg")]
    [DisplayName("Sale Reference Number")]
    [IsoXmlTag("SaleRefNb")]
    public IsoMax35Text? SaleReferenceNumber { get; init; }

    /// <summary>
    /// Type of goods and/or services.
    /// </summary>
    [IsoId("_Jsx6NXbdEfCmC4yYaU27Kg")]
    [DisplayName("Goods And Services Type")]
    [IsoXmlTag("GoodsAndSvcsTp")]
    public GoodsAndServices1Code? GoodsAndServicesType { get; init; }

    /// <summary>
    /// Sub type of goods and/or services.
    /// </summary>
    [IsoId("_Jsx6N3bdEfCmC4yYaU27Kg")]
    [DisplayName("Goods And Services Sub Type")]
    [IsoXmlTag("GoodsAndSvcsSubTp")]
    public GoodsAndServicesSubType2Code? GoodsAndServicesSubType { get; init; }

    /// <summary>
    /// Code that specifies the good or service delivery channel.
    /// </summary>
    [IsoId("_Jsx6O3bdEfCmC4yYaU27Kg")]
    [DisplayName("Good And Service Delivery Channel")]
    [IsoXmlTag("GoodAndSvcDlvryChanl")]
    public GoodAndServiceDeliveryChannel2Code? GoodAndServiceDeliveryChannel { get; init; }

    /// <summary>
    /// Code that specifies the good or service delivery schedule.
    /// </summary>
    [IsoId("_Jsx6P3bdEfCmC4yYaU27Kg")]
    [DisplayName("Good And Service Delivery Schedule")]
    [IsoXmlTag("GoodAndSvcDlvrySchdl")]
    public GoodAndServiceDeliverySchedule2Code? GoodAndServiceDeliverySchedule { get; init; }

    /// <summary>
    /// Indicates whether a receipt from the goods or services provider was requested.
    /// </summary>
    [IsoId("_Jsx6Q3bdEfCmC4yYaU27Kg")]
    [DisplayName("Receipt Request")]
    [IsoXmlTag("RctReq")]
    public IsoTrueFalseIndicator? ReceiptRequest { get; init; }

    /// <summary>
    /// Type of receipt requested or communication channel used.
    /// </summary>
    [IsoId("_Jsx6RXbdEfCmC4yYaU27Kg")]
    [DisplayName("Receipt Type")]
    [IsoXmlTag("RctTp")]
    public SimpleValueList<ReceiptType1Code> ReceiptType { get; init; } = [];

    /// <summary>
    /// Destination of the receipt (for example, e-mail address, SMS number, etc.).
    /// </summary>
    [IsoId("_Jsx6R3bdEfCmC4yYaU27Kg")]
    [DisplayName("Receipt Destination")]
    [IsoXmlTag("RctDstn")]
    public IsoMax70Text? ReceiptDestination { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_n5beQnbdEfCmC4yYaU27Kg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_n5beQ3bdEfCmC4yYaU27Kg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
