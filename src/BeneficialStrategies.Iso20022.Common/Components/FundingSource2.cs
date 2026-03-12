// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Source of funding
/// </summary>
[IsoId("_xJXl8EUUEeea-M6VZkEPUw")]
[DisplayName("Funding Source")]
public partial record FundingSource2
{
    #nullable enable
    
    /// <summary>
    /// Type of source funding used to perform the transfer of funds.
    /// </summary>
    [IsoId("_GpSEIEUVEeea-M6VZkEPUw")]
    [DisplayName("Source Type")]
    [IsoXmlTag("SrcTp")]
    public FundingSourceType2Code? SourceType { get; init; } 
    
    /// <summary>
    /// Any other type of funding source used to perform the transfer of funds.
    /// </summary>
    [IsoId("_21b7cEUVEeea-M6VZkEPUw")]
    [DisplayName("Other Source Type")]
    [IsoXmlTag("OthrSrcTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherSourceType { get; init; } 
    
    /// <summary>
    /// Reference to the funding source.
    /// </summary>
    [IsoId("_8T0PsEUVEeea-M6VZkEPUw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; } 
    
    
    #nullable disable
    
}
