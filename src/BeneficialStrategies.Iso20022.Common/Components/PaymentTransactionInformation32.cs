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
[IsoId("_P8dh0Np-Ed-ak6NoX_4Aeg_819937284")]
[DisplayName("Payment Transaction Information")]
public record PaymentTransactionInformation32
{
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request status, as assigned by the assigner.||Usage: The cancellation status identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_P8dh0dp-Ed-ak6NoX_4Aeg_819937286")]
    [DisplayName("Cancellation Status Identification")]
    [IsoXmlTag("CxlStsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationStatusIdentification { get; init; }

    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_P8dh0tp-Ed-ak6NoX_4Aeg_819938233")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case2? ResolvedCase { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P8dh09p-Ed-ak6NoX_4Aeg_819937315")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_P8dh1Np-Ed-ak6NoX_4Aeg_819937376")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Specifies the status of the transaction cancellation request.
    /// </summary>
    [IsoId("_P8dh1dp-Ed-ak6NoX_4Aeg_1666808462")]
    [DisplayName("Transaction Cancellation Status")]
    [IsoXmlTag("TxCxlSts")]
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; }

    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_P8dh1tp-Ed-ak6NoX_4Aeg_819938293")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public ValueList<CancellationStatusReasonInformation1> CancellationStatusReasonInformation { get; init; } =
        [];

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// </summary>
    [IsoId("_P8dh19p-Ed-ak6NoX_4Aeg_1304787220")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <summary>
    /// Date at which the initiating party originally requested the clearing agent to process the payment.
    /// </summary>
    [IsoId("_P8dh2Np-Ed-ak6NoX_4Aeg_1304787252")]
    [DisplayName("Original Requested Execution Date")]
    [IsoXmlTag("OrgnlReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalRequestedExecutionDate { get; init; }

    /// <summary>
    /// Date at which the creditor originally requested the collection of the amount of money from the debtor.
    /// </summary>
    [IsoId("_P8dh2dp-Ed-ak6NoX_4Aeg_1304787251")]
    [DisplayName("Original Requested Collection Date")]
    [IsoXmlTag("OrgnlReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalRequestedCollectionDate { get; init; }

    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_P8mrwNp-Ed-ak6NoX_4Aeg_819938140")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; }
}
