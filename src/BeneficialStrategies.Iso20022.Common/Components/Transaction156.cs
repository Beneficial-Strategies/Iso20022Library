// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fee transaction type.
/// </summary>
[IsoId("_HaI7IYgpEeu8-LhY4KPfWg")]
[DisplayName("Transaction")]
public record Transaction156
{
    /// <summary>
    /// Type of transaction associated with the main service
    /// For valid values, see &quot;Transaction type codes&quot; in ISO 8583 &quot;Financial transaction card originated messages — Interchange message specifications&quot;
    /// </summary>
    [IsoId("_Hff8QYgpEeu8-LhY4KPfWg")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ISO8583TransactionTypeCode TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_Hff8Q4gpEeu8-LhY4KPfWg")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Indicates the previous fee collection message is cancelled.
    /// </summary>
    [IsoId("_6DWdwCxLEeyg-aG5nXcnfg")]
    [DisplayName("Cancellation Indicator")]
    [IsoXmlTag("CxlInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CancellationIndicator { get; init; }

    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_TVUdZ8sJEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ISO8583MessageReasonCode? MessageReason { get; init; }

    /// <summary>
    /// Alternate message reason to send the message.
    /// </summary>
    [IsoId("_Hff8R4gpEeu8-LhY4KPfWg")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AlternateMessageReason { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_Hff8SYgpEeu8-LhY4KPfWg")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_Hff8S4gpEeu8-LhY4KPfWg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification51 TransactionIdentification { get; init; }

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_Hff8TYgpEeu8-LhY4KPfWg")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts2 TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_Hff8T4gpEeu8-LhY4KPfWg")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public AdditionalAmounts3? AdditionalAmount { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_Hff8UYgpEeu8-LhY4KPfWg")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_Hff8U4gpEeu8-LhY4KPfWg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }

    /// <summary>
    /// Indicates the Fee Collection cycle.
    /// </summary>
    [IsoId("_F7fwcCxMEeyg-aG5nXcnfg")]
    [DisplayName("Fee Collection Cycle")]
    [IsoXmlTag("FeeColltnCycl")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    public IsoExact1NumericText? FeeCollectionCycle { get; init; }

    /// <summary>
    /// Reference for the Fee Collection.
    /// </summary>
    [IsoId("_gyKQ4CxMEeyg-aG5nXcnfg")]
    [DisplayName("Fee Collection Reference")]
    [IsoXmlTag("FeeColltnRef")]
    public FeeCollectionReference1? FeeCollectionReference { get; init; }
}
