// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Inquiry Request3.
/// </summary>
[IsoId("_JFtQsaEpEe-MRKYsaX6JDg")]
[DisplayName("ATM Inquiry Request3")]
public record ATMInquiryRequest3
{
    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext26 Context { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment17 Environment { get; init; }

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction42 Transaction { get; init; }
}
