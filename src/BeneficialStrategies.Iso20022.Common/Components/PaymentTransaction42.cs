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
[IsoId("_-El7cSHHEeK1OvoXgbVMNg")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction42
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reversed transaction.|Usage: The instructing party is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_-ZnJOSHHEeK1OvoXgbVMNg")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_-ZnJPSHHEeK1OvoXgbVMNg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_-ZnJQSHHEeK1OvoXgbVMNg")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// </summary>
    [IsoId("_-ZnJRSHHEeK1OvoXgbVMNg")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the reversed transaction.
    /// </summary>
    [IsoId("_-ZnJSSHHEeK1OvoXgbVMNg")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; }

    /// <summary>
    /// Specifies if the creditor and/or debtor will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the reversal message, not to the original instruction.
    /// </summary>
    [IsoId("_-ZnJTSHHEeK1OvoXgbVMNg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Provides detailed information on the reversal reason.
    /// </summary>
    [IsoId("_-ZnJUSHHEeK1OvoXgbVMNg")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason7> ReversalReasonInformation { get; init; } = [];

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_-ZnJVSHHEeK1OvoXgbVMNg")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference16? OriginalTransactionReference { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("__uGP4yHHEeK1OvoXgbVMNg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
