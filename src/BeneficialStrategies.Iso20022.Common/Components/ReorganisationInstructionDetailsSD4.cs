// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action reorganisation instruction details.
/// </summary>
[IsoId("_dbQNhcY1EeesocHIuVGr7g")]
[DisplayName("Reorganisation Instruction Details SD")]
public record ReorganisationInstructionDetailsSD4
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_dbQNjMY1EeesocHIuVGr7g")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Identifies the reorganisation withdrawal transaction type.
    /// </summary>
    [IsoId("_Tgdi0cY2EeesocHIuVGr7g")]
    [DisplayName("Withdrawal Transaction Type")]
    [IsoXmlTag("WdrwlTxTp")]
    public ReorganisationWithdrawalTransactionType1Code? WithdrawalTransactionType { get; init; }

    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_dbQNicY1EeesocHIuVGr7g")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoMax15Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_dbQNiMY1EeesocHIuVGr7g")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; }

    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_dbQNl8Y1EeesocHIuVGr7g")]
    [DisplayName("Transaction Identification Status")]
    [IsoXmlTag("TxIdSts")]
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; init; }

    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    [IsoId("_dbQNlMY1EeesocHIuVGr7g")]
    [DisplayName("Protect Transaction Status")]
    [IsoXmlTag("PrtctTxSts")]
    public DTCProtectInstructionStatus1Code? ProtectTransactionStatus { get; init; }

    /// <summary>
    /// Reason for which an inbound instruction message or a cancellation instruction message is rejected.
    /// </summary>
    [IsoId("_dbQNjcY1EeesocHIuVGr7g")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<InstructionRejectionReason1Code> RejectionReason { get; init; } = [];

    /// <summary>
    /// Identifies the protect itself or of that is being covered. It is required for the function types cover protect (COVR), cover protect directly to agent (COVA) and cover on behalf of another participant (COVP).
    /// </summary>
    [IsoId("_dbQNmcY1EeesocHIuVGr7g")]
    [DisplayName("Protect Identification")]
    [IsoXmlTag("PrtctId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoMax15Text ProtectIdentification { get; init; }

    /// <summary>
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    [IsoId("_ptMpIeZTEeewObBhnieI_A")]
    [DisplayName("Protect Safekeeping Account")]
    [IsoXmlTag("PrtctSfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINMax35Text? ProtectSafekeepingAccount { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_dbQNlsY1EeesocHIuVGr7g")]
    [DisplayName("Securities Quantity Details")]
    [IsoXmlTag("SctiesQtyDtls")]
    public SecuritiesQuantityDetailsSD4? SecuritiesQuantityDetails { get; init; }

    /// <summary>
    /// Party contact information for the given instruction; required for voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_dbQNi8Y1EeesocHIuVGr7g")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification5? ContactPerson { get; init; }

    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_dbQNkcY1EeesocHIuVGr7g")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_dbQNj8Y1EeesocHIuVGr7g")]
    [DisplayName("User Reference Number")]
    [IsoXmlTag("UsrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public IsoMax6Text? UserReferenceNumber { get; init; }

    /// <summary>
    /// Transaction record number for ATAM or ART system which may be causing pending status. Corresponds to ATP RBN number.
    /// </summary>
    [IsoId("_dbQNksY1EeesocHIuVGr7g")]
    [DisplayName("Transaction Record Number")]
    [IsoXmlTag("TxRcrdNb")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? TransactionRecordNumber { get; init; }
}
