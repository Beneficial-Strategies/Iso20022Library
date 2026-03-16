// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component defines the service to be called.
/// </summary>
[IsoId("_ndUwoYX_EemxIqbaFEE8-w")]
[DisplayName("Service Request")]
public record ServiceRequest2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_nnickYX_EemxIqbaFEE8-w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment73 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_nnick4X_EemxIqbaFEE8-w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext27 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_nniclYX_EemxIqbaFEE8-w")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService2Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the payment request.
    /// </summary>
    [IsoId("_nnicl4X_EemxIqbaFEE8-w")]
    [DisplayName("Payment Request")]
    [IsoXmlTag("PmtReq")]
    public PaymentRequest1? PaymentRequest { get; init; }

    /// <summary>
    /// Content of the reversal request.
    /// </summary>
    [IsoId("_nnicmYX_EemxIqbaFEE8-w")]
    [DisplayName("Reversal Request")]
    [IsoXmlTag("RvslReq")]
    public ReversalRequest1? ReversalRequest { get; init; }

    /// <summary>
    /// Content of a Balance Inquiry Request.
    /// </summary>
    [IsoId("_nnicm4X_EemxIqbaFEE8-w")]
    [DisplayName("Balance Inquiry Request")]
    [IsoXmlTag("BalNqryReq")]
    public BalanceInquiryRequest2? BalanceInquiryRequest { get; init; }

    /// <summary>
    /// Content of the Loyalty Request.
    /// </summary>
    [IsoId("_nnicnYX_EemxIqbaFEE8-w")]
    [DisplayName("Loyalty Request")]
    [IsoXmlTag("LltyReq")]
    public LoyaltyRequest1? LoyaltyRequest { get; init; }

    /// <summary>
    /// Content of a Stored Value Request.
    /// </summary>
    [IsoId("_nnjDoYX_EemxIqbaFEE8-w")]
    [DisplayName("Stored Value Request")]
    [IsoXmlTag("StordValReq")]
    public StoredValueRequest2? StoredValueRequest { get; init; }

    /// <summary>
    /// Content of the Batch Request.
    /// </summary>
    [IsoId("_nnjDo4X_EemxIqbaFEE8-w")]
    [DisplayName("Batch Request")]
    [IsoXmlTag("BtchReq")]
    public BatchRequest1? BatchRequest { get; init; }

    /// <summary>
    /// Content of the Enable Service Request.
    /// </summary>
    [IsoId("_nnjDpYX_EemxIqbaFEE8-w")]
    [DisplayName("Enable Service Request")]
    [IsoXmlTag("NblSvcReq")]
    public EnableServiceRequest1? EnableServiceRequest { get; init; }

    /// <summary>
    /// Content of the Card Acquisition Request.
    /// </summary>
    [IsoId("_nnjDp4X_EemxIqbaFEE8-w")]
    [DisplayName("Card Acquisition Request")]
    [IsoXmlTag("CardAcqstnReq")]
    public CardAcquisitionRequest2? CardAcquisitionRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_nnjDqYX_EemxIqbaFEE8-w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
