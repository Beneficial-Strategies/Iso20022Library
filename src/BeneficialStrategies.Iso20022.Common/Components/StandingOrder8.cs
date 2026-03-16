// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// New standing order values.
/// </summary>
[IsoId("_eQ74wdcZEeqRFcf2R4bPBw")]
[DisplayName("Standing Order")]
public record StandingOrder8
{
    /// <summary>
    /// Amount of money and currency to be transferred when a payment instruction is created as a result of a standing order.
    /// </summary>
    [IsoId("_eSQucdcZEeqRFcf2R4bPBw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public Amount2Choice_? Amount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_eSQuc9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public BranchAndFinancialInstitutionIdentification6? Creditor { get; init; }

    /// <summary>
    /// Cash account credited from a standing order mechanism.
    /// </summary>
    [IsoId("_eSQuddcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_eSQud9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public BranchAndFinancialInstitutionIdentification6? Debtor { get; init; }

    /// <summary>
    /// Cash account debited from a standing order mechanism.
    /// </summary>
    [IsoId("_eSQuedcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Defines whether the standing order is executed through a time-based or an event-based trigger.
    /// </summary>
    [IsoId("_eSQue9cZEeqRFcf2R4bPBw")]
    [DisplayName("Execution Type")]
    [IsoXmlTag("ExctnTp")]
    public ExecutionType1Choice_? ExecutionType { get; init; }

    /// <summary>
    /// Regularity with which payment instructions are to be created and processed as a result of the standing order, such as daily, weekly, or monthly.
    /// </summary>
    [IsoId("_eSQufdcZEeqRFcf2R4bPBw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency2Code? Frequency { get; init; }

    /// <summary>
    /// Dates during which the standing order is in effect.
    /// </summary>
    [IsoId("_eSQuf9cZEeqRFcf2R4bPBw")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public DatePeriod2Choice_? ValidityPeriod { get; init; }

    /// <summary>
    /// Indicates whether the standing order is defined as a zero sweeping order. When true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
    /// </summary>
    [IsoId("_eSQugdcZEeqRFcf2R4bPBw")]
    [DisplayName("Zero Sweep Indicator")]
    [IsoXmlTag("ZeroSweepInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; }
}
