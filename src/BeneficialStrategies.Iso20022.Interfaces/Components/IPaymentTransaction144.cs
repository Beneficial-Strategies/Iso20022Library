// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_OAJzlxlWEe2Do_UtrNmb2g")]
public interface IPaymentTransaction144 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reported status.|Usage: The instructing party is the party sending the status message and not the party that sent the original instruction that is being reported on.
    /// </summary>
    [IsoId("_OJv0YRlWEe2Do_UtrNmb2g")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    IsoMax35Text? StatusIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_OJv0YxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    IsoMax35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_OJv0ZRlWEe2Do_UtrNmb2g")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    IsoMax35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_OJv0ZxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    IsoUUIDv4Identifier? OriginalUETR { get; }

    /// <summary>
    /// Specifies the status of a transaction, as published in an external payment transaction status code list.
    /// </summary>
    [IsoId("_OJv0aRlWEe2Do_UtrNmb2g")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    ExternalPaymentTransactionStatus1Code? TransactionStatus { get; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_OJv0axlWEe2Do_UtrNmb2g")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation12> StatusReasonInformation { get; }

    /// <summary>
    /// Provides information on the charges related to the processing of the rejection of the instruction.|Usage: This is passed on for information purposes only. Settlement of the charges will be done separately.
    /// </summary>
    [IsoId("_OJv0bRlWEe2Do_UtrNmb2g")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges12> ChargesInformation { get; }

    /// <summary>
    /// Provides information on the tracking of the interbank transaction related to the payment.
    /// </summary>
    [IsoId("_OJv0bxlWEe2Do_UtrNmb2g")]
    [DisplayName("Tracker Data")]
    [IsoXmlTag("TrckrData")]
    ITrackerData1? TrackerData { get; }

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_OJv0cRlWEe2Do_UtrNmb2g")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    IsoISODateTime? AcceptanceDateTime { get; }

    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_OJv0cxlWEe2Do_UtrNmb2g")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    IsoMax35Text? AccountServicerReference { get; }

    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_OJv0dRlWEe2Do_UtrNmb2g")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    IsoMax35Text? ClearingSystemReference { get; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_OJv0dxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference35? OriginalTransactionReference { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_OJv0eRlWEe2Do_UtrNmb2g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
