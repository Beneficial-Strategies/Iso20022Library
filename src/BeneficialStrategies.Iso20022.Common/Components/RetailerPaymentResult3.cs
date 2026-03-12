// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Data Results.
/// </summary>
[IsoId("_C30GgS80Eeu125Ip9zFcsQ")]
[DisplayName("Retailer Payment Result")]
public partial record RetailerPaymentResult3
{
    #nullable enable
    
    /// <summary>
    /// Type of payment transaction.
    /// </summary>
    [IsoId("_DFCDIS80Eeu125Ip9zFcsQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType12Code TransactionType { get; init; } 
    
    /// <summary>
    /// Service provided by the card payment transaction, in addition to the main service.
    /// </summary>
    [IsoId("_DFCDIy80Eeu125Ip9zFcsQ")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public CardPaymentServiceType9Code? AdditionalService { get; init; } 
    
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_DFCDJS80Eeu125Ip9zFcsQ")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    
    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    [IsoId("_DFCDJy80Eeu125Ip9zFcsQ")]
    [DisplayName("Requested Transaction")]
    [IsoXmlTag("ReqdTx")]
    public CardPaymentTransaction110? RequestedTransaction { get; init; } 
    
    /// <summary>
    /// Result of the transaction processing.
    /// </summary>
    [IsoId("_DFCDKS80Eeu125Ip9zFcsQ")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public CardPaymentTransaction109? TransactionResponse { get; init; } 
    
    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_DFCDKy80Eeu125Ip9zFcsQ")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; } 
    
    /// <summary>
    /// Numeric value of a handwritten signature.
    /// </summary>
    [IsoId("_DFCDLS80Eeu125Ip9zFcsQ")]
    [DisplayName("Image Captured Signature")]
    [IsoXmlTag("ImgCaptrdSgntr")]
    public CapturedSignature1? ImageCapturedSignature { get; init; } 
    
    /// <summary>
    /// Protected value of a handwritten signature.
    /// </summary>
    [IsoId("_DFCDLy80Eeu125Ip9zFcsQ")]
    [DisplayName("Protected Captured Signature")]
    [IsoXmlTag("PrtctdCaptrdSgntr")]
    public ContentInformationType28? ProtectedCapturedSignature { get; init; } 
    
    /// <summary>
    /// Indicate that the Merchant forced the result of the payment to successful.
    /// </summary>
    [IsoId("_DFCDMS80Eeu125Ip9zFcsQ")]
    [DisplayName("Merchant Override Flag")]
    [IsoXmlTag("MrchntOvrrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MerchantOverrideFlag { get; init; } 
    
    /// <summary>
    /// Language used to display messages to the customer.
    /// </summary>
    [IsoId("_DFCDMy80Eeu125Ip9zFcsQ")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; } 
    
    /// <summary>
    /// Indicate that the payment transaction processing has required the approval of an acquirer.
    /// </summary>
    [IsoId("_DFCDNS80Eeu125Ip9zFcsQ")]
    [DisplayName("Online Flag")]
    [IsoXmlTag("OnlnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OnlineFlag { get; init; } 
    
    
    #nullable disable
    
}
