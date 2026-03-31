// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Deposit Request2.
/// </summary>
[IsoId("_3zcEYaE4Ee-MRKYsaX6JDg")]
[DisplayName("ATM Deposit Request2")]
public record ATMDepositRequest2
{
    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext10 Context { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment18 Environment { get; init; }

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction50 Transaction { get; init; }
}
