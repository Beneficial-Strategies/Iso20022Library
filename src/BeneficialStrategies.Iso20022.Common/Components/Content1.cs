// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of or reference to the content of a message.
/// </summary>
[IsoId("_jrZ20EXWEeegp_DADCe7HQ")]
[DisplayName("Content")]
public partial record Content1
{
    #nullable enable
    
    /// <summary>
    /// Value of the content of or the reference to the message.
    /// </summary>
    [IsoId("_7RCrYEXWEeegp_DADCe7HQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20KText)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public required IsoMax20KText Value { get; init; } 
    
    /// <summary>
    /// Digital signature of the content of or the reference to the message.
    /// </summary>
    [IsoId("_Y50HEEXXEeegp_DADCe7HQ")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? Signature { get; init; } 
    
    /// <summary>
    /// Signing certificate identification.
    /// </summary>
    [IsoId("_lPoNMEXXEeegp_DADCe7HQ")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? CertificateIdentification { get; init; } 
    
    
    #nullable disable
    
}
