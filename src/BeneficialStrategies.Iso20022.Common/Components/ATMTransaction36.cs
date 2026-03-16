// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction36.
/// </summary>
[IsoId("_S9Nu8aBFEe-mUP79iiSLcw")]
[DisplayName("ATM Transaction36")]
public record ATMTransaction36
{
    /// <summary>
    /// Reconciliation Operation.
    /// </summary>
    [DisplayName("Reconciliation Operation")]
    [IsoXmlTag("RcncltnOpr")]
    public ValueList<ATMReconciliationOperation1> ReconciliationOperation { get; init; } = [];
}
