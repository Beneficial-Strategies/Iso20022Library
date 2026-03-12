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
[IsoId("_1XZYcTL3EeKU9IrkkToqcw_-939139358")]
[DisplayName("Corporate Action Confirmation Cash Movement Details SD")]
public partial record CorporateActionConfirmationCashMovementDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1XZYcjL3EeKU9IrkkToqcw_-1052978424")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_1XZYczL3EeKU9IrkkToqcw_-2079845296")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    [IsoId("_1XZYdDL3EeKU9IrkkToqcw_2101282934")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    
    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_1XZYdTL3EeKU9IrkkToqcw_1039930975")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public DTCAdjustmentPaymentType1Code? ReasonCode { get; init; } 
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_1XZYdjL3EeKU9IrkkToqcw_42858622")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    /// <summary>
    /// Date/Time on which the posting /draft of the securities took place.
    /// </summary>
    [IsoId("_1XiiYDL3EeKU9IrkkToqcw_-954213731")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public DateFormat22Choice_? PostingDate { get; init; } 
    
    
    #nullable disable
    
}
