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
[IsoId("_QNHyY8YAEeexPc-mfUU5zQ")]
[DisplayName("Reorganisation Instruction Details SD")]
public record ReorganisationInstructionDetailsSD2
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_QNHyZcYAEeexPc-mfUU5zQ")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Identifies the reorganisation transaction type.
    /// </summary>
    [IsoId("_QNHyZ8YAEeexPc-mfUU5zQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ReorganisationTransactionType1Code? TransactionType { get; init; }

    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_QNHyZMYAEeexPc-mfUU5zQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoMax15Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_QNHybsYAEeexPc-mfUU5zQ")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; }

    /// <summary>
    /// Unique identifier for each customer in a transaction.
    /// </summary>
    [IsoId("_QNHydcYAEeexPc-mfUU5zQ")]
    [DisplayName("Customer Sequence Number")]
    [IsoXmlTag("CstmrSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? CustomerSequenceNumber { get; init; }

    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_2kqqEcYCEeexPc-mfUU5zQ")]
    [DisplayName("Transaction Identification Status")]
    [IsoXmlTag("TxIdSts")]
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; init; }

    /// <summary>
    /// Status of the Protect Instruction.
    /// </summary>
    [IsoId("_VtVLMcYDEeexPc-mfUU5zQ")]
    [DisplayName("Protect Transaction Status")]
    [IsoXmlTag("PrtctTxSts")]
    public DTCProtectInstructionStatus1Code? ProtectTransactionStatus { get; init; }

    /// <summary>
    /// Reason for which an inbound instruction message or a cancellation instruction message is rejected.
    /// </summary>
    [IsoId("_XR8e8MYLEeexPc-mfUU5zQ")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<InstructionRejectionReason1Code> RejectionReason { get; init; } = [];

    /// <summary>
    /// Identifies the protect itself or of that is being covered. It is required for the function types cover protect (COVR), cover protect directly to agent (COVA) and cover on behalf of another participant (COVP).
    /// </summary>
    [IsoId("_QNHyZsYAEeexPc-mfUU5zQ")]
    [DisplayName("Protect Identification")]
    [IsoXmlTag("PrtctId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoMax15Text ProtectIdentification { get; init; }

    /// <summary>
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    [IsoId("_ZdaAwOZTEeewObBhnieI_A")]
    [DisplayName("Protect Safekeeping Account")]
    [IsoXmlTag("PrtctSfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINMax35Text? ProtectSafekeepingAccount { get; init; }

    /// <summary>
    /// Date on which the protect was created. It is required for transaction types cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and
    /// cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_QNHyc8YAEeexPc-mfUU5zQ")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ProtectDate { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_QNHyaMYAEeexPc-mfUU5zQ")]
    [DisplayName("Securities Quantity Details")]
    [IsoXmlTag("SctiesQtyDtls")]
    public SecuritiesQuantityDetailsSD4? SecuritiesQuantityDetails { get; init; }

    /// <summary>
    /// Warrant subscription amount entered by client when instructing on a warrant exercise instruction.
    /// </summary>
    [IsoId("_QNHydMYAEeexPc-mfUU5zQ")]
    [DisplayName("Warrant Subscription Charge Amount")]
    [IsoXmlTag("WarrtSbcptChrgAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; init; }

    /// <summary>
    /// Indicates whether the tender offer accepts odd lots.
    /// Yes: tender offer accepts odd lots.
    /// No: tender offer does not accept odd lots.
    /// </summary>
    [IsoId("_QNHyb8YAEeexPc-mfUU5zQ")]
    [DisplayName("Tender Odd Lot Indicator")]
    [IsoXmlTag("TndrOddLotInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TenderOddLotIndicator { get; init; }

    /// <summary>
    /// Certificate information for a given instruction.
    /// </summary>
    [IsoId("_QNHyacYAEeexPc-mfUU5zQ")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public CorporateActionCertificateSD1? Certificate { get; init; }

    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_QNHybMYAEeexPc-mfUU5zQ")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_QNHyasYAEeexPc-mfUU5zQ")]
    [DisplayName("User Reference Number")]
    [IsoXmlTag("UsrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public IsoMax6Text? UserReferenceNumber { get; init; }

    /// <summary>
    /// Party contact information for the given instruction; required for voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_QNHybcYAEeexPc-mfUU5zQ")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification5? ContactPerson { get; init; }

    /// <summary>
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    [IsoId("_QNHyccYAEeexPc-mfUU5zQ")]
    [DisplayName("Acknowledgement Details")]
    [IsoXmlTag("AckDtls")]
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; init; }

    /// <summary>
    /// Beneficial owner information related to CD early redemption instructions.
    /// </summary>
    [IsoId("_QNHycsYAEeexPc-mfUU5zQ")]
    [DisplayName("Deceased Beneficial Owner Details")]
    [IsoXmlTag("DcsdBnfclOwnrDtls")]
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; init; }

    /// <summary>
    /// Transaction record number for ATAM or ART system which may be causing pending status. Corresponds to ATP RBN number.
    /// </summary>
    [IsoId("_JsgVQMYREeexPc-mfUU5zQ")]
    [DisplayName("Transaction Record Number")]
    [IsoXmlTag("TxRcrdNb")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? TransactionRecordNumber { get; init; }
}
