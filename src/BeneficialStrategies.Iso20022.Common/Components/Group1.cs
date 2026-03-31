// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of parties with their related security certificate.
/// </summary>
[IsoId("_ruFa0A4WEeKGXqvMN6jpiw")]
[DisplayName("Group")]
public record Group1
{
    /// <summary>
    /// Specifies the identification of the group.
    /// </summary>
    [IsoId("_3WlvAA4WEeKGXqvMN6jpiw")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4AlphaNumericText GroupIdentification { get; init; }

    /// <summary>
    /// Specifies a party and related certificate.
    /// </summary>
    [IsoId("_-SqwUA4WEeKGXqvMN6jpiw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public ValueList<PartyAndCertificate2> Party { get; init; } = [];
    // ID for the above is _-SqwUA4WEeKGXqvMN6jpiw
}
