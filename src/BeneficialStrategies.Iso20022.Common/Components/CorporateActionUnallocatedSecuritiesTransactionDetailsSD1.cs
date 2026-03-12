// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of unallocated securities transactions.
/// </summary>
[IsoId("_1P8FkTL3EeKU9IrkkToqcw_1199159734")]
[DisplayName("Corporate Action Unallocated Securities Transaction Details SD")]
public partial record CorporateActionUnallocatedSecuritiesTransactionDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_1P8FkjL3EeKU9IrkkToqcw_-1863594632")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Resulting quantity of securities concerned in this transaction.
    /// </summary>
    [IsoId("_1P8FkzL3EeKU9IrkkToqcw_-1977433698")]
    [DisplayName("Transaction Quantity")]
    [IsoXmlTag("TxQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    
    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    [IsoId("_1P8FlDL3EeKU9IrkkToqcw_280766213")]
    [DisplayName("Unallocated Reason Code")]
    [IsoXmlTag("UallctdRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText UnallocatedReasonCode { get; init; } 
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_1QF2kDL3EeKU9IrkkToqcw_1320461245")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_1QF2kTL3EeKU9IrkkToqcw_323388892")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat22Choice_? EarliestPaymentDate { get; init; } 
    
    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_1QF2kjL3EeKU9IrkkToqcw_397065")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public DTCAdjustmentPaymentType1Code? ReasonCode { get; init; } 
    
    
    #nullable disable
    
}
