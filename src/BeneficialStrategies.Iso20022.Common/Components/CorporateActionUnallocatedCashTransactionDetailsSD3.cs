// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of unallocated cash transactions.
/// </summary>
[IsoId("_QvF3MaIoEeS6IulNYwkZBg")]
[DisplayName("Corporate Action Unallocated Cash Transaction Details SD")]
public partial record CorporateActionUnallocatedCashTransactionDetailsSD3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_Q5DrgaIoEeS6IulNYwkZBg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_Q5DriaIoEeS6IulNYwkZBg")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public DTCAdjustmentPaymentType1Code? ReasonCode { get; init; } 
    
    /// <summary>
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    [IsoId("_Q5DrkaIoEeS6IulNYwkZBg")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    
    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    [IsoId("_Q5DrmaIoEeS6IulNYwkZBg")]
    [DisplayName("Unallocated Reason Code")]
    [IsoXmlTag("UallctdRsnCd")]
    public DTCUnallocatedAdjustmentReason2Code? UnallocatedReasonCode { get; init; } 
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_Q5DroaIoEeS6IulNYwkZBg")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_Q5DrqaIoEeS6IulNYwkZBg")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat28Choice_? EarliestPaymentDate { get; init; } 
    
    
    #nullable disable
    
}
