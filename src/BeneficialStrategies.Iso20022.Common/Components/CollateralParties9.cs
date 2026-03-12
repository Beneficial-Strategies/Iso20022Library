// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the chain of collateral parties on the instruction side.
/// </summary>
[IsoId("_YHwsTSs-EeySlt9bF77XfA")]
[DisplayName("Collateral Parties")]
public partial record CollateralParties9
{
    #nullable enable
    
    /// <summary>
    /// Instructing party sending the collateral instruction.
    /// </summary>
    [IsoId("_YgDQdys-EeySlt9bF77XfA")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public PartyIdentificationAndAccount202? PartyA { get; init; } 
    
    /// <summary>
    /// Party that instructs party A to send the message.
    /// </summary>
    [IsoId("_YgDQeSs-EeySlt9bF77XfA")]
    [DisplayName("Client Party A")]
    [IsoXmlTag("ClntPtyA")]
    public PartyIdentificationAndAccount202? ClientPartyA { get; init; } 
    
    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_YgDQeys-EeySlt9bF77XfA")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentification136? TripartyAgent { get; init; } 
    
    
    #nullable disable
    
}
