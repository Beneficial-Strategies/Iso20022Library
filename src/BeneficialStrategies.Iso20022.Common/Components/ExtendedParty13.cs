// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other type of party.
/// </summary>
[IsoId("_MOiloWALEeiNMJ262H2pWg")]
[DisplayName("Extended Party")]
public partial record ExtendedParty13
{
    #nullable enable
    
    /// <summary>
    /// Role of the party.
    /// </summary>
    [IsoId("_Mema4WALEeiNMJ262H2pWg")]
    [DisplayName("Party Role")]
    [IsoXmlTag("PtyRole")]
    public required GenericIdentification36 PartyRole { get; init; } 
    
    /// <summary>
    /// Identification and communication information about the party.
    /// </summary>
    [IsoId("_Mema42ALEeiNMJ262H2pWg")]
    [DisplayName("Other Party Details")]
    [IsoXmlTag("OthrPtyDtls")]
    public required ContactAttributes5 OtherPartyDetails { get; init; } 
    
    
    #nullable disable
    
}
