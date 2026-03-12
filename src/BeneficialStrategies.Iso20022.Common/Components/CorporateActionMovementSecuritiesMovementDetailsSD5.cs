// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action movement securities movement rate details.
/// </summary>
[IsoId("_uO9Zcb5ZEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Movement Securities Movement Details SD")]
public partial record CorporateActionMovementSecuritiesMovementDetailsSD5
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_uf-Q8b5ZEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_uf-Q875ZEeexmbB7KsjCwA")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    [IsoId("_uf-Q-75ZEeexmbB7KsjCwA")]
    [DisplayName("Payout Type")]
    [IsoXmlTag("PyoutTp")]
    public required DTCCPayoutType4Code PayoutType { get; init; } 
    
    /// <summary>
    /// Resulting quantity of securities concerned in this transaction.
    /// </summary>
    [IsoId("_uf-Q_b5ZEeexmbB7KsjCwA")]
    [DisplayName("Transaction Quantity")]
    [IsoXmlTag("TxQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    
    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_uf-RBb5ZEeexmbB7KsjCwA")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public DTCAdjustmentPaymentType4Code? ReasonCode { get; init; } 
    
    /// <summary>
    /// Transaction sub reason.
    /// </summary>
    [IsoId("_uf-RDb5ZEeexmbB7KsjCwA")]
    [DisplayName("Sub Reason Code")]
    [IsoXmlTag("SubRsnCd")]
    public DTCAdjustmentPaymentSubReason2Code? SubReasonCode { get; init; } 
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_uf-RD75ZEeexmbB7KsjCwA")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    /// <summary>
    /// Date/Time on which the posting / draft of the securities is scheduled to take place for a transaction.
    /// </summary>
    [IsoId("_uf-RF75ZEeexmbB7KsjCwA")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat48Choice_? EarliestPaymentDate { get; init; } 
    
    /// <summary>
    /// Set of the DTC legacy sub reason codes representing tax rate. Used with reason codes ‘TJXD’ ‘TJXF’ ‘TJXI’ ‘TJXL’ ‘TJXR’ ‘TJXT’ ‘TJXU’ to identify the correct tax rate.
    /// </summary>
    [IsoId("_uf-RH75ZEeexmbB7KsjCwA")]
    [DisplayName("Tax Adjustment Rate")]
    [IsoXmlTag("TaxAdjstmntRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxAdjustmentRate { get; init; } 
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_uf-RIb5ZEeexmbB7KsjCwA")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
    
    #nullable disable
    
}
