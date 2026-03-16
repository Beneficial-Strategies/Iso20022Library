// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Foreign Exchange Trade Confirmation1.
/// </summary>
[IsoId("_7EuuYOq_Ee6VKYlUtt-ZtQ")]
[DisplayName("Foreign Exchange Trade Confirmation1")]
public record ForeignExchangeTradeConfirmation1
{
    /// <summary>
    /// Common Identification.
    /// </summary>
    [DisplayName("Common Identification")]
    [IsoXmlTag("")]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("")]
    public required IsoMax47Text Identification { get; init; }

    /// <summary>
    /// Initiating Party.
    /// </summary>
    [DisplayName("Initiating Party")]
    [IsoXmlTag("")]
    public required TradeParty7 InitiatingParty { get; init; }

    /// <summary>
    /// Lifecycle Status.
    /// </summary>
    [DisplayName("Lifecycle Status")]
    [IsoXmlTag("")]
    public required FXTradeConfirmationStatusCode LifecycleStatus { get; init; }

    /// <summary>
    /// Product Type.
    /// </summary>
    [DisplayName("Product Type")]
    [IsoXmlTag("")]
    public OptionDefinitionType1Code? ProductType { get; init; }

    /// <summary>
    /// Receiving Party.
    /// </summary>
    [DisplayName("Receiving Party")]
    [IsoXmlTag("")]
    public required TradeParty7 ReceivingParty { get; init; }

    /// <summary>
    /// Sender Reference.
    /// </summary>
    [DisplayName("Sender Reference")]
    [IsoXmlTag("")]
    public required IsoMax35Text SenderReference { get; init; }

    /// <summary>
    /// Settlement Instruction.
    /// </summary>
    [DisplayName("Settlement Instruction")]
    [IsoXmlTag("")]
    public ValueList<SettlementInstruction18> SettlementInstruction { get; init; } = [];

    /// <summary>
    /// Split Settlement Count.
    /// </summary>
    [DisplayName("Split Settlement Count")]
    [IsoXmlTag("")]
    public IsoNonNegativeNumber? SplitSettlementCount { get; init; }

    /// <summary>
    /// Split Settlement Indicator.
    /// </summary>
    [DisplayName("Split Settlement Indicator")]
    [IsoXmlTag("")]
    public Isoboolean? SplitSettlementIndicator { get; init; }

    /// <summary>
    /// Status Reason.
    /// </summary>
    [DisplayName("Status Reason")]
    [IsoXmlTag("")]
    public ExternalStatusReasonCode? StatusReason { get; init; }

    /// <summary>
    /// Trade Detail.
    /// </summary>
    [DisplayName("Trade Detail")]
    [IsoXmlTag("")]
    public required ForeignExchangeTrade1 TradeDetail { get; init; }
}
