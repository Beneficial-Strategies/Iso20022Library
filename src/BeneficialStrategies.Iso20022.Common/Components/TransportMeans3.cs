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
[IsoId("_S5xucAEcEeCQm6a_G2yO_w_-1153183053")]
[DisplayName("Transport Means")]
public record TransportMeans3
{
    /// <summary>
    /// Code specifying the transport mode for the delivery of the consignment, such as by air, sea, rail, road or inland waterway. Reference UN/ECE Recommendation 19 - Code for Modes of Transport (www.unece.org/cefact/recommendations).
    /// </summary>
    [IsoId("_S5xucQEcEeCQm6a_G2yO_w_-629200229")]
    [DisplayName("Mode Code")]
    [IsoXmlTag("MdCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? ModeCode { get; init; }

    /// <summary>
    /// Unique identification of the means of transport, such as the International Maritime Organization number of a vessel.
    /// </summary>
    [IsoId("_S5xucgEcEeCQm6a_G2yO_w_1530122887")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Name, expressed as text, of the means of transport.
    /// </summary>
    [IsoId("_S5xucwEcEeCQm6a_G2yO_w_1574560835")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }
}
