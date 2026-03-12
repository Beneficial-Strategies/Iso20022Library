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
[IsoId("_PzMvMVEIEeyApZmLzm74zA")]
[DisplayName("Data Set Identification")]
public partial record DataSetIdentification9
{
    #nullable enable
    
    /// <summary>
    /// Name of the data set.
    /// </summary>
    [IsoId("_P58QYVEIEeyApZmLzm74zA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Name { get; init; } 
    
    /// <summary>
    /// Category of data set.
    /// </summary>
    [IsoId("_P58QY1EIEeyApZmLzm74zA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DataSetCategory17Code Type { get; init; } 
    
    /// <summary>
    /// Version of the data set.
    /// </summary>
    [IsoId("_P58QZVEIEeyApZmLzm74zA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; } 
    
    /// <summary>
    /// Date and time of creation of the data set.
    /// </summary>
    [IsoId("_P58QZ1EIEeyApZmLzm74zA")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; } 
    
    
    #nullable disable
    
}
