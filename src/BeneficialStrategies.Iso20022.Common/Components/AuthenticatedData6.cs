// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message authentication code (MAC), computed on the data to protect with an encryption key.
/// </summary>
[IsoId("_-jV8EQxpEeqdx6buGpCCQw")]
[DisplayName("Authenticated Data")]
public partial record AuthenticatedData6
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_-uUdAQxpEeqdx6buGpCCQw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Session key or protection key identification used by the recipient.
    /// </summary>
    [IsoId("_-uUdAwxpEeqdx6buGpCCQw")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient8Choice_> Recipient { get; init; } = [];
    // ID for the above is _-uUdAwxpEeqdx6buGpCCQw
    
    /// <summary>
    /// Algorithm to compute message authentication code (MAC).
    /// </summary>
    [IsoId("_-uUdBQxpEeqdx6buGpCCQw")]
    [DisplayName("MAC Algorithm")]
    [IsoXmlTag("MACAlgo")]
    public required AlgorithmIdentification22 MACAlgorithm { get; init; } 
    
    /// <summary>
    /// Data to authenticate.
    /// </summary>
    [IsoId("_-uUdBwxpEeqdx6buGpCCQw")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent3 EncapsulatedContent { get; init; } 
    
    /// <summary>
    /// Message authentication code value.
    /// </summary>
    [IsoId("_-uUdCQxpEeqdx6buGpCCQw")]
    [DisplayName("MAC")]
    [IsoXmlTag("MAC")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public required IsoMax140Binary MAC { get; init; } 
    
    
    #nullable disable
    
}
