// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the customer device.
/// </summary>
[IsoId("_c9QGQEamEeeIjf8aP9KbJA")]
[DisplayName("Customer Device")]
public record CustomerDevice2
{
    /// <summary>
    /// Information about the customer device.
    /// </summary>
    [IsoId("_O5EkYEanEeeIjf8aP9KbJA")]
    [DisplayName("Device")]
    [IsoXmlTag("Dvc")]
    public Device1? Device { get; init; }

    /// <summary>
    /// Identification of the customer device.
    /// </summary>
    [IsoId("_WqOMgEanEeeIjf8aP9KbJA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Identification { get; init; }

    /// <summary>
    /// Provider of the customer device.
    /// </summary>
    [IsoId("_eNRHMEanEeeIjf8aP9KbJA")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; }
}
