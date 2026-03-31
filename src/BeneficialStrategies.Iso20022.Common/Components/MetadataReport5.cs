// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Metadata Report5.
/// </summary>
[IsoId("_JwtpgfgxEe-yU4gaFULAeA")]
[DisplayName("Metadata Report5")]
public record MetadataReport5
{
    /// <summary>
    /// Collection Body.
    /// </summary>
    [DisplayName("Collection Body")]
    [IsoXmlTag("ColltnBody")]
    public GenericIdentification175? CollectionBody { get; init; }

    /// <summary>
    /// Regulatory Data.
    /// </summary>
    [DisplayName("Regulatory Data")]
    [IsoXmlTag("RgltryData")]
    public ValueList<Document28> RegulatoryData { get; init; } = [];

    /// <summary>
    /// Regulatory Data Type.
    /// </summary>
    [DisplayName("Regulatory Data Type")]
    [IsoXmlTag("RgltryDataTp")]
    public ValueList<ClassificationType4> RegulatoryDataType { get; init; } = [];

    /// <summary>
    /// Related Entity.
    /// </summary>
    [DisplayName("Related Entity")]
    [IsoXmlTag("RltdNtty")]
    public ValueList<PartyIdentification260Choice_> RelatedEntity { get; init; } = [];

    /// <summary>
    /// Related Product Identifier.
    /// </summary>
    [DisplayName("Related Product Identifier")]
    [IsoXmlTag("RltdPdctIdr")]
    public ValueList<SecurityIdentification49> RelatedProductIdentifier { get; init; } = [];

    /// <summary>
    /// Submitting Entity.
    /// </summary>
    [DisplayName("Submitting Entity")]
    [IsoXmlTag("SubmitgNtty")]
    public PartyIdentification260Choice_? SubmittingEntity { get; init; }
}
