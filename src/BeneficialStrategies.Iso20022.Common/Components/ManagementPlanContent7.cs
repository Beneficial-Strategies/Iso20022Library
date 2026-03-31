// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the management plan.
/// </summary>
[IsoId("_TKeAcdqJEeearpaEPXv9UA")]
[DisplayName("Management Plan Content")]
public record ManagementPlanContent7
{
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_TTTMUdqJEeearpaEPXv9UA")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Certificate chain of an asymmetric encryption keys for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_TTTMU9qJEeearpaEPXv9UA")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcphrmntCert")]
    public SimpleValueList<IsoMax10KBinary> KeyEnciphermentCertificate { get; init; } = [];

    /// <summary>
    /// Terminal management action to be performed by the point of interaction (POI).
    /// </summary>
    [IsoId("_TTTMVdqJEeearpaEPXv9UA")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<TMSAction7> Action { get; init; } = [];
    // ID for the above is _TTTMVdqJEeearpaEPXv9UA
}
