// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of transportation carrier.
/// </summary>
[IsoId("_P8RACPQFEeihCvvpsmGI2w")]
[DisplayName("Carrier Identification")]
public record CarrierIdentification1
{
    /// <summary>
    /// Name of the transportation carrier.
    /// </summary>
    [IsoId("_P8RADPQFEeihCvvpsmGI2w")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Identifies the operator (company providing service).
    /// </summary>
    [IsoId("_P8RADvQFEeihCvvpsmGI2w")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Code { get; init; }

    /// <summary>
    /// Contains the International Air Transport Association (IATA) code identifying the company that purchased the ticket.
    /// </summary>
    [IsoId("_P8RADfQFEeihCvvpsmGI2w")]
    [DisplayName("IATA Code")]
    [IsoXmlTag("IATACd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IATACode { get; init; }
}
