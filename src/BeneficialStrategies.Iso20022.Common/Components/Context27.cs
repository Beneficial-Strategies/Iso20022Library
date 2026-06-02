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
[IsoId("_qUbLQSnUEfCD0_iZ8tw-zA")]
[DisplayName("Context27")]
public record Context27
{
    /// <summary>
    /// Entry mode of the card data for the transaction.
    /// </summary>
    [IsoId("_qXJIESnUEfCD0_iZ8tw-zA")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading11Code? CardDataEntryMode { get; init; }

    /// <summary>
    /// Method used to present a QR Code at the point of service.
    /// </summary>
    [IsoId("_qXJIJynUEfCD0_iZ8tw-zA")]
    [DisplayName("QR Code Presentment Mode")]
    [IsoXmlTag("QRCdPresntmntMd")]
    public QRCodePresentmentMode2Code? QRCodePresentmentMode { get; init; }

    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    [IsoId("_qXJIKynUEfCD0_iZ8tw-zA")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public ISO18245MerchantCategoryCode? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Further details about the merchant that is used with the merchant category code for the particular purchase.
    /// </summary>
    [IsoId("_qXJIOSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    public IsoMax35Text? MerchantCategorySpecificData { get; init; }

    /// <summary>
    /// Other merchant category assigned by local or national scheme.
    /// </summary>
    [IsoId("_qXJIOynUEfCD0_iZ8tw-zA")]
    [DisplayName("Other Merchant Category")]
    [IsoXmlTag("OthrMrchntCtgy")]
    public IsoMax35Text? OtherMerchantCategory { get; init; }

    /// <summary>
    /// A code identifying transaction conditions at the point-of-sale or point of service.
    /// </summary>
    [IsoId("_q_MKESnVEfCD0_iZ8tw-zA")]
    [DisplayName("POS Condition Code")]
    [IsoXmlTag("POSCondCd")]
    public ISO8583POSConditionCode? POSConditionCode { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_qXJIPSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    public IsoTrueFalseIndicator? CardPresent { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_qXJISynUEfCD0_iZ8tw-zA")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; }

    /// <summary>
    /// Indicates whether the automated device was operated solely by the cardholder or not.
    /// </summary>
    [IsoId("_qXJIWSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Cardholder Activated")]
    [IsoXmlTag("CrdhldrActvtd")]
    public IsoTrueFalseIndicator? CardholderActivated { get; init; }

    /// <summary>
    /// Transaction initiated through a transponder or not.
    /// </summary>
    [IsoId("_qXJIYSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Transponder Initiated")]
    [IsoXmlTag("TrnspndrInittd")]
    public IsoTrueFalseIndicator? TransponderInitiated { get; init; }

    /// <summary>
    /// Indicates a transit transaction.
    /// </summary>
    [IsoId("_qXJIYynUEfCD0_iZ8tw-zA")]
    [DisplayName("Transit")]
    [IsoXmlTag("Trnst")]
    public IsoTrueFalseIndicator? Transit { get; init; }

    /// <summary>
    /// Card acceptor representative in attendance at the point of service during the transaction.
    /// </summary>
    [IsoId("_qXJIZSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Attended")]
    [IsoXmlTag("Attndd")]
    public IsoTrueFalseIndicator? Attended { get; init; }

    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [IsoId("_qXJIeSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Indicates whether the point of service is an e-commerce one or not.
    /// </summary>
    [IsoId("_qXJIeynUEfCD0_iZ8tw-zA")]
    [DisplayName("E Commerce")]
    [IsoXmlTag("EComrc")]
    public IsoTrueFalseIndicator? ECommerce { get; init; }

    /// <summary>
    /// Contains the proposed level of security of e-commerce transaction.
    /// </summary>
    [IsoId("_qXJIfSnUEfCD0_iZ8tw-zA")]
    [DisplayName("E Commerce Indicator Proposed")]
    [IsoXmlTag("EComrcIndPropsd")]
    public IsoMax35Text? ECommerceIndicatorProposed { get; init; }

    /// <summary>
    /// Contains the applied level of security of e-commerce transaction.
    /// </summary>
    [IsoId("_qXJIhSnUEfCD0_iZ8tw-zA")]
    [DisplayName("E Commerce Indicator Applied")]
    [IsoXmlTag("EComrcIndApld")]
    public IsoMax35Text? ECommerceIndicatorApplied { get; init; }

    /// <summary>
    /// Contains electronic commerce data.
    /// </summary>
    [IsoId("_qXJIjSnUEfCD0_iZ8tw-zA")]
    [DisplayName("E Commerce Data")]
    [IsoXmlTag("EComrcData")]
    public LaxProcessing? ECommerceData { get; init; }

    /// <summary>
    /// A code that identifies the type of MOTO transaction.
    /// </summary>
    [IsoId("_qXJIjynUEfCD0_iZ8tw-zA")]
    [DisplayName("MOTO Code")]
    [IsoXmlTag("MOTOCd")]
    public MOTO2Code? MOTOCode { get; init; }

    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_qXJIkSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; }

    /// <summary>
    /// Indicates whether the authorisation was delayed due to an on-board initiated transaction.
    /// </summary>
    [IsoId("_qXJIkynUEfCD0_iZ8tw-zA")]
    [DisplayName("Delayed Authorisation")]
    [IsoXmlTag("DelydAuthstn")]
    public IsoTrueFalseIndicator? DelayedAuthorisation { get; init; }

    /// <summary>
    /// Indicates a delayed charge.
    /// </summary>
    [IsoId("_qXJIlSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Delayed Charges")]
    [IsoXmlTag("DelydChrgs")]
    public IsoTrueFalseIndicator? DelayedCharges { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee.
    /// </summary>
    [IsoId("_qXJIlynUEfCD0_iZ8tw-zA")]
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; }

    /// <summary>
    /// Indicates a reauthorisation.
    /// </summary>
    [IsoId("_qXJImSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Reauthorisation")]
    [IsoXmlTag("Reauthstn")]
    public IsoTrueFalseIndicator? Reauthorisation { get; init; }

    /// <summary>
    /// Indicates a resubmission.
    /// </summary>
    [IsoId("_qXJImynUEfCD0_iZ8tw-zA")]
    [DisplayName("Re Submission")]
    [IsoXmlTag("ReSubmissn")]
    public IsoTrueFalseIndicator? ReSubmission { get; init; }

    /// <summary>
    /// Indicates the partial shipment.
    /// </summary>
    [IsoId("_qXJInSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Partial Shipment")]
    [IsoXmlTag("PrtlShipmnt")]
    public IsoTrueFalseIndicator? PartialShipment { get; init; }

    /// <summary>
    /// Indicates whether the point of service supports partial approval or not.
    /// </summary>
    [IsoId("_qXJInynUEfCD0_iZ8tw-zA")]
    [DisplayName("Partial Approval Supported")]
    [IsoXmlTag("PrtlApprvlSpprtd")]
    public IsoTrueFalseIndicator? PartialApprovalSupported { get; init; }

    /// <summary>
    /// Indicate the merchant's preference of the party to create VAT documentation.
    /// </summary>
    [IsoId("_QTF64SnVEfCD0_iZ8tw-zA")]
    [DisplayName("VAT Documentation Request")]
    [IsoXmlTag("VATDcmnttnReq")]
    public IsoMax10Text? VATDocumentationRequest { get; init; }

    /// <summary>
    /// Indicate the issuer's decision of the party to create VAT documentation.
    /// </summary>
    [IsoId("_3NWlgSnUEfCD0_iZ8tw-zA")]
    [DisplayName("VAT Documentation Response")]
    [IsoXmlTag("VATDcmnttnRspn")]
    public IsoMax10Text? VATDocumentationResponse { get; init; }

    /// <summary>
    /// The date on which the sale or purchase is expected to occur.
    /// </summary>
    [IsoId("_5YluBCnUEfCD0_iZ8tw-zA")]
    [DisplayName("Date Anticipated")]
    [IsoXmlTag("DtAntcptd")]
    public IsoISODate? DateAnticipated { get; init; }

    /// <summary>
    /// Contains network or scheme calculated maximum processing date when the clearing will occur.
    /// </summary>
    [IsoId("_18yVgSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Maximum Processing Date")]
    [IsoXmlTag("MaxPrcgDt")]
    public IsoJulianDate? MaximumProcessingDate { get; init; }

    /// <summary>
    /// Security characteristics of the communication link in the card acceptance process.
    /// </summary>
    [IsoId("_qXJIoSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Security Characteristics")]
    [IsoXmlTag("SctyChrtcs")]
    public SimpleValueList<SecurityCharacteristics2Code> SecurityCharacteristics { get; init; } = [];

    /// <summary>
    /// Terminal has reused temporary secure stored card data.
    /// </summary>
    [IsoId("_qXJIqynUEfCD0_iZ8tw-zA")]
    [DisplayName("Temporary Secure Card Data Reused")]
    [IsoXmlTag("TempScrCardDataReusd")]
    public IsoTrueFalseIndicator? TemporarySecureCardDataReused { get; init; }

    /// <summary>
    /// Storage location of payment credential (for example, Acceptor or third party wallet).
    /// </summary>
    [IsoId("_qXJIrSnUEfCD0_iZ8tw-zA")]
    [DisplayName("Storage Location")]
    [IsoXmlTag("StorgLctn")]
    public IsoMax35Text? StorageLocation { get; init; }

    /// <summary>
    /// Indicates the relationship between payment credential and merchant.
    /// </summary>
    [IsoId("_qXJIrynUEfCD0_iZ8tw-zA")]
    [DisplayName("Payment Credential Merchant Relationship")]
    [IsoXmlTag("PmtCrdntlMrchntRltsh")]
    public IsoTrueFalseIndicator? PaymentCredentialMerchantRelationship { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_hPunkq8eEfCnL-2fAG0ssA")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_hPunk68eEfCnL-2fAG0ssA")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
