// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the result of a processed payment transaction.
/// </summary>
[IsoId("_s7bNkbYMEfCUZfsQO4rYeA")]
[DisplayName("Retailer Payment Result8")]
public record RetailerPaymentResult8
{
    /// <summary>
    /// Set of payment instruments relevant to this transaction.
    /// </summary>
    [IsoId("_s8YP1bYMEfCUZfsQO4rYeA")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public SimpleValueList<PaymentInstrumentType2Code> PaymentInstrument { get; init; } = [];

    /// <summary>
    /// Further details related to the set of payment types.
    /// </summary>
    [IsoId("_s8YP17YMEfCUZfsQO4rYeA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Type of payment transaction.
    /// </summary>
    [IsoId("_s8YP2bYMEfCUZfsQO4rYeA")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType12Code TransactionType { get; init; }

    /// <summary>
    /// Service provided by the card payment transaction, in addition to the main service.
    /// </summary>
    [IsoId("_s8YP37YMEfCUZfsQO4rYeA")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_s8YP5bYMEfCUZfsQO4rYeA")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType15Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    [IsoId("_s8YP67YMEfCUZfsQO4rYeA")]
    [DisplayName("Requested Transaction")]
    [IsoXmlTag("ReqdTx")]
    public PaymentTransaction183? RequestedTransaction { get; init; }

    /// <summary>
    /// Result of the transaction processing.
    /// </summary>
    [IsoId("_s8YP8bYMEfCUZfsQO4rYeA")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public CardPaymentTransaction152? TransactionResponse { get; init; }

    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_s8YP97YMEfCUZfsQO4rYeA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public ValueList<CustomerOrder1> CustomerOrder { get; init; } = [];

    /// <summary>
    /// Numeric value of a handwritten signature.
    /// </summary>
    [IsoId("_s8YP_bYMEfCUZfsQO4rYeA")]
    [DisplayName("Image Captured Signature")]
    [IsoXmlTag("ImgCaptrdSgntr")]
    public CapturedSignature1? ImageCapturedSignature { get; init; }

    /// <summary>
    /// Protected value of a handwritten signature.
    /// </summary>
    [IsoId("_s8YQA7YMEfCUZfsQO4rYeA")]
    [DisplayName("Protected Captured Signature")]
    [IsoXmlTag("PrtctdCaptrdSgntr")]
    public ContentInformationType40? ProtectedCapturedSignature { get; init; }

    /// <summary>
    /// Indicate that the Merchant forced the result of the payment to successful.
    /// </summary>
    [IsoId("_s8YQCbYMEfCUZfsQO4rYeA")]
    [DisplayName("Merchant Override Flag")]
    [IsoXmlTag("MrchntOvrrdFlg")]
    public IsoTrueFalseIndicator? MerchantOverrideFlag { get; init; }

    /// <summary>
    /// Language used to display messages to the customer.
    /// </summary>
    [IsoId("_s8YQD7YMEfCUZfsQO4rYeA")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; }

    /// <summary>
    /// Indicate that the payment transaction processing has required the approval of an acquirer.
    /// </summary>
    [IsoId("_s8YQFbYMEfCUZfsQO4rYeA")]
    [DisplayName("Online Flag")]
    [IsoXmlTag("OnlnFlg")]
    public IsoTrueFalseIndicator? OnlineFlag { get; init; }
}
