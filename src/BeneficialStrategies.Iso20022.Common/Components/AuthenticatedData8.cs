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
[IsoId("_N2YjwVE1EeyApZmLzm74zA")]
[DisplayName("Authenticated Data")]
public partial record AuthenticatedData8
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_N83mQVE1EeyApZmLzm74zA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Session key or protection key identification used by the recipient.
    /// </summary>
    [IsoId("_N83mQ1E1EeyApZmLzm74zA")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient11Choice_> Recipient { get; init; } = new ValueList<Recipient11Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _N83mQ1E1EeyApZmLzm74zA
    
    /// <summary>
    /// Algorithm to compute message authentication code (MAC).
    /// </summary>
    [IsoId("_N83mRVE1EeyApZmLzm74zA")]
    [DisplayName("MAC Algorithm")]
    [IsoXmlTag("MACAlgo")]
    public required AlgorithmIdentification22 MACAlgorithm { get; init; } 
    
    /// <summary>
    /// Data to authenticate.
    /// </summary>
    [IsoId("_N83mR1E1EeyApZmLzm74zA")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent3 EncapsulatedContent { get; init; } 
    
    /// <summary>
    /// Message authentication code value.
    /// </summary>
    [IsoId("_N83mSVE1EeyApZmLzm74zA")]
    [DisplayName("MAC")]
    [IsoXmlTag("MAC")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public required IsoMax140Binary MAC { get; init; } 
    
    
    #nullable disable
    
}
