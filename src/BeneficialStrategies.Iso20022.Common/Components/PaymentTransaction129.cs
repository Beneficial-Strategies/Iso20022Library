// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_ayYHMdcZEeqRFcf2R4bPBw")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction129
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reported status.|Usage: The instructing party is the party sending the status message and not the party that sent the original instruction that is being reported on.
    /// </summary>
    [IsoId("_a0EwUdcZEeqRFcf2R4bPBw")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_a0EwU9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_a0EwVdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_a0EwV9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_a0EwWdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_a0EwW9cZEeqRFcf2R4bPBw")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <summary>
    /// Provides information on the charges related to the processing of the rejection of the instruction.|Usage: This is passed on for information purposes only. Settlement of the charges will be done separately.
    /// </summary>
    [IsoId("_a0EwXdcZEeqRFcf2R4bPBw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <summary>
    /// Provides information on the tracking of the interbank transaction related to the payment.
    /// </summary>
    [IsoId("_a0EwX9cZEeqRFcf2R4bPBw")]
    [DisplayName("Tracker Data")]
    [IsoXmlTag("TrckrData")]
    public TrackerData1? TrackerData { get; init; }

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_a0EwYdcZEeqRFcf2R4bPBw")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_a0EwY9cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_a0EwZdcZEeqRFcf2R4bPBw")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_a0EwZ9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference35? OriginalTransactionReference { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_a0EwadcZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
