// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component contains the response of the corresponding service request.
/// </summary>
[IsoId("_l07w0VS8EeuUvsVXOV79DQ")]
[DisplayName("Service Response")]
public record ServiceResponse5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_l7BKsVS8EeuUvsVXOV79DQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_l7BKs1S8EeuUvsVXOV79DQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Define the type of service response.
    /// </summary>
    [IsoId("_l7BKtVS8EeuUvsVXOV79DQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService3Code ServiceContent { get; init; }

    /// <summary>
    /// Data to respond to a Payment request.
    /// </summary>
    [IsoId("_l7BKt1S8EeuUvsVXOV79DQ")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse3? PaymentResponse { get; init; }

    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    [IsoId("_l7BKuVS8EeuUvsVXOV79DQ")]
    [DisplayName("Reversal Response")]
    [IsoXmlTag("RvslRspn")]
    public ReversalResponse5? ReversalResponse { get; init; }

    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    [IsoId("_l7BKu1S8EeuUvsVXOV79DQ")]
    [DisplayName("Balance Inquiry Response")]
    [IsoXmlTag("BalNqryRspn")]
    public BalanceInquiryResponse3? BalanceInquiryResponse { get; init; }

    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    [IsoId("_l7BKvVS8EeuUvsVXOV79DQ")]
    [DisplayName("Loyalty Response")]
    [IsoXmlTag("LltyRspn")]
    public LoyaltyResponse2? LoyaltyResponse { get; init; }

    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    [IsoId("_l7BKv1S8EeuUvsVXOV79DQ")]
    [DisplayName("Stored Value Response")]
    [IsoXmlTag("StordValRspn")]
    public StoredValueResponse4? StoredValueResponse { get; init; }

    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    [IsoId("_l7BKwVS8EeuUvsVXOV79DQ")]
    [DisplayName("Batch Response")]
    [IsoXmlTag("BtchRspn")]
    public BatchResponse3? BatchResponse { get; init; }

    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [IsoId("_l7BKw1S8EeuUvsVXOV79DQ")]
    [DisplayName("Card Acquisition Response")]
    [IsoXmlTag("CardAcqstnRspn")]
    public CardAcquisitionResponse2? CardAcquisitionResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_l7BKxVS8EeuUvsVXOV79DQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_l7BKx1S8EeuUvsVXOV79DQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
