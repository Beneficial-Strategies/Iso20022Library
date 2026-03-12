// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a data set.
/// </summary>
[IsoId("_SwsDxAEcEeCQm6a_G2yO_w_-1490050341")]
[DisplayName("Data Set Identification")]
public partial record DataSetIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Name of the data set.
    /// </summary>
    [IsoId("_SwsDxQEcEeCQm6a_G2yO_w_1933228122")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Name { get; init; } 
    
    /// <summary>
    /// Category of data set.
    /// </summary>
    [IsoId("_SwsDxgEcEeCQm6a_G2yO_w_-1207865813")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DataSetCategory1Code Type { get; init; } 
    
    /// <summary>
    /// Version of the data set.
    /// </summary>
    [IsoId("_SwsDxwEcEeCQm6a_G2yO_w_726066333")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; } 
    
    /// <summary>
    /// Date and time of creation of the data set.
    /// </summary>
    [IsoId("_SwsDyAEcEeCQm6a_G2yO_w_5139566")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    
    #nullable disable
    
}
