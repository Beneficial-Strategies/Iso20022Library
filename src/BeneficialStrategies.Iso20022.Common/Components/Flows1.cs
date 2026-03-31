// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payments to and from a concentration bank account of a central counterparty.
/// </summary>
[IsoId("_1Qaz8LIhEeaYqc4G3TTwhA")]
[DisplayName("Flows")]
public record Flows1
{
    /// <summary>
    /// Gross value of flows between the concentration bank account and accounts held at payment banks.
    /// </summary>
    [IsoId("_MPHTABXoEeejf-cbr8l5qw")]
    [DisplayName("Payment Bank Flows")]
    [IsoXmlTag("PmtBkFlows")]
    public required AmountAndDirection102 PaymentBankFlows { get; init; }

    /// <summary>
    /// Gross value of flows between the concentration bank account and investment counterparties in respect of maturing investments and any other flows in / out of the concentration account.
    /// </summary>
    [IsoId("_YT2QMBXoEeejf-cbr8l5qw")]
    [DisplayName("Investment Flows")]
    [IsoXmlTag("InvstmtFlows")]
    public required AmountAndDirection102 InvestmentFlows { get; init; }
}
