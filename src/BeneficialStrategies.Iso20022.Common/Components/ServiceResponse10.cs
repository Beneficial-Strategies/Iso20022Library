// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the response of the corresponding service request.
/// </summary>
[IsoId("_ammzYbYBEfCUZfsQO4rYeA")]
[DisplayName("Service Response10")]
public record ServiceResponse10
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_anhZZbYBEfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_anhZa7YBEfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    /// <summary>
    /// Define the type of service response.
    /// </summary>
    [IsoId("_anhZcbYBEfCUZfsQO4rYeA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService3Code ServiceContent { get; init; }

    /// <summary>
    /// Data to respond to a Payment request.
    /// </summary>
    [IsoId("_anhZd7YBEfCUZfsQO4rYeA")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse8? PaymentResponse { get; init; }

    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    [IsoId("_anhZfbYBEfCUZfsQO4rYeA")]
    [DisplayName("Reversal Response")]
    [IsoXmlTag("RvslRspn")]
    public ReversalResponse10? ReversalResponse { get; init; }

    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    [IsoId("_anhZg7YBEfCUZfsQO4rYeA")]
    [DisplayName("Balance Inquiry Response")]
    [IsoXmlTag("BalNqryRspn")]
    public BalanceInquiryResponse7? BalanceInquiryResponse { get; init; }

    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    [IsoId("_anhZibYBEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Response")]
    [IsoXmlTag("LltyRspn")]
    public LoyaltyResponse3? LoyaltyResponse { get; init; }

    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    [IsoId("_anhZj7YBEfCUZfsQO4rYeA")]
    [DisplayName("Stored Value Response")]
    [IsoXmlTag("StordValRspn")]
    public StoredValueResponse9? StoredValueResponse { get; init; }

    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    [IsoId("_anhZlbYBEfCUZfsQO4rYeA")]
    [DisplayName("Batch Response")]
    [IsoXmlTag("BtchRspn")]
    public BatchResponse8? BatchResponse { get; init; }

    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [IsoId("_anhZm7YBEfCUZfsQO4rYeA")]
    [DisplayName("Card Acquisition Response")]
    [IsoXmlTag("CardAcqstnRspn")]
    public CardAcquisitionResponse3? CardAcquisitionResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_anhZobYBEfCUZfsQO4rYeA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_anhZp7YBEfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
