// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party and its role.
/// </summary>
[IsoId("_kMs9xZQ_EemqYPWMBuVawg")]
[DisplayName("Intermediary")]
public partial record Intermediary46
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_kgCwg5Q_EemqYPWMBuVawg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification177Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_kgCwhZQ_EemqYPWMBuVawg")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_kgCwh5Q_EemqYPWMBuVawg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account32? Account { get; init; } 
    
    /// <summary>
    /// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
    /// </summary>
    [IsoId("_kgCwiZQ_EemqYPWMBuVawg")]
    [DisplayName("Waived Trailer Commission Indicator")]
    [IsoXmlTag("WvdTrlrComssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WaivedTrailerCommissionIndicator { get; init; } 
    
    /// <summary>
    /// Role or function performed by the intermediary.
    /// </summary>
    [IsoId("_kgCwi5Q_EemqYPWMBuVawg")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public PartyRole2Choice_? Role { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_kgCwjZQ_EemqYPWMBuVawg")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress6? PrimaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_kgCwj5Q_EemqYPWMBuVawg")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress6? SecondaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_kgCwkZQ_EemqYPWMBuVawg")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress4? NameAndAddress { get; init; } 
    
    
    #nullable disable
    
}
