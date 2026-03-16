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
[IsoId("_wNfOoRg4EeKnW4lR85q-0A")]
[DisplayName("Group")]
public record Group2
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_aCyRkBg5EeKnW4lR85q-0A")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Specifies the identification of the group.
    /// </summary>
    [IsoId("_wipmVRg4EeKnW4lR85q-0A")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4AlphaNumericText GroupIdentification { get; init; }

    /// <summary>
    /// Specifies a party and related certificate.
    /// </summary>
    [IsoId("_wipmXBg4EeKnW4lR85q-0A")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public ValueList<PartyAndCertificate3> Party { get; init; } = [];
    // ID for the above is _wipmXBg4EeKnW4lR85q-0A
}
