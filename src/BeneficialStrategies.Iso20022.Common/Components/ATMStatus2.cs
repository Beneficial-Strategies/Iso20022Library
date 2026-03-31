// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Status2.
/// </summary>
[IsoId("_inj9QZ9bEe-nbM0aSPcoiQ")]
[DisplayName("ATM Status2")]
public record ATMStatus2
{
    /// <summary>
    /// Current Status.
    /// </summary>
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required ATMStatus1Code CurrentStatus { get; init; }

    /// <summary>
    /// Current Status Reason.
    /// </summary>
    [DisplayName("Current Status Reason")]
    [IsoXmlTag("CurStsRsn")]
    public ValueList<IsoMax35Text> CurrentStatusReason { get; init; } = [];

    /// <summary>
    /// Demanded Status.
    /// </summary>
    [DisplayName("Demanded Status")]
    [IsoXmlTag("DmnddSts")]
    public ATMStatus1Code? DemandedStatus { get; init; }
}
