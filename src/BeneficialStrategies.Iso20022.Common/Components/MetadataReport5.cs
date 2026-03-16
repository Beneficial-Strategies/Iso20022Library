// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Metadata Report5.
/// </summary>
[IsoId("_JwtpgfgxEe-yU4gaFULAeA")]
[DisplayName("Metadata Report5")]
public partial record MetadataReport5
{
    #nullable enable

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

    
    #nullable disable
    
}
