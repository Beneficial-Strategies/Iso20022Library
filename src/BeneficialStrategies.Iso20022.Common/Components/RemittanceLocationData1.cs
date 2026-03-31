// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional details on the remittance advice.
/// </summary>
[IsoId("_-LRmB24-EeiU9cctagi5ow")]
[DisplayName("Remittance Location Data")]
public record RemittanceLocationData1
{
    /// <summary>
    /// Method used to deliver the remittance advice information.
    /// </summary>
    [IsoId("_-VaZcW4-EeiU9cctagi5ow")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required RemittanceLocationMethod2Code Method { get; init; }

    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_-VaZc24-EeiU9cctagi5ow")]
    [DisplayName("Electronic Address")]
    [IsoXmlTag("ElctrncAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? ElectronicAddress { get; init; }

    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_-VaZdW4-EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public NameAndAddress16? PostalAddress { get; init; }
}
