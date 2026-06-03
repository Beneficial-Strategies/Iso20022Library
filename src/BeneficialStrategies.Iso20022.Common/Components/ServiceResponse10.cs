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
    [IsoId("_anhZZbYBEfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    [IsoId("_anhZa7YBEfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    [IsoId("_anhZcbYBEfCUZfsQO4rYeA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService3Code ServiceContent { get; init; }

    [IsoId("_anhZd7YBEfCUZfsQO4rYeA")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse8? PaymentResponse { get; init; }

    [IsoId("_anhZfbYBEfCUZfsQO4rYeA")]
    [DisplayName("Reversal Response")]
    [IsoXmlTag("RvslRspn")]
    public ReversalResponse10? ReversalResponse { get; init; }

    [IsoId("_anhZg7YBEfCUZfsQO4rYeA")]
    [DisplayName("Balance Inquiry Response")]
    [IsoXmlTag("BalNqryRspn")]
    public BalanceInquiryResponse7? BalanceInquiryResponse { get; init; }

    [IsoId("_anhZibYBEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Response")]
    [IsoXmlTag("LltyRspn")]
    public LoyaltyResponse3? LoyaltyResponse { get; init; }

    [IsoId("_anhZj7YBEfCUZfsQO4rYeA")]
    [DisplayName("Stored Value Response")]
    [IsoXmlTag("StordValRspn")]
    public StoredValueResponse9? StoredValueResponse { get; init; }

    [IsoId("_anhZlbYBEfCUZfsQO4rYeA")]
    [DisplayName("Batch Response")]
    [IsoXmlTag("BtchRspn")]
    public BatchResponse8? BatchResponse { get; init; }

    [IsoId("_anhZm7YBEfCUZfsQO4rYeA")]
    [DisplayName("Card Acquisition Response")]
    [IsoXmlTag("CardAcqstnRspn")]
    public CardAcquisitionResponse3? CardAcquisitionResponse { get; init; }

    [IsoId("_anhZobYBEfCUZfsQO4rYeA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    [IsoId("_anhZp7YBEfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
