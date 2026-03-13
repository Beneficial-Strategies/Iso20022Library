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
[IsoId("_47gRwTF2EeO118ZQJgaQSQ")]
[DisplayName("Authenticated Data")]
public partial record AuthenticatedData3
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_5MUU8TF2EeO118ZQJgaQSQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Information related to the transport key.
    /// </summary>
    [IsoId("_5MUU8zF2EeO118ZQJgaQSQ")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient3Choice_> Recipient { get; init; } = [];
    // ID for the above is _5MUU8zF2EeO118ZQJgaQSQ
    
    /// <summary>
    /// Algorithm to compute message authentication code (MAC).
    /// </summary>
    [IsoId("_5MUU9TF2EeO118ZQJgaQSQ")]
    [DisplayName("MAC Algorithm")]
    [IsoXmlTag("MACAlgo")]
    public required AlgorithmIdentification10 MACAlgorithm { get; init; } 
    
    /// <summary>
    /// Data to authenticate.
    /// </summary>
    [IsoId("_5MUU9zF2EeO118ZQJgaQSQ")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent2 EncapsulatedContent { get; init; } 
    
    /// <summary>
    /// Encrypted data which authenticates the data.
    /// </summary>
    [IsoId("_5MUU-TF2EeO118ZQJgaQSQ")]
    [DisplayName("MAC")]
    [IsoXmlTag("MAC")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public required IsoMax35Binary MAC { get; init; } 
    
    
    #nullable disable
    
}
