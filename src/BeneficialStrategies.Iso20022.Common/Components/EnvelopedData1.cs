// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with encryption key.
/// </summary>
[IsoId("_SxR5oQEcEeCQm6a_G2yO_w_-1067166871")]
[DisplayName("Enveloped Data")]
public partial record EnvelopedData1
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_SxR5ogEcEeCQm6a_G2yO_w_-154410220")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Transport key or key encryption key (KEK) identification for the recipient.
    /// </summary>
    [IsoId("_SxR5owEcEeCQm6a_G2yO_w_-1153587356")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient1Choice_> Recipient { get; init; } = [];
    // ID for the above is _SxR5owEcEeCQm6a_G2yO_w_-1153587356
    
    /// <summary>
    /// Encrypted data with an encryption key.
    /// </summary>
    [IsoId("_SxR5pAEcEeCQm6a_G2yO_w_-1162463912")]
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public required EncryptedContent1 EncryptedContent { get; init; } 
    
    
    #nullable disable
    
}
