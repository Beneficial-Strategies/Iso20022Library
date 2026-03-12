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
[IsoId("_TaKpkQioEeKn9O5oyej_zw")]
[DisplayName("Authenticated Data")]
public partial record AuthenticatedData2
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_TmgccQioEeKn9O5oyej_zw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Information related to the transport key.
    /// </summary>
    [IsoId("_TmgcdQioEeKn9O5oyej_zw")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient2Choice_> Recipient { get; init; } = new ValueList<Recipient2Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _TmgcdQioEeKn9O5oyej_zw
    
    /// <summary>
    /// Algorithm to compute message authentication code (MAC).
    /// </summary>
    [IsoId("_TmgceQioEeKn9O5oyej_zw")]
    [DisplayName("MAC Algorithm")]
    [IsoXmlTag("MACAlgo")]
    public required AlgorithmIdentification3 MACAlgorithm { get; init; } 
    
    /// <summary>
    /// Data to authenticate.
    /// </summary>
    [IsoId("_TmgcfQioEeKn9O5oyej_zw")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    
    /// <summary>
    /// Encrypted data which authenticates the data.
    /// </summary>
    [IsoId("_TmgcgQioEeKn9O5oyej_zw")]
    [DisplayName("MAC")]
    [IsoXmlTag("MAC")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public required IsoMax35Binary MAC { get; init; } 
    
    
    #nullable disable
    
}
