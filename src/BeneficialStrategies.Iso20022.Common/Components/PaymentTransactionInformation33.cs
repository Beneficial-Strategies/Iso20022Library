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
[IsoId("_P69tANp-Ed-ak6NoX_4Aeg_-1329990954")]
[DisplayName("Payment Transaction Information")]
public record PaymentTransactionInformation33
{
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request status, as assigned by the assigner.||Usage: The cancellation status identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_P69tAdp-Ed-ak6NoX_4Aeg_-1329990952")]
    [DisplayName("Cancellation Status Identification")]
    [IsoXmlTag("CxlStsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationStatusIdentification { get; init; }

    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_P69tAtp-Ed-ak6NoX_4Aeg_-1329989944")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case2? ResolvedCase { get; init; }

    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    [IsoId("_P69tA9p-Ed-ak6NoX_4Aeg_-1329989975")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P69tBNp-Ed-ak6NoX_4Aeg_-1329990923")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_P69tBdp-Ed-ak6NoX_4Aeg_-1329990893")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_P69tBtp-Ed-ak6NoX_4Aeg_-1329990831")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P69tB9p-Ed-ak6NoX_4Aeg_1552871622")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <summary>
    /// Specifies the status of the transaction cancellation request.
    /// </summary>
    [IsoId("_P69tCNp-Ed-ak6NoX_4Aeg_-2130380642")]
    [DisplayName("Transaction Cancellation Status")]
    [IsoXmlTag("TxCxlSts")]
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; }

    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_P7HeANp-Ed-ak6NoX_4Aeg_-916279359")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public CancellationStatusReasonInformation1? CancellationStatusReasonInformation { get; init; }

    /// <summary>
    /// Reference of a return or a reversal transaction that is initiated to fix the case under investigation as part of the resolution.
    /// </summary>
    [IsoId("_P7HeAdp-Ed-ak6NoX_4Aeg_1411162804")]
    [DisplayName("Resolution Related Information")]
    [IsoXmlTag("RsltnRltdInf")]
    public ResolutionInformation1? ResolutionRelatedInformation { get; init; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_P7HeAtp-Ed-ak6NoX_4Aeg_-1329990801")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_P7HeA9p-Ed-ak6NoX_4Aeg_-1329990553")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalInterbankSettlementDate { get; init; }

    /// <summary>
    /// Party who assigns the case.|Usage: This is also the agent that instructs the next party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    [IsoId("_P7HeBNp-Ed-ak6NoX_4Aeg_-1329990097")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public Party7Choice_? Assigner { get; init; }

    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the agent that is instructed by the previous party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    [IsoId("_P7HeBdp-Ed-ak6NoX_4Aeg_-1329990036")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public Party7Choice_? Assignee { get; init; }

    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_P7HeBtp-Ed-ak6NoX_4Aeg_-1329990458")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; }
}
