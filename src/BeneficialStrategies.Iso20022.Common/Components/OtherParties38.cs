// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other business parties relevant to the transaction/Instruction
/// </summary>
[IsoId("_Ga5BAMIsEei34K_Q744LyA")]
[DisplayName("Other Parties")]
public partial record OtherParties38
{
    #nullable enable
    
    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_uHNv0MItEei34K_Q744LyA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification136? Issuer { get; init; } 
    
    /// <summary>
    /// Instructing party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_h8RAcMIuEei34K_Q744LyA")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification149? Investor { get; init; } 
    
    
    #nullable disable
    
}
