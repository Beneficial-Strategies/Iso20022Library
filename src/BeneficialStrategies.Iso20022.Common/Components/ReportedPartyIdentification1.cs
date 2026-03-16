// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the identification of the reported party through the location and the name or the sector.
/// </summary>
[IsoId("_v6TEUYInEeWA9fc11zJf1Q")]
[DisplayName("Reported Party Identification")]
public record ReportedPartyIdentification1
{
    /// <summary>
    /// Name or sector of the counterparty of the reporting agent used by the reporting agent.
    /// </summary>
    [IsoId("_ZqzG0YIoEeWA9fc11zJf1Q")]
    [DisplayName("Name Or Sector")]
    [IsoXmlTag("NmOrSctr")]
    public required NameOrSector1Choice_ NameOrSector { get; init; }

    /// <summary>
    /// Location of the country in which the counterparty is incorporated.
    /// </summary>
    [IsoId("_wDEl04InEeWA9fc11zJf1Q")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public required CountryCode Location { get; init; }
}
