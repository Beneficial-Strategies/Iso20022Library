// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a record holding the LRCI required data related to a payment file.
/// </summary>
[IsoId("_2UOvYM_aEeWjSMe6YTKHlQ")]
[DisplayName("Isabel LRCI Payment Information")]
public partial record IsabelLRCIPaymentInformation1
{
    #nullable enable
    
    /// <summary>
    /// Arbitrary block of data defined as a fixed-size bit string, the (cryptographic) hash value, which allows the detection of an accidental or intentional change to the visual representation of a particular payment file.
    /// </summary>
    [IsoId("_Bz7F0M_bEeWjSMe6YTKHlQ")]
    [DisplayName("Image Hash")]
    [IsoXmlTag("ImgHash")]
    [IsoSimpleType(IsoSimpleType.Max50Binary)]
    public required IsoMax50Binary ImageHash { get; init; } 
    
    /// <summary>
    /// Arbitrary block of data defined as a fixed-size bit string, the (cryptographic) hash value, which allows the detection of an accidental or intentional change to a particular payment file.
    /// </summary>
    [IsoId("_G9JpcM_bEeWjSMe6YTKHlQ")]
    [DisplayName("Payment Hash")]
    [IsoXmlTag("PmtHash")]
    [IsoSimpleType(IsoSimpleType.Max50Binary)]
    public required IsoMax50Binary PaymentHash { get; init; } 
    
    
    #nullable disable
    
}
