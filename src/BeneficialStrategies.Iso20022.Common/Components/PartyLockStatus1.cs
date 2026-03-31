// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Lock status of the party for processing in the system.
/// </summary>
[IsoId("_JfSv1mjMEeiRg5NzP0jkQg")]
[DisplayName("Party Lock Status")]
public record PartyLockStatus1
{
    /// <summary>
    /// Specifies the date from which the lock status is valid.
    /// </summary>
    [IsoId("_WiPMQGjNEeiRg5NzP0jkQg")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidFrom { get; init; }

    /// <summary>
    /// Lock status of the party.
    /// </summary>
    [IsoId("_JfT982jMEeiRg5NzP0jkQg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required LockStatus1Code Status { get; init; }

    /// <summary>
    /// Specifies the underlying reason for the locking of the party.
    /// </summary>
    [IsoId("_JfT99GjMEeiRg5NzP0jkQg")]
    [DisplayName("Lock Reason")]
    [IsoXmlTag("LckRsn")]
    public SimpleValueList<IsoMax35Text> LockReason { get; init; } = [];
}
