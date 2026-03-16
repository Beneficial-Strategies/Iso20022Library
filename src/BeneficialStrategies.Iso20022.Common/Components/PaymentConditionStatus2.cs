// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Condition Status2.
/// </summary>
[IsoId("_FJs0oWwLEe6Mn47rYvO6fQ")]
[DisplayName("Payment Condition Status2")]
public record PaymentConditionStatus2
{
    /// <summary>
    /// Accepted Amount.
    /// </summary>
    [DisplayName("Accepted Amount")]
    [IsoXmlTag("AccptdAmt")]
    public ActiveCurrencyAndAmount? AcceptedAmount { get; init; }

    /// <summary>
    /// Early Payment.
    /// </summary>
    [DisplayName("Early Payment")]
    [IsoXmlTag("EarlyPmt")]
    public IsoTrueFalseIndicator? EarlyPayment { get; init; }

    /// <summary>
    /// Guaranteed Payment.
    /// </summary>
    [DisplayName("Guaranteed Payment")]
    [IsoXmlTag("GrntedPmt")]
    public IsoTrueFalseIndicator? GuaranteedPayment { get; init; }
}
