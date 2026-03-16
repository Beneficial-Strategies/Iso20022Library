// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Natural Person Identification5.
/// </summary>
[IsoId("_XYzn8eIZEe-eFYnrXcX-mQ")]
[DisplayName("Natural Person Identification5")]
public partial record NaturalPersonIdentification5
{
    #nullable enable

    /// <summary>
    /// Alternate Identification.
    /// </summary>
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public GenericIdentification175? AlternateIdentification { get; init; } 

    /// <summary>
    /// Entity Size.
    /// </summary>
    [DisplayName("Entity Size")]
    [IsoXmlTag("NttySz")]
    public ExternalEntitySize1Code? EntitySize { get; init; } 

    /// <summary>
    /// Entity Type.
    /// </summary>
    [DisplayName("Entity Type")]
    [IsoXmlTag("NttyTp")]
    public ExternalEntityType1Code? EntityType { get; init; } 

    /// <summary>
    /// NPI.
    /// </summary>
    [DisplayName("NPI")]
    [IsoXmlTag("NPI")]
    public IsoNPIIdentifier? NPI { get; init; } 

    /// <summary>
    /// Person Name.
    /// </summary>
    [DisplayName("Person Name")]
    [IsoXmlTag("PrsnNm")]
    public ValueList<IsoMax500Text> PersonName { get; init; } = [];

    /// <summary>
    /// Sector.
    /// </summary>
    [DisplayName("Sector")]
    [IsoXmlTag("Sctr")]
    public ValueList<IndustrySector3Choice_> Sector { get; init; } = [];

    
    #nullable disable
    
}
