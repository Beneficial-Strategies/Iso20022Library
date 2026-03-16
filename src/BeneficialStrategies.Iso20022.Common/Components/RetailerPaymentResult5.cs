// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Data Results.
/// </summary>
[IsoId("_ty9jwXG8Ee2TbaNWBpRZpQ")]
[DisplayName("Retailer Payment Result")]
public record RetailerPaymentResult5
{
    /// <summary>
    /// Type of payment transaction.
    /// </summary>
    [IsoId("_t54rIXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType12Code TransactionType { get; init; }

    /// <summary>
    /// Service provided by the card payment transaction, in addition to the main service.
    /// </summary>
    [IsoId("_t54rI3G8Ee2TbaNWBpRZpQ")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_t54rJXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType14Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    [IsoId("_t54rJ3G8Ee2TbaNWBpRZpQ")]
    [DisplayName("Requested Transaction")]
    [IsoXmlTag("ReqdTx")]
    public CardPaymentTransaction127? RequestedTransaction { get; init; }

    /// <summary>
    /// Result of the transaction processing.
    /// </summary>
    [IsoId("_t54rKXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public CardPaymentTransaction128? TransactionResponse { get; init; }

    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_t54rK3G8Ee2TbaNWBpRZpQ")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public ValueList<CustomerOrder1> CustomerOrder { get; init; } = [];

    /// <summary>
    /// Numeric value of a handwritten signature.
    /// </summary>
    [IsoId("_t54rLXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Image Captured Signature")]
    [IsoXmlTag("ImgCaptrdSgntr")]
    public CapturedSignature1? ImageCapturedSignature { get; init; }

    /// <summary>
    /// Protected value of a handwritten signature.
    /// </summary>
    [IsoId("_t54rL3G8Ee2TbaNWBpRZpQ")]
    [DisplayName("Protected Captured Signature")]
    [IsoXmlTag("PrtctdCaptrdSgntr")]
    public ContentInformationType35? ProtectedCapturedSignature { get; init; }

    /// <summary>
    /// Indicate that the Merchant forced the result of the payment to successful.
    /// </summary>
    [IsoId("_t54rMXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Merchant Override Flag")]
    [IsoXmlTag("MrchntOvrrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MerchantOverrideFlag { get; init; }

    /// <summary>
    /// Language used to display messages to the customer.
    /// </summary>
    [IsoId("_t54rM3G8Ee2TbaNWBpRZpQ")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; }

    /// <summary>
    /// Indicate that the payment transaction processing has required the approval of an acquirer.
    /// </summary>
    [IsoId("_t54rNXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Online Flag")]
    [IsoXmlTag("OnlnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OnlineFlag { get; init; }
}
