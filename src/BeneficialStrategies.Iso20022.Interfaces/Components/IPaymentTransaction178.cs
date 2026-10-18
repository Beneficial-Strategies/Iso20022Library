// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("11374abc-92e8-4404-9e28-3abe0e95451e")]
public interface IPaymentTransaction178 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reported status.
    /// </summary>
    [IsoId("4f32e264-3c93-4db4-804f-a6635273e95d")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    IsoMax35Text? StatusIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("03067730-3ce5-4e02-898d-8310250932f0")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    IsoMax35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("0edf9c27-d8d0-4053-858c-54543f476842")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    IsoMax35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("48803fbe-0c31-4f35-88c3-6b916596aff4")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    IsoUUIDv4Identifier? OriginalUETR { get; }

    /// <summary>
    /// Specifies the status of a transaction, as published in an external payment transaction status code list.
    /// </summary>
    [IsoId("b95bfa26-b565-459e-b720-a1224291db62")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    ExternalPaymentTransactionStatus1Code? TransactionStatus { get; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("7e3d81bd-53c1-44cc-96fc-9a06770d3ade")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    IEnumerable<IStatusReasonInformation14> StatusReasonInformation { get; }

    /// <summary>
    /// Provides information on the charges related to the processing of the rejection of the instruction.
    /// </summary>
    [IsoId("d4f9c89a-1287-4e9b-ab53-e29165f85536")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges16> ChargesInformation { get; }

    /// <summary>
    /// Provides information on the tracking of the interbank transaction related to the payment.
    /// </summary>
    [IsoId("da0203a1-5dff-4c76-b85e-a04952d14db1")]
    [DisplayName("Tracker Data")]
    [IsoXmlTag("TrckrData")]
    ITrackerData7? TrackerData { get; }

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent.
    /// </summary>
    [IsoId("f02f25c6-dd7a-498f-ae89-4fe505d5ea38")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    IsoISODateTime? AcceptanceDateTime { get; }

    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("cff4dd3b-df37-4738-bcbe-e79736e1be61")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    IsoMax35Text? AccountServicerReference { get; }

    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("0a00c043-6a84-40f5-b2ee-e880e52bb301")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    IsoMax35Text? ClearingSystemReference { get; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("286699fd-b24b-4c0e-a2ae-b9ffc5a160be")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference47? OriginalTransactionReference { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("4198462d-1f2b-445e-a7c0-405d1211efcd")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
