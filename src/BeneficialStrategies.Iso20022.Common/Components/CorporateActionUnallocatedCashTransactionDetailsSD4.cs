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
[IsoId("_eaSTUZ2IEeW-bsa36JFb9A")]
[DisplayName("Corporate Action Unallocated Cash Transaction Details SD")]
public partial record CorporateActionUnallocatedCashTransactionDetailsSD4
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_expDYZ2IEeW-bsa36JFb9A")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_expDaZ2IEeW-bsa36JFb9A")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public DTCAdjustmentPaymentType3Code? ReasonCode { get; init; } 
    
    /// <summary>
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    [IsoId("_expDcZ2IEeW-bsa36JFb9A")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    
    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    [IsoId("_expDeZ2IEeW-bsa36JFb9A")]
    [DisplayName("Unallocated Reason Code")]
    [IsoXmlTag("UallctdRsnCd")]
    public DTCUnallocatedAdjustmentReason2Code? UnallocatedReasonCode { get; init; } 
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_expDgZ2IEeW-bsa36JFb9A")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_expDiZ2IEeW-bsa36JFb9A")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat28Choice_? EarliestPaymentDate { get; init; } 
    
    
    #nullable disable
    
}
