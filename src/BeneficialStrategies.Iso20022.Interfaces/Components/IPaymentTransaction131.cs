// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_bTXUYdcZEeqRFcf2R4bPBw")]
public interface IPaymentTransaction131 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the status request.
    /// Usage: The instructing party is the party sending the request message and not the party that sent the original instruction that is being reported on.
    /// </summary>
    [IsoId("_bU924dcZEeqRFcf2R4bPBw")]
    [DisplayName("Status Request Identification")]
    [IsoXmlTag("StsReqId")]
    Max35Text? StatusRequestIdentification { get; }

    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_bU9249cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation29? OriginalGroupInformation { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_bU925dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    Max35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_bU9259cZEeqRFcf2R4bPBw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    Max35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_bU926dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    Max35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_bU9269cZEeqRFcf2R4bPBw")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    UUIDv4Identifier? OriginalUETR { get; }

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_bU927dcZEeqRFcf2R4bPBw")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    ISODateTime? AcceptanceDateTime { get; }

    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_bU9279cZEeqRFcf2R4bPBw")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    Max35Text? ClearingSystemReference { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_bU928dcZEeqRFcf2R4bPBw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification6? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_bU9289cZEeqRFcf2R4bPBw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification6? InstructedAgent { get; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_bU929dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference35? OriginalTransactionReference { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bU9299cZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
