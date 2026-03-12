// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security parameters of the host downloading the key.
/// </summary>
[IsoId("_usm58bTxEeeQy4o2AayYHg")]
[DisplayName("Security Parameters")]
public partial record SecurityParameters10
{
    #nullable enable
    
    /// <summary>
    /// Random value from the host.
    /// </summary>
    [IsoId("_u1uZsbTxEeeQy4o2AayYHg")]
    [DisplayName("Host Challenge")]
    [IsoXmlTag("HstChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? HostChallenge { get; init; } 
    
    /// <summary>
    /// Cryptographic key used to store in the ATM.
    /// </summary>
    [IsoId("_u1uZs7TxEeeQy4o2AayYHg")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public CryptographicKey12? Key { get; init; } 
    
    /// <summary>
    /// Element containing the signature.
    /// </summary>
    [IsoId("_u1uZtbTxEeeQy4o2AayYHg")]
    [DisplayName("Signature Choice")]
    [IsoXmlTag("SgntrChc")]
    public ATMSignature2Choice_? SignatureChoice { get; init; } 
    
    
    #nullable disable
    
}
