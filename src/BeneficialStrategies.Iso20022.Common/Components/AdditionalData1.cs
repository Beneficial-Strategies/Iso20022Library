// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional data.
/// </summary>
[IsoId("_3GIqg-kFEemeDPHh-U9b6w")]
[DisplayName("Additional Data")]
public partial record AdditionalData1
{
    #nullable enable
    
    /// <summary>
    /// Type of information.
    /// </summary>
    [IsoId("_3GJRkOkFEemeDPHh-U9b6w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Value of a specific type of data.
    /// </summary>
    [IsoId("_3GJRkekFEemeDPHh-U9b6w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? Value { get; init; } 
    
    
    #nullable disable
    
}
