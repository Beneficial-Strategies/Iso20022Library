// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// KEK9.
/// </summary>
[IsoId("_SLvo8Y-JEe6oobnCtR50kw")]
[DisplayName("KEK9")]
public partial record KEK9
{
    #nullable enable

    /// <summary>
    /// Encrypted Key.
    /// </summary>
    [DisplayName("Encrypted Key")]
    [IsoXmlTag("NcrptdKey")]
    public IsoMax500Binary? EncryptedKey { get; init; } 

    /// <summary>
    /// KEK Identification.
    /// </summary>
    [DisplayName("KEK Identification")]
    [IsoXmlTag("KEKId")]
    public required KEKIdentifier7 KEKIdentification { get; init; } 

    /// <summary>
    /// Key Encryption Algorithm.
    /// </summary>
    [DisplayName("Key Encryption Algorithm")]
    [IsoXmlTag("KeyNcrptnAlgo")]
    public required AlgorithmIdentification32 KeyEncryptionAlgorithm { get; init; } 

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoNumber? Version { get; init; } 

    
    #nullable disable
    
}
