// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of a deposit transaction from an ATM.
/// </summary>
[IsoId("_6lj94K39EeWL1uap3dNhCQ")]
[DisplayName("ATM Deposit Request")]
public record ATMDepositRequest1
{
    /// <summary>
    /// Environment in which the transaction is performed.
    /// </summary>
    [IsoId("_HR34cK3-EeWL1uap3dNhCQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment11 Environment { get; init; }

    /// <summary>
    /// Context in which the deposit transaction is performed.
    /// </summary>
    [IsoId("_XZv68K3-EeWL1uap3dNhCQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext10 Context { get; init; }

    /// <summary>
    /// Deposit transaction for which the service is requested.
    /// </summary>
    [IsoId("_1CH4kK3_EeWL1uap3dNhCQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction15 Transaction { get; init; }
}
