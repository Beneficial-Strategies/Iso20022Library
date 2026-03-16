// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a deposit request.
/// </summary>
[IsoId("_Eg99cK4GEeWL1uap3dNhCQ")]
[DisplayName("ATM Deposit Response")]
public record ATMDepositResponse1
{
    /// <summary>
    /// Environment of the deposit transaction.
    /// </summary>
    [IsoId("_QWvRkK4GEeWL1uap3dNhCQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment12 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_T0ULsK4GEeWL1uap3dNhCQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext11 Context { get; init; }

    /// <summary>
    /// Response to the deposit request.
    /// </summary>
    [IsoId("_y6CGgK4GEeWL1uap3dNhCQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction16 Transaction { get; init; }
}
