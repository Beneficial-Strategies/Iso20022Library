// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Condition Status2.
/// </summary>
[IsoId("_FJs0oWwLEe6Mn47rYvO6fQ")]
[DisplayName("Payment Condition Status2")]
public partial record PaymentConditionStatus2
{
    #nullable enable

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

    
    #nullable disable
    
}
