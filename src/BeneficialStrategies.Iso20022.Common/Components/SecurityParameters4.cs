// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security parameters of the ATM for the initiated key download.
/// </summary>
[IsoId("_Q3BKYYtOEeSxlKlAGYErFg")]
[DisplayName("Security Parameters")]
public partial record SecurityParameters4
{
    #nullable enable
    
    /// <summary>
    /// Cryptographic key used to protect the key download.
    /// </summary>
    [IsoId("_RDh8Z4tOEeSxlKlAGYErFg")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public CryptographicKey8? Key { get; init; } 
    
    /// <summary>
    /// Digital signature of implicit data depending on the security scheme download procedure.
    /// </summary>
    [IsoId("_3ilm0ItPEeSxlKlAGYErFg")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public ContentInformationType14? DigitalSignature { get; init; } 
    
    /// <summary>
    /// Ordered certificate chain of the asymmetric key encryption key, starting with the ATM certificate.
    /// </summary>
    [IsoId("_9DOk4ItPEeSxlKlAGYErFg")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? Certificate { get; init; } 
    
    /// <summary>
    /// Random value from the ATM to avoid message replay.
    /// </summary>
    [IsoId("_RDh8Y4tOEeSxlKlAGYErFg")]
    [DisplayName("ATM Challenge")]
    [IsoXmlTag("ATMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? ATMChallenge { get; init; } 
    
    /// <summary>
    /// Requested key for downloading, depending on the key hierarchy used by the host.
    /// </summary>
    [IsoId("_GS9D0ItQEeSxlKlAGYErFg")]
    [DisplayName("Requested Key")]
    [IsoXmlTag("ReqdKey")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RequestedKey { get; init; } 
    
    
    #nullable disable
    
}
