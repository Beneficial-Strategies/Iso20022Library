// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters associated to the MAC algorithm.
/// </summary>
[IsoId("_PrnlsWkJEeS7zPBpvm732w")]
[DisplayName("Parameter")]
public partial record Parameter7
{
    #nullable enable
    
    /// <summary>
    /// Initialisation vector of a cipher block chaining (CBC) mode encryption.
    /// </summary>
    [IsoId("_P4zGEWkJEeS7zPBpvm732w")]
    [DisplayName("Initialisation Vector")]
    [IsoXmlTag("InitlstnVctr")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    public IsoMax500Binary? InitialisationVector { get; init; } 
    
    /// <summary>
    /// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
    /// </summary>
    [IsoId("_fwDSoGkJEeS7zPBpvm732w")]
    [DisplayName("Byte Padding")]
    [IsoXmlTag("BPddg")]
    public BytePadding1Code? BytePadding { get; init; } 
    
    
    #nullable disable
    
}
