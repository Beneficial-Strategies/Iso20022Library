// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the specific classification or details.
/// </summary>
[IsoId("_0ywmlPJYEeiJn9rM2Znz2w")]
[DisplayName("Additional Characteristic Details")]
public partial record AdditionalCharacteristicDetails1
{
    #nullable enable
    
    /// <summary>
    /// Specific type of business.
    /// </summary>
    [IsoId("_0ywml_JYEeiJn9rM2Znz2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Party that provided the type information.
    /// </summary>
    [IsoId("_0ywmlfJYEeiJn9rM2Znz2w")]
    [DisplayName("Provided By")]
    [IsoXmlTag("PrvddBy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProvidedBy { get; init; } 
    
    
    #nullable disable
    
}
