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
[IsoId("_3WR4AQ-tEeuE0Pnt-OcNOA")]
[DisplayName("Reorganisation Instruction SD")]
public record ReorganisationInstructionSD10
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_3rjkcQ-tEeuE0Pnt-OcNOA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Identifies the reorganisation transaction type.
    /// </summary>
    [IsoId("_3rjkcw-tEeuE0Pnt-OcNOA")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ReorganisationTransactionType2Code? TransactionType { get; init; }

    /// <summary>
    /// Enable input of multiple voluntary instructions for rights or voluntary puts events via a single instruction message through using Transaction Sequence Number.
    /// </summary>
    [IsoId("_3rjkdQ-tEeuE0Pnt-OcNOA")]
    [DisplayName("Transaction Sequence")]
    [IsoXmlTag("TxSeq")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<InstructionsTransactionsSequence1> TransactionSequence { get; init; } = [];

    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    [IsoId("_3rjkdw-tEeuE0Pnt-OcNOA")]
    [DisplayName("Total Oversubscription Quantity")]
    [IsoXmlTag("TtlOvrsbcptQty")]
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; }

    /// <summary>
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    [IsoId("_3rjkeQ-tEeuE0Pnt-OcNOA")]
    [DisplayName("Acknowledgement Details")]
    [IsoXmlTag("AckDtls")]
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; init; }

    /// <summary>
    /// Party contact information for the given instruction; required for a voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like a cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_3rjkew-tEeuE0Pnt-OcNOA")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification5? ContactPerson { get; init; }

    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_3rjkfQ-tEeuE0Pnt-OcNOA")]
    [DisplayName("User Reference Number")]
    [IsoXmlTag("UsrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public IsoMax6Text? UserReferenceNumber { get; init; }

    /// <summary>
    /// Warrant subscription amount entered by client when instructing on a warrant exercise instruction.
    /// </summary>
    [IsoId("_3rjkfw-tEeuE0Pnt-OcNOA")]
    [DisplayName("Warrant Subscription Charge Amount")]
    [IsoXmlTag("WarrtSbcptChrgAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; init; }

    /// <summary>
    /// Indicates whether the DTC participant is willing to accept penalties as a result of processing instructions prior to maturity of CD redemptions events.
    /// Yes: participant accepts penalties.
    /// No: participant does not accept penalties.
    /// </summary>
    [IsoId("_3rjkgQ-tEeuE0Pnt-OcNOA")]
    [DisplayName("Non Exempt Instructions Allowed Indicator")]
    [IsoXmlTag("NonXmptInstrsAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NonExemptInstructionsAllowedIndicator { get; init; }

    /// <summary>
    /// Certificate information for a given instruction.
    /// </summary>
    [IsoId("_3rjkhQ-tEeuE0Pnt-OcNOA")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public CorporateActionCertificateSD1? Certificate { get; init; }

    /// <summary>
    /// Beneficial owner information related to CD early redemption instructions.
    /// </summary>
    [IsoId("_3rjkhw-tEeuE0Pnt-OcNOA")]
    [DisplayName("Deceased Beneficial Owner Details")]
    [IsoXmlTag("DcsdBnfclOwnrDtls")]
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; init; }
}
