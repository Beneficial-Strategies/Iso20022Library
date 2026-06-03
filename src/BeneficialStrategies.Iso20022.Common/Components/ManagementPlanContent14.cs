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
[IsoId("_HNQcQbYFEfCUZfsQO4rYeA")]
[DisplayName("Management Plan Content14")]
public record ManagementPlanContent14
{
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_HORI5bYFEfCUZfsQO4rYeA")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Certificate chain of an asymmetric encryption keys for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_HORI67YFEfCUZfsQO4rYeA")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcphrmntCert")]
    public SimpleValueList<IsoMax10KBinary> KeyEnciphermentCertificate { get; init; } = [];

    /// <summary>
    /// Terminal management action to be performed by the point of interaction (POI).
    /// </summary>
    [IsoId("_HORI8bYFEfCUZfsQO4rYeA")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    [MinLength(1)]
    public ValueList<TMSAction14> Action { get; init; } = [];
}
