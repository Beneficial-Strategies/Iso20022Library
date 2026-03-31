// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of unallocated securities transactions.
/// </summary>
[IsoId("_t5zBfQ-rEeuE0Pnt-OcNOA")]
[DisplayName("Corporate Action Unallocated Securities Transaction Details SD")]
public record CorporateActionUnallocatedSecuritiesTransactionDetailsSD8
{
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_uPhZwQ-rEeuE0Pnt-OcNOA")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Number identifying the available corporate action option.
    /// </summary>
    [IsoId("__oge1A-rEeuE0Pnt-OcNOA")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action option available to the account owner.
    /// </summary>
    [IsoId("_UHqqpA-sEeuE0Pnt-OcNOA")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public CorporateActionOption11Code? OptionType { get; init; }

    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_uPhZyQ-rEeuE0Pnt-OcNOA")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public DTCAdjustmentPaymentType5Code? ReasonCode { get; init; }

    /// <summary>
    /// Resulting quantity of securities concerned in this transaction.
    /// </summary>
    [IsoId("_uPhZ0Q-rEeuE0Pnt-OcNOA")]
    [DisplayName("Transaction Quantity")]
    [IsoXmlTag("TxQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; }

    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    [IsoId("_uPhZ2Q-rEeuE0Pnt-OcNOA")]
    [DisplayName("Unallocated Reason Code")]
    [IsoXmlTag("UallctdRsnCd")]
    public DTCUnallocatedAdjustmentReason4Code? UnallocatedReasonCode { get; init; }

    /// <summary>
    /// Transaction contra participant identification when shares are distributed/delivered to/from another participant.
    /// </summary>
    [IsoId("_uPhZ4Q-rEeuE0Pnt-OcNOA")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; }

    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_uPhZ6Q-rEeuE0Pnt-OcNOA")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat48Choice_? EarliestPaymentDate { get; init; }
}
