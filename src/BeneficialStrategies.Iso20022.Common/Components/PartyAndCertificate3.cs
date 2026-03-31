// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and related security certificate.
/// </summary>
[IsoId("_RpGNURg6EeKnW4lR85q-0A")]
[DisplayName("Party And Certificate")]
public record PartyAndCertificate3
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_WgjEcBg6EeKnW4lR85q-0A")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_R-Zu9Rg6EeKnW4lR85q-0A")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification43 Party { get; init; }

    /// <summary>
    /// Security certificate used to sign electronically.
    /// </summary>
    [IsoId("_R-Zu_Bg6EeKnW4lR85q-0A")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? Certificate { get; init; }
}
