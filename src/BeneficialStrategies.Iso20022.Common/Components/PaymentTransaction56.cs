// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the reversal message applies.
/// </summary>
[IsoId("_qAqPqR72EeSxevWRRWxNAg")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction56
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reversed transaction.|Usage: The instructing party is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_qSfmkR72EeSxevWRRWxNAg")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_qSfmkx72EeSxevWRRWxNAg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_qSfmlR72EeSxevWRRWxNAg")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_qSfmlx72EeSxevWRRWxNAg")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the reversed transaction.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_qSfmmR72EeSxevWRRWxNAg")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <summary>
    /// Specifies if the creditor and/or debtor will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the reversal message, not to the original instruction.
    /// </summary>
    [IsoId("_qSfmmx72EeSxevWRRWxNAg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Provides detailed information on the reversal reason.
    /// </summary>
    [IsoId("_qSfmnR72EeSxevWRRWxNAg")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason7> ReversalReasonInformation { get; init; } = [];

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_qSfmnx72EeSxevWRRWxNAg")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference20? OriginalTransactionReference { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_qSfmoR72EeSxevWRRWxNAg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
