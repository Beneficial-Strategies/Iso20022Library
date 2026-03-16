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
[IsoId("_vzaL4S5LEeunNvJlR_vCbg")]
[DisplayName("Service Request")]
public record ServiceRequest4
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_wCyEoS5LEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_wCyEoy5LEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_wCyEpS5LEeunNvJlR_vCbg")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService2Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the payment request.
    /// </summary>
    [IsoId("_wCyEpy5LEeunNvJlR_vCbg")]
    [DisplayName("Payment Request")]
    [IsoXmlTag("PmtReq")]
    public PaymentRequest3? PaymentRequest { get; init; }

    /// <summary>
    /// Content of the reversal request.
    /// </summary>
    [IsoId("_wCyEqS5LEeunNvJlR_vCbg")]
    [DisplayName("Reversal Request")]
    [IsoXmlTag("RvslReq")]
    public ReversalRequest3? ReversalRequest { get; init; }

    /// <summary>
    /// Content of a Balance Inquiry Request.
    /// </summary>
    [IsoId("_wCyEqy5LEeunNvJlR_vCbg")]
    [DisplayName("Balance Inquiry Request")]
    [IsoXmlTag("BalNqryReq")]
    public BalanceInquiryRequest4? BalanceInquiryRequest { get; init; }

    /// <summary>
    /// Content of the Loyalty Request.
    /// </summary>
    [IsoId("_wCyErS5LEeunNvJlR_vCbg")]
    [DisplayName("Loyalty Request")]
    [IsoXmlTag("LltyReq")]
    public LoyaltyRequest3? LoyaltyRequest { get; init; }

    /// <summary>
    /// Content of a Stored Value Request.
    /// </summary>
    [IsoId("_wCyEry5LEeunNvJlR_vCbg")]
    [DisplayName("Stored Value Request")]
    [IsoXmlTag("StordValReq")]
    public StoredValueRequest4? StoredValueRequest { get; init; }

    /// <summary>
    /// Content of the Batch Request.
    /// </summary>
    [IsoId("_wCyEsS5LEeunNvJlR_vCbg")]
    [DisplayName("Batch Request")]
    [IsoXmlTag("BtchReq")]
    public BatchRequest3? BatchRequest { get; init; }

    /// <summary>
    /// Content of the Enable Service Request.
    /// </summary>
    [IsoId("_wCyEsy5LEeunNvJlR_vCbg")]
    [DisplayName("Enable Service Request")]
    [IsoXmlTag("NblSvcReq")]
    public EnableServiceRequest3? EnableServiceRequest { get; init; }

    /// <summary>
    /// Content of the Card Acquisition Request.
    /// </summary>
    [IsoId("_wCyEtS5LEeunNvJlR_vCbg")]
    [DisplayName("Card Acquisition Request")]
    [IsoXmlTag("CardAcqstnReq")]
    public CardAcquisitionRequest2? CardAcquisitionRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_wCyEty5LEeunNvJlR_vCbg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
