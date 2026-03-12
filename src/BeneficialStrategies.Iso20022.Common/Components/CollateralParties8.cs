// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of format for the trading capacity.
/// </summary>
[IsoId("_XXfF4Ss-EeySlt9bF77XfA")]
[DisplayName("Collateral Parties")]
public partial record CollateralParties8
{
    #nullable enable
    
    /// <summary>
    /// Instructing party sending the collateral instruction.
    /// </summary>
    [IsoId("_XvU-ISs-EeySlt9bF77XfA")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public required PartyIdentificationAndAccount202 PartyA { get; init; } 
    
    /// <summary>
    /// Party that instructs party A to send the message.
    /// </summary>
    [IsoId("_XvU-Iys-EeySlt9bF77XfA")]
    [DisplayName("Client Party A")]
    [IsoXmlTag("ClntPtyA")]
    public PartyIdentificationAndAccount193? ClientPartyA { get; init; } 
    
    /// <summary>
    /// Counterparty of party A. 
    /// </summary>
    [IsoId("_XvU-JSs-EeySlt9bF77XfA")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentificationAndAccount203 PartyB { get; init; } 
    
    /// <summary>
    /// Party that instructs party B to settle the instruction on its behalf.
    /// </summary>
    [IsoId("_XvU-Jys-EeySlt9bF77XfA")]
    [DisplayName("Client Party B")]
    [IsoXmlTag("ClntPtyB")]
    public PartyIdentificationAndAccount193? ClientPartyB { get; init; } 
    
    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_XvU-KSs-EeySlt9bF77XfA")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentification136? TripartyAgent { get; init; } 
    
    
    #nullable disable
    
}
