// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Notification Location Data1.
/// </summary>
[IsoId("_ZKYSYbkzEe68nbz8Nl_hLQ")]
[DisplayName("Notification Location Data1")]
public record NotificationLocationData1
{
    /// <summary>
    /// Electronic Address.
    /// </summary>
    [DisplayName("Electronic Address")]
    [IsoXmlTag("ElctrncAdr")]
    public IsoMax2048Text? ElectronicAddress { get; init; }

    /// <summary>
    /// Method.
    /// </summary>
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required InvestigationLocationMethod1Code Method { get; init; }

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public NameAndAddress18? PostalAddress { get; init; }
}
