// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context24.
/// </summary>
[IsoId("_5tv0MYVwEe6odei_lsRKtw")]
[DisplayName("Context24")]
public partial record Context24
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Attended.
    /// </summary>
    [DisplayName("Attended")]
    [IsoXmlTag("Attndd")]
    public IsoTrueFalseIndicator? Attended { get; init; } 

    /// <summary>
    /// Authentication Outage.
    /// </summary>
    [DisplayName("Authentication Outage")]
    [IsoXmlTag("AuthntcnOutg")]
    public IsoTrueFalseIndicator? AuthenticationOutage { get; init; } 

    /// <summary>
    /// Capture Date.
    /// </summary>
    [DisplayName("Capture Date")]
    [IsoXmlTag("CaptrDt")]
    public IsoISODate? CaptureDate { get; init; } 

    /// <summary>
    /// Card Data Entry Mode.
    /// </summary>
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading10Code? CardDataEntryMode { get; init; } 

    /// <summary>
    /// Cardholder Activated.
    /// </summary>
    [DisplayName("Cardholder Activated")]
    [IsoXmlTag("CrdhldrActvtd")]
    public IsoTrueFalseIndicator? CardholderActivated { get; init; } 

    /// <summary>
    /// Cardholder Present.
    /// </summary>
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; } 

    /// <summary>
    /// Card Present.
    /// </summary>
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    public IsoTrueFalseIndicator? CardPresent { get; init; } 

    /// <summary>
    /// Date Anticipated.
    /// </summary>
    [DisplayName("Date Anticipated")]
    [IsoXmlTag("DtAntcptd")]
    public IsoISODate? DateAnticipated { get; init; } 

    /// <summary>
    /// Deferred Delivery.
    /// </summary>
    [DisplayName("Deferred Delivery")]
    [IsoXmlTag("DfrrdDlvry")]
    public IsoTrueFalseIndicator? DeferredDelivery { get; init; } 

    /// <summary>
    /// Delayed Authorisation.
    /// </summary>
    [DisplayName("Delayed Authorisation")]
    [IsoXmlTag("DelydAuthstn")]
    public IsoTrueFalseIndicator? DelayedAuthorisation { get; init; } 

    /// <summary>
    /// Delayed Charges.
    /// </summary>
    [DisplayName("Delayed Charges")]
    [IsoXmlTag("DelydChrgs")]
    public IsoTrueFalseIndicator? DelayedCharges { get; init; } 

    /// <summary>
    /// E Commerce.
    /// </summary>
    [DisplayName("E Commerce")]
    [IsoXmlTag("EComrc")]
    public IsoTrueFalseIndicator? ECommerce { get; init; } 

    /// <summary>
    /// E Commerce Data.
    /// </summary>
    [DisplayName("E Commerce Data")]
    [IsoXmlTag("EComrcData")]
    public ValueList<ECommerceData1> ECommerceData { get; init; } = [];

    /// <summary>
    /// E Commerce Indicator Applied.
    /// </summary>
    [DisplayName("E Commerce Indicator Applied")]
    [IsoXmlTag("EComrcIndApld")]
    public IsoMax35Text? ECommerceIndicatorApplied { get; init; } 

    /// <summary>
    /// E Commerce Indicator Proposed.
    /// </summary>
    [DisplayName("E Commerce Indicator Proposed")]
    [IsoXmlTag("EComrcIndPropsd")]
    public IsoMax35Text? ECommerceIndicatorProposed { get; init; } 

    /// <summary>
    /// Good And Service Delivery Channel.
    /// </summary>
    [DisplayName("Good And Service Delivery Channel")]
    [IsoXmlTag("GoodAndSvcDlvryChanl")]
    public GoodAndServiceDeliveryChannel1Code? GoodAndServiceDeliveryChannel { get; init; } 

    /// <summary>
    /// Good And Service Delivery Schedule.
    /// </summary>
    [DisplayName("Good And Service Delivery Schedule")]
    [IsoXmlTag("GoodAndSvcDlvrySchdl")]
    public GoodAndServiceDeliverySchedule1Code? GoodAndServiceDeliverySchedule { get; init; } 

    /// <summary>
    /// Good And Services Other Sub Type.
    /// </summary>
    [DisplayName("Good And Services Other Sub Type")]
    [IsoXmlTag("GoodAndSvcsOthrSubTp")]
    public IsoMax35Text? GoodAndServicesOtherSubType { get; init; } 

    /// <summary>
    /// Good And Services Sub Type.
    /// </summary>
    [DisplayName("Good And Services Sub Type")]
    [IsoXmlTag("GoodAndSvcsSubTp")]
    public GoodsAndServicesSubType1Code? GoodAndServicesSubType { get; init; } 

    /// <summary>
    /// Goods And Services Type.
    /// </summary>
    [DisplayName("Goods And Services Type")]
    [IsoXmlTag("GoodsAndSvcsTp")]
    public GoodsAndServices1Code? GoodsAndServicesType { get; init; } 

    /// <summary>
    /// Late Presentment.
    /// </summary>
    [DisplayName("Late Presentment")]
    [IsoXmlTag("LatePresntmnt")]
    public IsoTrueFalseIndicator? LatePresentment { get; init; } 

    /// <summary>
    /// Merchant Category Code.
    /// </summary>
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public ISO18245MerchantCategoryCode? MerchantCategoryCode { get; init; } 

    /// <summary>
    /// Merchant Category Specific Data.
    /// </summary>
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    public IsoMax35Text? MerchantCategorySpecificData { get; init; } 

    /// <summary>
    /// MOTO Code.
    /// </summary>
    [DisplayName("MOTO Code")]
    [IsoXmlTag("MOTOCd")]
    public MOTO2Code? MOTOCode { get; init; } 

    /// <summary>
    /// No Show.
    /// </summary>
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; } 

    /// <summary>
    /// Other Card Data Entry Mode.
    /// </summary>
    [DisplayName("Other Card Data Entry Mode")]
    [IsoXmlTag("OthrCardDataNtryMd")]
    public IsoMax35Text? OtherCardDataEntryMode { get; init; } 

    /// <summary>
    /// Other Good And Service Delivery Channel.
    /// </summary>
    [DisplayName("Other Good And Service Delivery Channel")]
    [IsoXmlTag("OthrGoodAndSvcDlvryChanl")]
    public IsoMax35Text? OtherGoodAndServiceDeliveryChannel { get; init; } 

    /// <summary>
    /// Other Good And Service Delivery Schedule.
    /// </summary>
    [DisplayName("Other Good And Service Delivery Schedule")]
    [IsoXmlTag("OthrGoodAndSvcDlvrySchdl")]
    public IsoMax35Text? OtherGoodAndServiceDeliverySchedule { get; init; } 

    /// <summary>
    /// Other Merchant Category.
    /// </summary>
    [DisplayName("Other Merchant Category")]
    [IsoXmlTag("OthrMrchntCtgy")]
    public IsoMax35Text? OtherMerchantCategory { get; init; } 

    /// <summary>
    /// Other QR Code Presentment Mode.
    /// </summary>
    [DisplayName("Other QR Code Presentment Mode")]
    [IsoXmlTag("OthrQRCdPresntmntMd")]
    public IsoMax35Text? OtherQRCodePresentmentMode { get; init; } 

    /// <summary>
    /// Other Security Characteristics.
    /// </summary>
    [DisplayName("Other Security Characteristics")]
    [IsoXmlTag("OthrSctyChrtcs")]
    public IsoMax35Text? OtherSecurityCharacteristics { get; init; } 

    /// <summary>
    /// Partial Approval Supported.
    /// </summary>
    [DisplayName("Partial Approval Supported")]
    [IsoXmlTag("PrtlApprvlSpprtd")]
    public IsoTrueFalseIndicator? PartialApprovalSupported { get; init; } 

    /// <summary>
    /// Partial Shipment.
    /// </summary>
    [DisplayName("Partial Shipment")]
    [IsoXmlTag("PrtlShipmnt")]
    public IsoTrueFalseIndicator? PartialShipment { get; init; } 

    /// <summary>
    /// Payment Credential Merchant Relationship.
    /// </summary>
    [DisplayName("Payment Credential Merchant Relationship")]
    [IsoXmlTag("PmtCrdntlMrchntRltsh")]
    public IsoTrueFalseIndicator? PaymentCredentialMerchantRelationship { get; init; } 

    /// <summary>
    /// QR Code Presentment Mode.
    /// </summary>
    [DisplayName("QR Code Presentment Mode")]
    [IsoXmlTag("QRCdPresntmntMd")]
    public QRCodePresentmentMode1Code? QRCodePresentmentMode { get; init; } 

    /// <summary>
    /// Reauthorisation.
    /// </summary>
    [DisplayName("Reauthorisation")]
    [IsoXmlTag("Reauthstn")]
    public IsoTrueFalseIndicator? Reauthorisation { get; init; } 

    /// <summary>
    /// Receipt Destination.
    /// </summary>
    [DisplayName("Receipt Destination")]
    [IsoXmlTag("RctDstn")]
    public IsoMax70Text? ReceiptDestination { get; init; } 

    /// <summary>
    /// Receipt Request.
    /// </summary>
    [DisplayName("Receipt Request")]
    [IsoXmlTag("RctReq")]
    public IsoTrueFalseIndicator? ReceiptRequest { get; init; } 

    /// <summary>
    /// Receipt Type.
    /// </summary>
    [DisplayName("Receipt Type")]
    [IsoXmlTag("RctTp")]
    public ValueList<ReceiptType1Code> ReceiptType { get; init; } = [];

    /// <summary>
    /// Re Submission.
    /// </summary>
    [DisplayName("Re Submission")]
    [IsoXmlTag("ReSubmissn")]
    public IsoTrueFalseIndicator? ReSubmission { get; init; } 

    /// <summary>
    /// Sale Reference Number.
    /// </summary>
    [DisplayName("Sale Reference Number")]
    [IsoXmlTag("SaleRefNb")]
    public IsoMax35Text? SaleReferenceNumber { get; init; } 

    /// <summary>
    /// Security Characteristics.
    /// </summary>
    [DisplayName("Security Characteristics")]
    [IsoXmlTag("SctyChrtcs")]
    public ValueList<SecurityCharacteristics1Code> SecurityCharacteristics { get; init; } = [];

    /// <summary>
    /// Split Payment.
    /// </summary>
    [DisplayName("Split Payment")]
    [IsoXmlTag("SpltPmt")]
    public IsoTrueFalseIndicator? SplitPayment { get; init; } 

    /// <summary>
    /// Storage Location.
    /// </summary>
    [DisplayName("Storage Location")]
    [IsoXmlTag("StorgLctn")]
    public IsoMax35Text? StorageLocation { get; init; } 

    /// <summary>
    /// Transaction Initiator.
    /// </summary>
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; } 

    /// <summary>
    /// Transit.
    /// </summary>
    [DisplayName("Transit")]
    [IsoXmlTag("Trnst")]
    public IsoTrueFalseIndicator? Transit { get; init; } 

    /// <summary>
    /// Transponder Initiated.
    /// </summary>
    [DisplayName("Transponder Initiated")]
    [IsoXmlTag("TrnspndrInittd")]
    public IsoTrueFalseIndicator? TransponderInitiated { get; init; } 

    /// <summary>
    /// Unattended Level Category.
    /// </summary>
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; } 

    
    #nullable disable
    
}
