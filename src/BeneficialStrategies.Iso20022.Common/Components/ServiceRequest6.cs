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
[IsoId("_J5wTgXG2Ee2TbaNWBpRZpQ")]
[DisplayName("Service Request")]
public record ServiceRequest6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_KAGMEXG2Ee2TbaNWBpRZpQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_KAGME3G2Ee2TbaNWBpRZpQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_KAGMFXG2Ee2TbaNWBpRZpQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService2Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the payment request.
    /// </summary>
    [IsoId("_KAGMF3G2Ee2TbaNWBpRZpQ")]
    [DisplayName("Payment Request")]
    [IsoXmlTag("PmtReq")]
    public PaymentRequest5? PaymentRequest { get; init; }

    /// <summary>
    /// Content of the reversal request.
    /// </summary>
    [IsoId("_KAGMGXG2Ee2TbaNWBpRZpQ")]
    [DisplayName("Reversal Request")]
    [IsoXmlTag("RvslReq")]
    public ReversalRequest5? ReversalRequest { get; init; }

    /// <summary>
    /// Content of a Balance Inquiry Request.
    /// </summary>
    [IsoId("_KAGMG3G2Ee2TbaNWBpRZpQ")]
    [DisplayName("Balance Inquiry Request")]
    [IsoXmlTag("BalNqryReq")]
    public BalanceInquiryRequest6? BalanceInquiryRequest { get; init; }

    /// <summary>
    /// Content of the Loyalty Request.
    /// </summary>
    [IsoId("_KAGMHXG2Ee2TbaNWBpRZpQ")]
    [DisplayName("Loyalty Request")]
    [IsoXmlTag("LltyReq")]
    public LoyaltyRequest5? LoyaltyRequest { get; init; }

    /// <summary>
    /// Content of a Stored Value Request.
    /// </summary>
    [IsoId("_KAGMH3G2Ee2TbaNWBpRZpQ")]
    [DisplayName("Stored Value Request")]
    [IsoXmlTag("StordValReq")]
    public StoredValueRequest6? StoredValueRequest { get; init; }

    /// <summary>
    /// Content of the Batch Request.
    /// </summary>
    [IsoId("_KAGMIXG2Ee2TbaNWBpRZpQ")]
    [DisplayName("Batch Request")]
    [IsoXmlTag("BtchReq")]
    public BatchRequest5? BatchRequest { get; init; }

    /// <summary>
    /// Content of the Enable Service Request.
    /// </summary>
    [IsoId("_KAGMI3G2Ee2TbaNWBpRZpQ")]
    [DisplayName("Enable Service Request")]
    [IsoXmlTag("NblSvcReq")]
    public EnableServiceRequest5? EnableServiceRequest { get; init; }

    /// <summary>
    /// Content of the Card Acquisition Request.
    /// </summary>
    [IsoId("_KAGMJXG2Ee2TbaNWBpRZpQ")]
    [DisplayName("Card Acquisition Request")]
    [IsoXmlTag("CardAcqstnReq")]
    public CardAcquisitionRequest3? CardAcquisitionRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_KAGMJ3G2Ee2TbaNWBpRZpQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
