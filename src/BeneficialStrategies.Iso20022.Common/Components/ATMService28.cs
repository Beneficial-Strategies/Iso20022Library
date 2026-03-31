// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Service28.
/// </summary>
[IsoId("_Q8vY1-e-Ee-AuZFZ3aE3Cg")]
[DisplayName("ATM Service28")]
public record ATMService28
{
    /// <summary>
    /// Limits.
    /// </summary>
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ValueList<ATMTransactionAmounts6> Limits { get; init; } = [];

    /// <summary>
    /// Preferred Withdrawal.
    /// </summary>
    [DisplayName("Preferred Withdrawal")]
    [IsoXmlTag("PrefrdWdrwl")]
    public ATMTransaction8? PreferredWithdrawal { get; init; }

    /// <summary>
    /// Service Type.
    /// </summary>
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType13Code ServiceType { get; init; }

    /// <summary>
    /// Service Variant.
    /// </summary>
    [DisplayName("Service Variant")]
    [IsoXmlTag("SvcVarnt")]
    public ValueList<ATMService18> ServiceVariant { get; init; } = [];
}
