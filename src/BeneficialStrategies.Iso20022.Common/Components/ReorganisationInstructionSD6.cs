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
[IsoId("_iABhoecmEei5aPS232E3Mw")]
[DisplayName("Reorganisation Instruction SD")]
public record ReorganisationInstructionSD6
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_imjWIecmEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_imjWJecmEei5aPS232E3Mw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoMax15Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_imjWJ-cmEei5aPS232E3Mw")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; }

    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_imjWK-cmEei5aPS232E3Mw")]
    [DisplayName("Transaction Identification Status")]
    [IsoXmlTag("TxIdSts")]
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; init; }

    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    [IsoId("_imjWLecmEei5aPS232E3Mw")]
    [DisplayName("Protect Transaction Status")]
    [IsoXmlTag("PrtctTxSts")]
    public DTCProtectInstructionStatus3Code? ProtectTransactionStatus { get; init; }

    /// <summary>
    /// Reason for which an inbound instruction message or a cancellation instruction message is rejected.
    /// </summary>
    [IsoId("_imjWL-cmEei5aPS232E3Mw")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<InstructionRejectionReason1Code> RejectionReason { get; init; } = [];

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_imjWN-cmEei5aPS232E3Mw")]
    [DisplayName("Securities Quantity Details")]
    [IsoXmlTag("SctiesQtyDtls")]
    public SecuritiesQuantitySD5? SecuritiesQuantityDetails { get; init; }

    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_imjWP-cmEei5aPS232E3Mw")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; }

    /// <summary>
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    [IsoId("_imjWRecmEei5aPS232E3Mw")]
    [DisplayName("Acknowledgement Details")]
    [IsoXmlTag("AckDtls")]
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; init; }

    /// <summary>
    /// Party contact information for the given instruction; required for voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_imjWQ-cmEei5aPS232E3Mw")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification5? ContactPerson { get; init; }

    /// <summary>
    /// Warrant subscription amount entered by client when instructing on a warrant exercise instruction.
    /// </summary>
    [IsoId("_imjWOecmEei5aPS232E3Mw")]
    [DisplayName("Warrant Subscription Charge Amount")]
    [IsoXmlTag("WarrtSbcptChrgAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; init; }

    /// <summary>
    /// Certificate information for a given instruction.
    /// </summary>
    [IsoId("_imjWPecmEei5aPS232E3Mw")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public CorporateActionCertificateSD1? Certificate { get; init; }

    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_imjWQecmEei5aPS232E3Mw")]
    [DisplayName("User Reference Number")]
    [IsoXmlTag("UsrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public IsoMax6Text? UserReferenceNumber { get; init; }

    /// <summary>
    /// Beneficial owner information related to CD early redemption instructions.
    /// </summary>
    [IsoId("_imjWR-cmEei5aPS232E3Mw")]
    [DisplayName("Deceased Beneficial Owner Details")]
    [IsoXmlTag("DcsdBnfclOwnrDtls")]
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; init; }

    /// <summary>
    /// Transaction record number for ATAM or ART system which may be causing pending status. Corresponds to ATP RBN number.
    /// </summary>
    [IsoId("_imjWSecmEei5aPS232E3Mw")]
    [DisplayName("Transaction Record Number")]
    [IsoXmlTag("TxRcrdNb")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? TransactionRecordNumber { get; init; }
}
