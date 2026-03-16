// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_P8J_09p-Ed-ak6NoX_4Aeg_-1232488366")]
[DisplayName("Payment Transaction Information")]
public record PaymentTransactionInformation31
{
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request, as assigned by the assigner.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_P8J_1Np-Ed-ak6NoX_4Aeg_-1232488364")]
    [DisplayName("Cancellation Identification")]
    [IsoXmlTag("CxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationIdentification { get; init; }

    /// <summary>
    /// Set of elements to uniquely and unambiguously identify an exception or an investigation workflow.
    /// </summary>
    [IsoId("_P8J_1dp-Ed-ak6NoX_4Aeg_-170106465")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case2? Case { get; init; }

    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    [IsoId("_P8J_1tp-Ed-ak6NoX_4Aeg_-239701690")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P8Tw0Np-Ed-ak6NoX_4Aeg_-1232488213")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_P8Tw0dp-Ed-ak6NoX_4Aeg_-1232487912")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to umambiguously identify the transaction.
    /// </summary>
    [IsoId("_P8Tw0tp-Ed-ak6NoX_4Aeg_-1232487850")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P8Tw09p-Ed-ak6NoX_4Aeg_-1295924128")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_P8Tw1Np-Ed-ak6NoX_4Aeg_-1232487820")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_P8Tw1dp-Ed-ak6NoX_4Aeg_-134140788")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalInterbankSettlementDate { get; init; }

    /// <summary>
    /// Party who assigns the case.|Usage: This is also the agent that instructs the next party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    [IsoId("_P8Tw1tp-Ed-ak6NoX_4Aeg_-1232487387")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public BranchAndFinancialInstitutionIdentification4? Assigner { get; init; }

    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the agent that is instructed by the previous party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    [IsoId("_P8Tw19p-Ed-ak6NoX_4Aeg_-1232487357")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public BranchAndFinancialInstitutionIdentification4? Assignee { get; init; }

    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_P8Tw2Np-Ed-ak6NoX_4Aeg_-1232487666")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public CancellationReasonInformation3? CancellationReasonInformation { get; init; }

    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_P8Tw2dp-Ed-ak6NoX_4Aeg_-1232487713")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; }
}
