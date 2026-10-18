// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("1d3ef31d-3e56-47a4-ba45-f1c8e218be78")]
public interface IPaymentTransaction177 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reported status.
    /// </summary>
    [IsoId("918a36b9-93fd-4d24-894e-8779d70b95e0")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    Max35Text? StatusIdentification { get; }

    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("674170c2-804a-484a-9a5c-d5544d9795d6")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation33? OriginalGroupInformation { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("371ddaa2-93fc-4bda-a394-0e31582f3b7f")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    Max35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("b1795dab-4c6f-439d-a02f-6b27c6aebd92")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    Max35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("ae39a289-ea35-401e-8af3-c9b78278549f")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    Max35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("4f642615-8861-4fa0-92e1-4effe82015e5")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    UUIDv4Identifier? OriginalUETR { get; }

    /// <summary>
    /// Specifies the status of a transaction, as published in an external payment transaction status code list.
    /// </summary>
    [IsoId("c81e4618-d81d-4d08-906f-72319855ad8f")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    ExternalPaymentTransactionStatus1Code? TransactionStatus { get; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("5fa1e035-b6d2-4b4f-b79c-35af7e4ae0cd")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation14> StatusReasonInformation { get; }

    /// <summary>
    /// Provides information on the charges related to the processing of the rejection of the instruction.
    /// </summary>
    [IsoId("4cf00750-c433-40f6-9d8f-929fd976e745")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges16> ChargesInformation { get; }

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent.
    /// </summary>
    [IsoId("14a16f1a-a4ae-4c82-9249-673e443d8b34")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    ISODateTime? AcceptanceDateTime { get; }

    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    [IsoId("d01f4232-da80-46a6-abfa-59894948c3b5")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    IDateAndDateTime2Choice? ProcessingDate { get; }

    /// <summary>
    /// Date and time at which a transaction is completed and cleared, that is, payment is effected.
    /// </summary>
    [IsoId("ebe95271-f80a-4ad9-8717-2e65ff705002")]
    [DisplayName("Effective Interbank Settlement Date")]
    [IsoXmlTag("FctvIntrBkSttlmDt")]
    IDateAndDateTime2Choice? EffectiveInterbankSettlementDate { get; }

    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("6e8670fd-0e2d-48ea-8422-cfe996255c08")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    Max35Text? AccountServicerReference { get; }

    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("9ce3349a-d39d-4e1e-bc65-1771a01c90da")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    Max35Text? ClearingSystemReference { get; }

    /// <summary>
    /// Cryptographic key provided by the CreditorAgent to confirm that settlement on the creditor's account is guaranteed.
    /// </summary>
    [IsoId("48354acb-da04-432e-bee8-ec6eb7582971")]
    [DisplayName("Credit Settlement Key")]
    [IsoXmlTag("CdtSttlmKey")]
    SHA256SignatureText? CreditSettlementKey { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("501e2699-9ee6-4609-9602-e2f1f3dd0dd0")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("3bd43f26-f085-4f20-b7f4-d538b76b81f7")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructedAgent { get; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("cc1fe424-7a71-4fb5-834d-29401a1ba37c")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference47? OriginalTransactionReference { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("454702b6-0bff-4486-a78b-50fd20228b1c")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
