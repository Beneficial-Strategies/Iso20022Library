// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Originator of the transaction.
/// </summary>
[IsoId("_V4KakEBeEeepk8PtnyIgsg")]
[DisplayName("Originator")]
public partial record Originator1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the originator of the transaction.
    /// </summary>
    [IsoId("_348_YEBeEeepk8PtnyIgsg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Identification of the entity assigning the originator identification.
    /// </summary>
    [IsoId("_CKXk0EBfEeepk8PtnyIgsg")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; } 
    
    /// <summary>
    /// Country of the originator.
    /// </summary>
    [IsoId("_HskCEEBfEeepk8PtnyIgsg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; } 
    
    /// <summary>
    /// Short name of the originator.
    /// </summary>
    [IsoId("_NhhDQEBfEeepk8PtnyIgsg")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    
    #nullable disable
    
}
