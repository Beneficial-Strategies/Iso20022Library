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
[IsoId("_0fJMAQ1VEeqjM-rxn3HuXQ")]
[DisplayName("Service Response")]
public record ServiceResponse3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_0qncMQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_0qncMw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Define the type of service response.
    /// </summary>
    [IsoId("_0qncNQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService3Code ServiceContent { get; init; }

    /// <summary>
    /// Data to respond to a Payment request.
    /// </summary>
    [IsoId("_0qncNw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse2? PaymentResponse { get; init; }

    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    [IsoId("_0qncOQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Reversal Response")]
    [IsoXmlTag("RvslRspn")]
    public ReversalResponse3? ReversalResponse { get; init; }

    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    [IsoId("_0qncOw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Balance Inquiry Response")]
    [IsoXmlTag("BalNqryRspn")]
    public BalanceInquiryResponse2? BalanceInquiryResponse { get; init; }

    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    [IsoId("_0qncPQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Loyalty Response")]
    [IsoXmlTag("LltyRspn")]
    public LoyaltyResponse2? LoyaltyResponse { get; init; }

    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    [IsoId("_0qncPw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Stored Value Response")]
    [IsoXmlTag("StordValRspn")]
    public StoredValueResponse3? StoredValueResponse { get; init; }

    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    [IsoId("_0qncQQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Batch Response")]
    [IsoXmlTag("BtchRspn")]
    public BatchResponse2? BatchResponse { get; init; }

    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [IsoId("_0qncQw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Card Acquisition Response")]
    [IsoXmlTag("CardAcqstnRspn")]
    public CardAcquisitionResponse2? CardAcquisitionResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_0qncRQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_0qncRw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
