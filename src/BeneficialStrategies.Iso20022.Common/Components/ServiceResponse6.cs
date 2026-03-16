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
[IsoId("_BynvsU0_Eeybj420QgWBkA")]
[DisplayName("Service Response")]
public record ServiceResponse6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_B5udQU0_Eeybj420QgWBkA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_B5udQ00_Eeybj420QgWBkA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext29 Context { get; init; }

    /// <summary>
    /// Define the type of service response.
    /// </summary>
    [IsoId("_B5udRU0_Eeybj420QgWBkA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService3Code ServiceContent { get; init; }

    /// <summary>
    /// Data to respond to a Payment request.
    /// </summary>
    [IsoId("_B5udR00_Eeybj420QgWBkA")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse4? PaymentResponse { get; init; }

    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    [IsoId("_B5udSU0_Eeybj420QgWBkA")]
    [DisplayName("Reversal Response")]
    [IsoXmlTag("RvslRspn")]
    public ReversalResponse6? ReversalResponse { get; init; }

    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    [IsoId("_B5udS00_Eeybj420QgWBkA")]
    [DisplayName("Balance Inquiry Response")]
    [IsoXmlTag("BalNqryRspn")]
    public BalanceInquiryResponse4? BalanceInquiryResponse { get; init; }

    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    [IsoId("_B5udTU0_Eeybj420QgWBkA")]
    [DisplayName("Loyalty Response")]
    [IsoXmlTag("LltyRspn")]
    public LoyaltyResponse3? LoyaltyResponse { get; init; }

    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    [IsoId("_B5udT00_Eeybj420QgWBkA")]
    [DisplayName("Stored Value Response")]
    [IsoXmlTag("StordValRspn")]
    public StoredValueResponse5? StoredValueResponse { get; init; }

    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    [IsoId("_B5udUU0_Eeybj420QgWBkA")]
    [DisplayName("Batch Response")]
    [IsoXmlTag("BtchRspn")]
    public BatchResponse4? BatchResponse { get; init; }

    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [IsoId("_B5udU00_Eeybj420QgWBkA")]
    [DisplayName("Card Acquisition Response")]
    [IsoXmlTag("CardAcqstnRspn")]
    public CardAcquisitionResponse3? CardAcquisitionResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_B5udVU0_Eeybj420QgWBkA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_B5udV00_Eeybj420QgWBkA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
