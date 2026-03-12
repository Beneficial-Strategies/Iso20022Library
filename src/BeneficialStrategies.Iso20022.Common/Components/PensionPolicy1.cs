// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a pension policy.
/// </summary>
[IsoId("_BNqcEFkOEeiaQoK2-_0KTA")]
[DisplayName("Pension Policy")]
public partial record PensionPolicy1
{
    #nullable enable
    
    /// <summary>
    /// Reference number of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_GWv1wFkOEeiaQoK2-_0KTA")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identifier { get; init; } 
    
    /// <summary>
    /// Sub-identification of the pension policy, plan or scheme, such as a member reference.
    /// </summary>
    [IsoId("_KywuEFkOEeiaQoK2-_0KTA")]
    [DisplayName("Sub Identifier")]
    [IsoXmlTag("SubIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SubIdentifier { get; init; } 
    
    /// <summary>
    /// Additional information about the identification of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_NllbAFkOEeiaQoK2-_0KTA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
