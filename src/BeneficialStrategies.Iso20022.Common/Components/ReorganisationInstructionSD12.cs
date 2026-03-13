// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action reorganisation instruction details.
/// </summary>
[IsoId("_oFasoTDtEey2N-DB7H7A5A")]
[DisplayName("Reorganisation Instruction SD")]
public partial record ReorganisationInstructionSD12
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_ocESETDtEey2N-DB7H7A5A")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody/reorganisation deposits.
    /// </summary>
    [IsoId("_ocESEzDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public IsoMax15Text? TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Enable input of multiple voluntary instructions for rights or voluntary puts events via a single instruction message through using transaction sequence number.
    /// </summary>
    [IsoId("_ocESFTDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Sequence")]
    [IsoXmlTag("TxSeq")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<InstructionsTransactionsSequence2> TransactionSequence { get; init; } = [];
    
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_ocESFzDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Identification Status")]
    [IsoXmlTag("TxIdSts")]
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; init; } 
    
    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    [IsoId("_ocESGTDtEey2N-DB7H7A5A")]
    [DisplayName("Protect Transaction Status")]
    [IsoXmlTag("PrtctTxSts")]
    public DTCProtectInstructionStatus3Code? ProtectTransactionStatus { get; init; } 
    
    /// <summary>
    /// Reason for which an inbound instruction message or a cancellation instruction message is pending or rejected.
    /// </summary>
    [IsoId("_ocESGzDtEey2N-DB7H7A5A")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<InstructionReason4Code> Reason { get; init; } = [];
    
    /// <summary>
    /// Provides further information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_ocESHTDtEey2N-DB7H7A5A")]
    [DisplayName("Securities Quantity Details")]
    [IsoXmlTag("SctiesQtyDtls")]
    public SecuritiesQuantitySD9? SecuritiesQuantityDetails { get; init; } 
    
    /// <summary>
    /// Customer identification entered by the client upon instruction submission.
    /// </summary>
    [IsoId("_ocESHzDtEey2N-DB7H7A5A")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    
    /// <summary>
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    [IsoId("_ocESITDtEey2N-DB7H7A5A")]
    [DisplayName("Acknowledgement Details")]
    [IsoXmlTag("AckDtls")]
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; init; } 
    
    /// <summary>
    /// Party contact information for the given instruction; required for a voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like a cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_ocESIzDtEey2N-DB7H7A5A")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification5? ContactPerson { get; init; } 
    
    /// <summary>
    /// Warrant subscription amount entered by client when instructing on a warrant exercise instruction.
    /// </summary>
    [IsoId("_ocESJTDtEey2N-DB7H7A5A")]
    [DisplayName("Warrant Subscription Charge Amount")]
    [IsoXmlTag("WarrtSbcptChrgAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; init; } 
    
    /// <summary>
    /// Certificate information for a given instruction.
    /// </summary>
    [IsoId("_ocESJzDtEey2N-DB7H7A5A")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public CorporateActionCertificateSD1? Certificate { get; init; } 
    
    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_ocESKTDtEey2N-DB7H7A5A")]
    [DisplayName("User Reference Number")]
    [IsoXmlTag("UsrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public IsoMax6Text? UserReferenceNumber { get; init; } 
    
    /// <summary>
    /// Beneficial owner information related to CD early redemption instructions.
    /// </summary>
    [IsoId("_ocESKzDtEey2N-DB7H7A5A")]
    [DisplayName("Deceased Beneficial Owner Details")]
    [IsoXmlTag("DcsdBnfclOwnrDtls")]
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; init; } 
    
    /// <summary>
    /// Transaction record number for ATAM or ART system which may be causing pending status. Corresponds to ATP RBN number.
    /// </summary>
    [IsoId("_ocESLTDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Record Number")]
    [IsoXmlTag("TxRcrdNb")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? TransactionRecordNumber { get; init; } 
    
    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_ocESLzDtEey2N-DB7H7A5A")]
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat63Choice_? BidPrice { get; init; } 
    
    /// <summary>
    /// Reference number assigned to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// </summary>
    [IsoId("_ocESMTDtEey2N-DB7H7A5A")]
    [DisplayName("Shareholder Number")]
    [IsoXmlTag("ShrhldrNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax25Text)]
    [StringLength(maximumLength: 25 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax25Text? ShareholderNumber { get; init; } 
    
    
    #nullable disable
    
}
