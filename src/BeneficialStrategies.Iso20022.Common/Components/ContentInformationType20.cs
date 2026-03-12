// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing encrypted data.
/// </summary>
[IsoId("_fP-osaQuEeeWXKXf3KjtmQ")]
[DisplayName("Content Information Type")]
public partial record ContentInformationType20
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// ISO 8583:87 bit 53 or 110
    /// ISO 8583:93 bit 53 or 111
    /// ISO 8583:2003 bit 53 or 50
    /// </summary>
    [IsoId("_fblbwaQuEeeWXKXf3KjtmQ")]
    [DisplayName("MAC Data")]
    [IsoXmlTag("MACData")]
    public required MACData1 MACData { get; init; } 
    
    /// <summary>
    /// Message Authentication Code data.
    /// Binary, length of 8
    /// ISO 8583 bit 64 or bit 128
    /// </summary>
    [IsoId("_fblbw6QuEeeWXKXf3KjtmQ")]
    [DisplayName("MAC")]
    [IsoXmlTag("MAC")]
    [IsoSimpleType(IsoSimpleType.Max8HexBinaryText)]
    public required IsoMax8HexBinaryText MAC { get; init; } 
    
    
    #nullable disable
    
}
