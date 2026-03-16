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
[IsoId("_jVCsN5lPEee-Zps0fZQaFQ")]
[DisplayName("Standing Order")]
public record StandingOrder5
{
    /// <summary>
    /// Amount of money and currency to be transferred when a payment instruction is created as a result of a standing order.
    /// </summary>
    [IsoId("_jdqcs5lPEee-Zps0fZQaFQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public Amount2Choice_? Amount { get; init; }

    /// <summary>
    /// Cash account credited from a standing order mechanism.
    /// </summary>
    [IsoId("_jdqctZlPEee-Zps0fZQaFQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <summary>
    /// Cash account debited from a standing order mechanism.
    /// </summary>
    [IsoId("_jdqct5lPEee-Zps0fZQaFQ")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <summary>
    /// Defines whether the standing order is executed through a time-based or an event-based trigger.
    /// </summary>
    [IsoId("_jdqcuZlPEee-Zps0fZQaFQ")]
    [DisplayName("Execution Type")]
    [IsoXmlTag("ExctnTp")]
    public ExecutionType1Choice_? ExecutionType { get; init; }

    /// <summary>
    /// Regularity with which payment instructions are to be created and processed as a result of the standing order, such as daily, weekly, or monthly.
    /// </summary>
    [IsoId("_jdqcu5lPEee-Zps0fZQaFQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency2Code? Frequency { get; init; }

    /// <summary>
    /// Dates during which the standing order is in effect.
    /// </summary>
    [IsoId("_jdqcvZlPEee-Zps0fZQaFQ")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public DatePeriod2Choice_? ValidityPeriod { get; init; }

    /// <summary>
    /// Indicates whether the standing order is defined as a zero sweeping order. When true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
    /// </summary>
    [IsoId("_jdqcv5lPEee-Zps0fZQaFQ")]
    [DisplayName("Zero Sweep Indicator")]
    [IsoXmlTag("ZeroSweepInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; }
}
