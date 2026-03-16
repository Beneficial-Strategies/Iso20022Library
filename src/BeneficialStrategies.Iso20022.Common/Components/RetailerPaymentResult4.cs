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
[IsoId("_eUX4wU0aEeybj420QgWBkA")]
[DisplayName("Retailer Payment Result")]
public record RetailerPaymentResult4
{
    /// <summary>
    /// Type of payment transaction.
    /// </summary>
    [IsoId("_eauYYU0aEeybj420QgWBkA")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType12Code TransactionType { get; init; }

    /// <summary>
    /// Service provided by the card payment transaction, in addition to the main service.
    /// </summary>
    [IsoId("_eauYY00aEeybj420QgWBkA")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public CardPaymentServiceType9Code? AdditionalService { get; init; }

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_eauYZU0aEeybj420QgWBkA")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType14Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    [IsoId("_eauYZ00aEeybj420QgWBkA")]
    [DisplayName("Requested Transaction")]
    [IsoXmlTag("ReqdTx")]
    public CardPaymentTransaction120? RequestedTransaction { get; init; }

    /// <summary>
    /// Result of the transaction processing.
    /// </summary>
    [IsoId("_eauYaU0aEeybj420QgWBkA")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public CardPaymentTransaction114? TransactionResponse { get; init; }

    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_eauYa00aEeybj420QgWBkA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }

    /// <summary>
    /// Numeric value of a handwritten signature.
    /// </summary>
    [IsoId("_eauYbU0aEeybj420QgWBkA")]
    [DisplayName("Image Captured Signature")]
    [IsoXmlTag("ImgCaptrdSgntr")]
    public CapturedSignature1? ImageCapturedSignature { get; init; }

    /// <summary>
    /// Protected value of a handwritten signature.
    /// </summary>
    [IsoId("_eauYb00aEeybj420QgWBkA")]
    [DisplayName("Protected Captured Signature")]
    [IsoXmlTag("PrtctdCaptrdSgntr")]
    public ContentInformationType32? ProtectedCapturedSignature { get; init; }

    /// <summary>
    /// Indicate that the Merchant forced the result of the payment to successful.
    /// </summary>
    [IsoId("_eauYcU0aEeybj420QgWBkA")]
    [DisplayName("Merchant Override Flag")]
    [IsoXmlTag("MrchntOvrrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MerchantOverrideFlag { get; init; }

    /// <summary>
    /// Language used to display messages to the customer.
    /// </summary>
    [IsoId("_eauYc00aEeybj420QgWBkA")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; }

    /// <summary>
    /// Indicate that the payment transaction processing has required the approval of an acquirer.
    /// </summary>
    [IsoId("_eauYdU0aEeybj420QgWBkA")]
    [DisplayName("Online Flag")]
    [IsoXmlTag("OnlnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OnlineFlag { get; init; }
}
