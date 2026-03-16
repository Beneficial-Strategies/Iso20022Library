// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Retailer Payment Result7.
/// </summary>
[IsoId("_-odGIaEREe-MRKYsaX6JDg")]
[DisplayName("Retailer Payment Result7")]
public partial record RetailerPaymentResult7
{
    #nullable enable

    /// <summary>
    /// Additional Service.
    /// </summary>
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Customer Language.
    /// </summary>
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; } 

    /// <summary>
    /// Customer Order.
    /// </summary>
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public ValueList<CustomerOrder1> CustomerOrder { get; init; } = [];

    /// <summary>
    /// Image Captured Signature.
    /// </summary>
    [DisplayName("Image Captured Signature")]
    [IsoXmlTag("ImgCaptrdSgntr")]
    public CapturedSignature1? ImageCapturedSignature { get; init; } 

    /// <summary>
    /// Merchant Override Flag.
    /// </summary>
    [DisplayName("Merchant Override Flag")]
    [IsoXmlTag("MrchntOvrrdFlg")]
    public IsoTrueFalseIndicator? MerchantOverrideFlag { get; init; } 

    /// <summary>
    /// Online Flag.
    /// </summary>
    [DisplayName("Online Flag")]
    [IsoXmlTag("OnlnFlg")]
    public IsoTrueFalseIndicator? OnlineFlag { get; init; } 

    /// <summary>
    /// Payment Instrument.
    /// </summary>
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public ValueList<PaymentInstrumentType2Code> PaymentInstrument { get; init; } = [];

    /// <summary>
    /// Payment Type Information.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; } 

    /// <summary>
    /// Protected Captured Signature.
    /// </summary>
    [DisplayName("Protected Captured Signature")]
    [IsoXmlTag("PrtctdCaptrdSgntr")]
    public ContentInformationType40? ProtectedCapturedSignature { get; init; } 

    /// <summary>
    /// Requested Transaction.
    /// </summary>
    [DisplayName("Requested Transaction")]
    [IsoXmlTag("ReqdTx")]
    public PaymentTransaction165? RequestedTransaction { get; init; } 

    /// <summary>
    /// Service Attribute.
    /// </summary>
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType15Code? ServiceAttribute { get; init; } 

    /// <summary>
    /// Transaction Response.
    /// </summary>
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public CardPaymentTransaction144? TransactionResponse { get; init; } 

    /// <summary>
    /// Transaction Type.
    /// </summary>
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType12Code TransactionType { get; init; } 

    
    #nullable disable
    
}
