// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters for physical interface.
/// </summary>
[IsoId("_jVcYQNqfEeearpaEPXv9UA")]
[DisplayName("Physical Interface Parameter")]
public partial record PhysicalInterfaceParameter1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the interface.
    /// </summary>
    [IsoId("_-ROCMNqfEeearpaEPXv9UA")]
    [DisplayName("Interface Name")]
    [IsoXmlTag("IntrfcNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text InterfaceName { get; init; } 
    
    /// <summary>
    /// Identification of the physical link layer.
    /// </summary>
    [IsoId("_IBxWQNqgEeearpaEPXv9UA")]
    [DisplayName("Interface Type")]
    [IsoXmlTag("IntrfcTp")]
    public POICommunicationType2Code? InterfaceType { get; init; } 
    
    /// <summary>
    /// Optional user name to provide to use this interface.
    /// </summary>
    [IsoId("_SCt2wNqgEeearpaEPXv9UA")]
    [DisplayName("User Name")]
    [IsoXmlTag("UsrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? UserName { get; init; } 
    
    /// <summary>
    /// Optional access code to provide to use this interface.
    /// </summary>
    [IsoId("_ZFeH0NqgEeearpaEPXv9UA")]
    [DisplayName("Access Code")]
    [IsoXmlTag("AccsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? AccessCode { get; init; } 
    
    /// <summary>
    /// Identification of the optional security profile to use with this interface.
    /// </summary>
    [IsoId("_f-XSQNqgEeearpaEPXv9UA")]
    [DisplayName("Security Profile")]
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecurityProfile { get; init; } 
    
    /// <summary>
    /// Any other parameters relevant for this interface.
    /// </summary>
    [IsoId("_qB5zwNqgEeearpaEPXv9UA")]
    [DisplayName("Additional Parameters")]
    [IsoXmlTag("AddtlParams")]
    [IsoSimpleType(IsoSimpleType.Max2KBinary)]
    public IsoMax2KBinary? AdditionalParameters { get; init; } 
    
    
    #nullable disable
    
}
