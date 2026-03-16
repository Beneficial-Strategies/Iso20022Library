// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes information needed to identify a change in the party related static data, the time when it was performed and the user requesting the change and approving it.
/// </summary>
[IsoId("_HK6rsWjHEeiCUdTMLdZoIg")]
[DisplayName("Party Audit Trail")]
public record PartyAuditTrail1
{
    /// <summary>
    /// Individual record of the party audit trail.
    /// </summary>
    [IsoId("_GLdVoWjOEeiRg5NzP0jkQg")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<UpdateLogPartyRecord1Choice_> Record { get; init; } = [];

    // ID for the above is _GLdVoWjOEeiRg5NzP0jkQg

    /// <summary>
    /// Timestamp of the change.
    /// </summary>
    [IsoId("_HZNmZ2jHEeiCUdTMLdZoIg")]
    [DisplayName("Operation Time Stamp")]
    [IsoXmlTag("OprTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime OperationTimeStamp { get; init; }

    /// <summary>
    /// User who instructed the change.
    /// </summary>
    [IsoId("_HZNmaWjHEeiCUdTMLdZoIg")]
    [DisplayName("Instructing User")]
    [IsoXmlTag("InstgUsr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text InstructingUser { get; init; }

    /// <summary>
    /// User who approved the change instructed by the instructing user.
    /// </summary>
    [IsoId("_HZNma2jHEeiCUdTMLdZoIg")]
    [DisplayName("Approving User")]
    [IsoXmlTag("ApprvgUsr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? ApprovingUser { get; init; }
}
