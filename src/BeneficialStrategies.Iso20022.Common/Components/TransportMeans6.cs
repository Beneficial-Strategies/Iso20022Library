// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the multimodal or the individual transport of goods.
/// </summary>
[IsoId("_2vnszzckEeSaC-PiOaz_KQ")]
[DisplayName("Transport Means")]
public record TransportMeans6
{
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_3FpAETckEeSaC-PiOaz_KQ")]
    [DisplayName("Individual Transport")]
    [IsoXmlTag("IndvTrnsprt")]
    public required SingleTransport8 IndividualTransport { get; init; }

    /// <summary>
    /// Specifies the different movements and places and their role in a multimodal conveyance of goods.
    /// </summary>
    [IsoId("_3FpAEzckEeSaC-PiOaz_KQ")]
    [DisplayName("Multimodal Transport")]
    [IsoXmlTag("MltmdlTrnsprt")]
    public MultimodalTransport3? MultimodalTransport { get; init; }
}
