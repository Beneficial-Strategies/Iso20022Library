// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action confirmation cash movement details.
/// </summary>
[IsoId("_tUaykb-zEeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Confirmation Cash Movement Details SD")]
public partial record CorporateActionConfirmationCashMovementDetailsSD5
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_tjl3Ab-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_tjl3A7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    [IsoId("_tjl3C7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Payout Type")]
    [IsoXmlTag("PyoutTp")]
    public required DTCCPayoutType5Code PayoutType { get; init; } 
    
    /// <summary>
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    [IsoId("_tjl3Db-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    
    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_tjl3Fb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public DTCAdjustmentPaymentType4Code? ReasonCode { get; init; } 
    
    /// <summary>
    /// Transaction sub reason.
    /// </summary>
    [IsoId("_tjl3Hb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Sub Reason Code")]
    [IsoXmlTag("SubRsnCd")]
    public DTCAdjustmentPaymentSubReason2Code? SubReasonCode { get; init; } 
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_tjl3H7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    /// <summary>
    /// Date/Time on which the posting /draft of the securities took place.
    /// </summary>
    [IsoId("_tjl3J7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public DateFormat48Choice_? PostingDate { get; init; } 
    
    /// <summary>
    /// Set of the DTC legacy sub reason codes representing tax rate. Used with reason codes ‘TJXD’ ‘TJXF’ ‘TJXI’ ‘TJXL’ ‘TJXR’ ‘TJXT’ ‘TJXU’ to identify the correct tax rate.
    /// </summary>
    [IsoId("_tjl3L7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Tax Adjustment Rate")]
    [IsoXmlTag("TaxAdjstmntRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxAdjustmentRate { get; init; } 
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_tjl3Mb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
    /// <summary>
    /// Quantity used on adjustment transactions which when summed across all extension movements equals the relevant balance in the core message. For example, a summation of loan and borrow movements when summed which is negative will show the net total in the borrow balance in the core message. While a summation of loan and borrow movements which is positive will show in the loan balance.
    /// </summary>
    [IsoId("_Gzu5Mb_uEeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Quantity")]
    [IsoXmlTag("TxQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    
    
    #nullable disable
    
}
