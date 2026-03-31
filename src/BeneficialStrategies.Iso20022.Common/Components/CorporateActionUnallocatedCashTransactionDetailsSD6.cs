// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of unallocated cash transactions.
/// </summary>
[IsoId("_O8s7cMMPEee-Vv_OVx0uAQ")]
[DisplayName("Corporate Action Unallocated Cash Transaction Details SD")]
public record CorporateActionUnallocatedCashTransactionDetailsSD6
{
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_PMUr0cMPEee-Vv_OVx0uAQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_PMd1wcMPEee-Vv_OVx0uAQ")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public DTCAdjustmentPaymentType5Code? ReasonCode { get; init; }

    /// <summary>
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    [IsoId("_PMd1ycMPEee-Vv_OVx0uAQ")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; }

    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    [IsoId("_PMd10cMPEee-Vv_OVx0uAQ")]
    [DisplayName("Unallocated Reason Code")]
    [IsoXmlTag("UallctdRsnCd")]
    public DTCUnallocatedAdjustmentReason4Code? UnallocatedReasonCode { get; init; }

    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_PMd12cMPEee-Vv_OVx0uAQ")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; }

    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_PMd14cMPEee-Vv_OVx0uAQ")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat48Choice_? EarliestPaymentDate { get; init; }
}
