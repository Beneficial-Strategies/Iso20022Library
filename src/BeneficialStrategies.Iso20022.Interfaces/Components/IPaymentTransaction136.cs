// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_cfr9kdcZEeqRFcf2R4bPBw")]
public interface IPaymentTransaction136 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reported status.|Usage: The instructing party is the party sending the status message and not the party that sent the original instruction that is being reported on.
    /// </summary>
    [IsoId("_chXYkdcZEeqRFcf2R4bPBw")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    IsoMax35Text? StatusIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_chXYk9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    IsoMax35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_chXYldcZEeqRFcf2R4bPBw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    IsoMax35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_chXYl9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    IsoUUIDv4Identifier? OriginalUETR { get; }

    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_chXYmdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    ExternalPaymentTransactionStatus1Code? TransactionStatus { get; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_chXYm9cZEeqRFcf2R4bPBw")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation12> StatusReasonInformation { get; }

    /// <summary>
    /// Status related to the requested conditions for the execution of the payment.
    /// </summary>
    [IsoId("_chXYndcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Condition Status")]
    [IsoXmlTag("PmtCondSts")]
    IPaymentConditionStatus1? PaymentConditionStatus { get; }

    /// <summary>
    /// Provides information on the charges related to the processing of the rejection of the instruction.|Usage: This is passed on for information purposes only. Settlement of the charges will be done separately.
    /// </summary>
    [IsoId("_chXYn9cZEeqRFcf2R4bPBw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges7> ChargesInformation { get; }

    /// <summary>
    /// Date and time on when the debtor has accepted or rejected the request.
    /// </summary>
    [IsoId("_chXYodcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Decision Date Time")]
    [IsoXmlTag("DbtrDcsnDtTm")]
    IsoISODateTime? DebtorDecisionDateTime { get; }

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_chXYo9cZEeqRFcf2R4bPBw")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    IsoISODateTime? AcceptanceDateTime { get; }

    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_chXYpdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    IsoMax35Text? AccountServicerReference { get; }

    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_chXYp9cZEeqRFcf2R4bPBw")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    IsoMax35Text? ClearingSystemReference { get; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_chXYqdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference37? OriginalTransactionReference { get; }

    /// <summary>
    /// Document or template enclosed in the notification.
    /// Usage: The use of the EnclosedFile element must be bilaterally agreed.
    /// </summary>
    [IsoId("_chXYq9cZEeqRFcf2R4bPBw")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    IEnumerable<IDocument12> EnclosedFile { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_chXYrdcZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
