// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM PIN Management from an ATM manager.
/// </summary>
[IsoId("__IPYsa4aEeW_TaP-ygI0SQ")]
[DisplayName("ATMPIN Management Response")]
public record ATMPINManagementResponse2
{
    /// <summary>
    /// Environment of the PIN management transaction.
    /// </summary>
    [IsoId("__S-CAa4aEeW_TaP-ygI0SQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment12 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("__S-CA64aEeW_TaP-ygI0SQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext17 Context { get; init; }

    /// <summary>
    /// Response to the PIN management transaction.
    /// </summary>
    [IsoId("__S-CBa4aEeW_TaP-ygI0SQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction22 Transaction { get; init; }
}
