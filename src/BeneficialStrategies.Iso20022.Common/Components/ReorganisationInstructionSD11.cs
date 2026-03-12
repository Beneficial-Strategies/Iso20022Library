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
[IsoId("_pzJNsQ-uEeuE0Pnt-OcNOA")]
[DisplayName("Reorganisation Instruction SD")]
public partial record ReorganisationInstructionSD11
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_qH-OMQ-uEeuE0Pnt-OcNOA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody/reorganisation deposits.
    /// </summary>
    [IsoId("_qH-OMw-uEeuE0Pnt-OcNOA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public IsoMax15Text? TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Enable input of multiple voluntary instructions for rights or voluntary puts events via a single instruction message through using transaction sequence number.
    /// </summary>
    [IsoId("_qH-ONQ-uEeuE0Pnt-OcNOA")]
    [DisplayName("Transaction Sequence")]
    [IsoXmlTag("TxSeq")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<InstructionsTransactionsSequence1> TransactionSequence { get; init; } = new ValueList<InstructionsTransactionsSequence1>(){};
    
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_qH-ONw-uEeuE0Pnt-OcNOA")]
    [DisplayName("Transaction Identification Status")]
    [IsoXmlTag("TxIdSts")]
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; init; } 
    
    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    [IsoId("_qH-OOQ-uEeuE0Pnt-OcNOA")]
    [DisplayName("Protect Transaction Status")]
    [IsoXmlTag("PrtctTxSts")]
    public DTCProtectInstructionStatus3Code? ProtectTransactionStatus { get; init; } 
    
    /// <summary>
    /// Reason for which an inbound instruction message or a cancellation instruction message is pending or rejected.
    /// </summary>
    [IsoId("_qH-OOw-uEeuE0Pnt-OcNOA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<InstructionReason3Code> Reason { get; init; } = new SimpleValueList<InstructionReason3Code>(){};
    
    /// <summary>
    /// Provides further information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_qH-OPQ-uEeuE0Pnt-OcNOA")]
    [DisplayName("Securities Quantity Details")]
    [IsoXmlTag("SctiesQtyDtls")]
    public SecuritiesQuantitySD7? SecuritiesQuantityDetails { get; init; } 
    
    /// <summary>
    /// Customer identification entered by the client upon instruction submission.
    /// </summary>
    [IsoId("_qH-OPw-uEeuE0Pnt-OcNOA")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    
    /// <summary>
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    [IsoId("_qH-OQQ-uEeuE0Pnt-OcNOA")]
    [DisplayName("Acknowledgement Details")]
    [IsoXmlTag("AckDtls")]
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; init; } 
    
    /// <summary>
    /// Party contact information for the given instruction; required for a voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like a cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_qH-OQw-uEeuE0Pnt-OcNOA")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification5? ContactPerson { get; init; } 
    
    /// <summary>
    /// Warrant subscription amount entered by client when instructing on a warrant exercise instruction.
    /// </summary>
    [IsoId("_qH-ORQ-uEeuE0Pnt-OcNOA")]
    [DisplayName("Warrant Subscription Charge Amount")]
    [IsoXmlTag("WarrtSbcptChrgAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; init; } 
    
    /// <summary>
    /// Certificate information for a given instruction.
    /// </summary>
    [IsoId("_qH-ORw-uEeuE0Pnt-OcNOA")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public CorporateActionCertificateSD1? Certificate { get; init; } 
    
    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_qH-OSQ-uEeuE0Pnt-OcNOA")]
    [DisplayName("User Reference Number")]
    [IsoXmlTag("UsrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public IsoMax6Text? UserReferenceNumber { get; init; } 
    
    /// <summary>
    /// Beneficial owner information related to CD early redemption instructions.
    /// </summary>
    [IsoId("_qH-OSw-uEeuE0Pnt-OcNOA")]
    [DisplayName("Deceased Beneficial Owner Details")]
    [IsoXmlTag("DcsdBnfclOwnrDtls")]
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; init; } 
    
    /// <summary>
    /// Transaction record number for ATAM or ART system which may be causing pending status. Corresponds to ATP RBN number.
    /// </summary>
    [IsoId("_qH-OTQ-uEeuE0Pnt-OcNOA")]
    [DisplayName("Transaction Record Number")]
    [IsoXmlTag("TxRcrdNb")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? TransactionRecordNumber { get; init; } 
    
    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_qH-OTw-uEeuE0Pnt-OcNOA")]
    [DisplayName("Bid Price")]
    [IsoXmlTag("BidPric")]
    public PriceFormat63Choice_? BidPrice { get; init; } 
    
    /// <summary>
    /// Reference number assigned to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// </summary>
    [IsoId("_oLALMQ-uEeuE0Pnt-OcNOA")]
    [DisplayName("Shareholder Number")]
    [IsoXmlTag("ShrhldrNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax25Text)]
    [StringLength(maximumLength: 25 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax25Text? ShareholderNumber { get; init; } 
    
    
    #nullable disable
    
}
