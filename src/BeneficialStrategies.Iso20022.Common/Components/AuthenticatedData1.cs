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
[IsoId("_SwZI1AEcEeCQm6a_G2yO_w_-35232792")]
[DisplayName("Authenticated Data")]
public partial record AuthenticatedData1
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_SwZI1QEcEeCQm6a_G2yO_w_1890893604")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Information related to the transport key.
    /// </summary>
    [IsoId("_SwZI1gEcEeCQm6a_G2yO_w_-7087131")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient1Choice_> Recipient { get; init; } = new ValueList<Recipient1Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SwZI1gEcEeCQm6a_G2yO_w_-7087131
    
    /// <summary>
    /// Algorithm to compute message authentication code (MAC).
    /// </summary>
    [IsoId("_SwZI1wEcEeCQm6a_G2yO_w_187699920")]
    [DisplayName("MAC Algorithm")]
    [IsoXmlTag("MACAlgo")]
    public required AlgorithmIdentification1 MACAlgorithm { get; init; } 
    
    /// <summary>
    /// Data to authenticate.
    /// </summary>
    [IsoId("_SwZI2AEcEeCQm6a_G2yO_w_1240213777")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    
    /// <summary>
    /// Encrypted data which authenticates the data.
    /// </summary>
    [IsoId("_SwZI2QEcEeCQm6a_G2yO_w_1355241848")]
    [DisplayName("MAC")]
    [IsoXmlTag("MAC")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public required IsoMax35Binary MAC { get; init; } 
    
    
    #nullable disable
    
}
