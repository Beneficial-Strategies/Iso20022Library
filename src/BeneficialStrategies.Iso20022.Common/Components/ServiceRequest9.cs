// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the service to be called.
/// </summary>
[IsoId("_PMBmcbYBEfCUZfsQO4rYeA")]
[DisplayName("Service Request9")]
public record ServiceRequest9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_PM-otbYBEfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_PM-ou7YBEfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_PM-owbYBEfCUZfsQO4rYeA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService2Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the payment request.
    /// </summary>
    [IsoId("_PM-ox7YBEfCUZfsQO4rYeA")]
    [DisplayName("Payment Request")]
    [IsoXmlTag("PmtReq")]
    public PaymentRequest8? PaymentRequest { get; init; }

    /// <summary>
    /// Content of the reversal request.
    /// </summary>
    [IsoId("_PM-ozbYBEfCUZfsQO4rYeA")]
    [DisplayName("Reversal Request")]
    [IsoXmlTag("RvslReq")]
    public ReversalRequest8? ReversalRequest { get; init; }

    /// <summary>
    /// Content of a Balance Inquiry Request.
    /// </summary>
    [IsoId("_PM-o07YBEfCUZfsQO4rYeA")]
    [DisplayName("Balance Inquiry Request")]
    [IsoXmlTag("BalNqryReq")]
    public BalanceInquiryRequest9? BalanceInquiryRequest { get; init; }

    /// <summary>
    /// Content of the Loyalty Request.
    /// </summary>
    [IsoId("_PM-o2bYBEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Request")]
    [IsoXmlTag("LltyReq")]
    public LoyaltyRequest8? LoyaltyRequest { get; init; }

    /// <summary>
    /// Content of a Stored Value Request.
    /// </summary>
    [IsoId("_PM-o37YBEfCUZfsQO4rYeA")]
    [DisplayName("Stored Value Request")]
    [IsoXmlTag("StordValReq")]
    public StoredValueRequest9? StoredValueRequest { get; init; }

    /// <summary>
    /// Content of the Batch Request.
    /// </summary>
    [IsoId("_PM-o5bYBEfCUZfsQO4rYeA")]
    [DisplayName("Batch Request")]
    [IsoXmlTag("BtchReq")]
    public BatchRequest8? BatchRequest { get; init; }

    /// <summary>
    /// Content of the Enable Service Request.
    /// </summary>
    [IsoId("_PM-o67YBEfCUZfsQO4rYeA")]
    [DisplayName("Enable Service Request")]
    [IsoXmlTag("NblSvcReq")]
    public EnableServiceRequest7? EnableServiceRequest { get; init; }

    /// <summary>
    /// Content of the Card Acquisition Request.
    /// </summary>
    [IsoId("_PM-o8bYBEfCUZfsQO4rYeA")]
    [DisplayName("Card Acquisition Request")]
    [IsoXmlTag("CardAcqstnReq")]
    public CardAcquisitionRequest3? CardAcquisitionRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_PM-o97YBEfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
