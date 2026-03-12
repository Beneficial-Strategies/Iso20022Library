// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of the transaction, that is the underlying payment instruction or statement entry.
/// </summary>
[IsoId("_R-PXcdLnEeSDLevdaFPXHw")]
[DisplayName("Certificate Reference")]
public partial record CertificateReference1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the underlying payment instruction or statement entry.
    /// </summary>
    [IsoId("_ehnYcNLnEeSDLevdaFPXHw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required CertificateIdentification1 Identification { get; init; } 
    
    /// <summary>
    /// Date of the underlying payment instruction or statement entry.
    /// </summary>
    [IsoId("_iisoQNLnEeSDLevdaFPXHw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; } 
    
    
    #nullable disable
    
}
