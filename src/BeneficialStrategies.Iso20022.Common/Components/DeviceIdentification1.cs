// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the device.
/// </summary>
[IsoId("_w1Pa4JfLEeuqNYk2TG3bTg")]
[DisplayName("Device Identification")]
public partial record DeviceIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Type of device.
    /// </summary>
    [IsoId("_xVpuYJfNEeuqNYk2TG3bTg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DeviceIdentificationType1Code? Type { get; init; } 
    
    /// <summary>
    /// Other type of identification.
    /// </summary>
    [IsoId("_xtLoIJfOEeuqNYk2TG3bTg")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Identifier of the device.
    /// </summary>
    [IsoId("_3nsewJfOEeuqNYk2TG3bTg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Identification { get; init; } 
    
    /// <summary>
    /// Entity that assigned the identification.
    /// </summary>
    [IsoId("_A1NXMJfPEeuqNYk2TG3bTg")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Assigner { get; init; } 
    
    
    #nullable disable
    
}
