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
[IsoId("_oDfBQecYEei5aPS232E3Mw")]
[DisplayName("Reorganisation Instruction SD")]
public partial record ReorganisationInstructionSD5
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_okNvwecYEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Identifies the reorganisation transaction type.
    /// </summary>
    [IsoId("_okNvw-cYEei5aPS232E3Mw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ReorganisationTransactionType2Code? TransactionType { get; init; } 
    
    /// <summary>
    /// Enable input of multiple voluntary instructions for rights or voluntary puts events via a single instruction message through using Transaction Sequence Number.
    /// </summary>
    [IsoId("_a5hIEOcdEei5aPS232E3Mw")]
    [DisplayName("Transaction Sequence")]
    [IsoXmlTag("TxSeq")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<InstructionsTransactionsSequence1> TransactionSequence { get; init; } = [];
    
    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    [IsoId("_XqkYcecgEei5aPS232E3Mw")]
    [DisplayName("Total Oversubscription Quantity")]
    [IsoXmlTag("TtlOvrsbcptQty")]
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    [IsoId("_okNv4-cYEei5aPS232E3Mw")]
    [DisplayName("Acknowledgement Details")]
    [IsoXmlTag("AckDtls")]
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; init; } 
    
    /// <summary>
    /// Party contact information for the given instruction; required for voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_okNv4ecYEei5aPS232E3Mw")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification5? ContactPerson { get; init; } 
    
    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_okNv3-cYEei5aPS232E3Mw")]
    [DisplayName("User Reference Number")]
    [IsoXmlTag("UsrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public IsoMax6Text? UserReferenceNumber { get; init; } 
    
    /// <summary>
    /// Warrant subscription amount entered by client when instructing on a warrant exercise instruction.
    /// </summary>
    [IsoId("_okNv0-cYEei5aPS232E3Mw")]
    [DisplayName("Warrant Subscription Charge Amount")]
    [IsoXmlTag("WarrtSbcptChrgAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether DTC participant is willing to accept penalties as a result of processing instructions prior to maturity of CD redemptions events.
    /// Yes: participant accepts penalties.
    /// No: participant does not accept penalties.
    /// </summary>
    [IsoId("_okNv1ecYEei5aPS232E3Mw")]
    [DisplayName("Non Exempt Instructions Allowed Indicator")]
    [IsoXmlTag("NonXmptInstrsAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NonExemptInstructionsAllowedIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid soliciting dealer.
    /// Yes: there is a solicitation fee.
    /// No: there is not a solicitation fee.
    /// </summary>
    [IsoId("_okNv1-cYEei5aPS232E3Mw")]
    [DisplayName("Solicitation Fee Indicator")]
    [IsoXmlTag("SlctnFeeInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SolicitationFeeIndicator { get; init; } 
    
    /// <summary>
    /// Certificate information for a given instruction.
    /// </summary>
    [IsoId("_okNv2-cYEei5aPS232E3Mw")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public CorporateActionCertificateSD1? Certificate { get; init; } 
    
    /// <summary>
    /// Beneficial owner information related to CD early redemption instructions.
    /// </summary>
    [IsoId("_okNv5ecYEei5aPS232E3Mw")]
    [DisplayName("Deceased Beneficial Owner Details")]
    [IsoXmlTag("DcsdBnfclOwnrDtls")]
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; init; } 
    
    
    #nullable disable
    
}
