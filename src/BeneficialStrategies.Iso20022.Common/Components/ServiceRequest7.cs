// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service Request7.
/// </summary>
[IsoId("_h1eTQZThEe6sd81HehWb6w")]
[DisplayName("Service Request7")]
public record ServiceRequest7
{
    /// <summary>
    /// Balance Inquiry Request.
    /// </summary>
    [DisplayName("Balance Inquiry Request")]
    [IsoXmlTag("BalNqryReq")]
    public BalanceInquiryRequest7? BalanceInquiryRequest { get; init; }

    /// <summary>
    /// Batch Request.
    /// </summary>
    [DisplayName("Batch Request")]
    [IsoXmlTag("BtchReq")]
    public BatchRequest6? BatchRequest { get; init; }

    /// <summary>
    /// Card Acquisition Request.
    /// </summary>
    [DisplayName("Card Acquisition Request")]
    [IsoXmlTag("CardAcqstnReq")]
    public CardAcquisitionRequest3? CardAcquisitionRequest { get; init; }

    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Enable Service Request.
    /// </summary>
    [DisplayName("Enable Service Request")]
    [IsoXmlTag("NblSvcReq")]
    public EnableServiceRequest6? EnableServiceRequest { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment80 Environment { get; init; }

    /// <summary>
    /// Loyalty Request.
    /// </summary>
    [DisplayName("Loyalty Request")]
    [IsoXmlTag("LltyReq")]
    public LoyaltyRequest6? LoyaltyRequest { get; init; }

    /// <summary>
    /// Payment Request.
    /// </summary>
    [DisplayName("Payment Request")]
    [IsoXmlTag("PmtReq")]
    public PaymentRequest6? PaymentRequest { get; init; }

    /// <summary>
    /// Reversal Request.
    /// </summary>
    [DisplayName("Reversal Request")]
    [IsoXmlTag("RvslReq")]
    public ReversalRequest6? ReversalRequest { get; init; }

    /// <summary>
    /// Service Content.
    /// </summary>
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService2Code ServiceContent { get; init; }

    /// <summary>
    /// Stored Value Request.
    /// </summary>
    [DisplayName("Stored Value Request")]
    [IsoXmlTag("StordValReq")]
    public StoredValueRequest7? StoredValueRequest { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
