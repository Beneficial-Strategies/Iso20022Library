// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of document and the type of communication method to be used to notify a party.
/// </summary>
[IsoId("_CJ3zRSFpEeW9XJWqfgXIIA")]
[DisplayName("Document To Send")]
public partial record DocumentToSend3
{
    #nullable enable
    
    /// <summary>
    /// Type of document.
    /// </summary>
    [IsoId("_Cl_ukSFpEeW9XJWqfgXIIA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Type { get; init; } 
    
    /// <summary>
    /// Party that should receive the document.
    /// </summary>
    [IsoId("_Cl_ukyFpEeW9XJWqfgXIIA")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public required PartyIdentification70Choice_ Recipient { get; init; } 
    
    /// <summary>
    /// Communication method to be used.
    /// </summary>
    [IsoId("_Cl_ulSFpEeW9XJWqfgXIIA")]
    [DisplayName("Method Of Transmission")]
    [IsoXmlTag("MtdOfTrnsmssn")]
    public required CommunicationMethod3Choice_ MethodOfTransmission { get; init; } 
    
    
    #nullable disable
    
}
