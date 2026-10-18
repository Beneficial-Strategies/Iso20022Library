// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Transaction161.
/// </summary>
[IsoId("_-Ni9oTEsEe6GxLzpkVnWYg")]
public interface IPaymentTransaction161 : IIsoComponent
{
    /// <summary>
    /// Acceptance Date Time.
    /// </summary>
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    IsoISODateTime? AcceptanceDateTime { get; }

    /// <summary>
    /// Account Servicer Reference.
    /// </summary>
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    IsoMax35Text? AccountServicerReference { get; }

    /// <summary>
    /// Charges Information.
    /// </summary>
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges16> ChargesInformation { get; }

    /// <summary>
    /// Clearing System Reference.
    /// </summary>
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    IsoMax35Text? ClearingSystemReference { get; }

    /// <summary>
    /// Effective Interbank Settlement Date.
    /// </summary>
    [DisplayName("Effective Interbank Settlement Date")]
    [IsoXmlTag("FctvIntrBkSttlmDt")]
    IDateAndDateTime2Choice? EffectiveInterbankSettlementDate { get; }

    /// <summary>
    /// Instructed Agent.
    /// </summary>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructedAgent { get; }

    /// <summary>
    /// Instructing Agent.
    /// </summary>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructingAgent { get; }

    /// <summary>
    /// Original End To End Identification.
    /// </summary>
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    IsoMax35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Original Group Information.
    /// </summary>
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation29? OriginalGroupInformation { get; }

    /// <summary>
    /// Original Instruction Identification.
    /// </summary>
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    IsoMax35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Original Transaction Identification.
    /// </summary>
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    IsoMax35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Original Transaction Reference.
    /// </summary>
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference42? OriginalTransactionReference { get; }

    /// <summary>
    /// Original UETR.
    /// </summary>
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    IsoUUIDv4Identifier? OriginalUETR { get; }

    /// <summary>
    /// Processing Date.
    /// </summary>
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    IDateAndDateTime2Choice? ProcessingDate { get; }

    /// <summary>
    /// Status Identification.
    /// </summary>
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    IsoMax35Text? StatusIdentification { get; }

    /// <summary>
    /// Status Reason Information.
    /// </summary>
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation14> StatusReasonInformation { get; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }

    /// <summary>
    /// Transaction Status.
    /// </summary>
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    ExternalPaymentTransactionStatus1Code? TransactionStatus { get; }
}
