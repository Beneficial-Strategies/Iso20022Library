// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the definition of a party within a system. 
/// A party shall denote any legal or organisational entity required in the system. 
/// This entity shall store the parties from the first three levels: the system operator, the central securities depositaries, the participants of the central securities depositaries, the national central banks and payment banks.
/// </summary>
[IsoId("_klv_Mu5NEeCisYr99QEiWA_234780156")]
[DisplayName("System Party")]
public partial record SystemParty1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_klv_M-5NEeCisYr99QEiWA_-1745842741")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SystemPartyIdentification1 Identification { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    [IsoId("_klv_NO5NEeCisYr99QEiWA_-925270798")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public PostalAddress10? Address { get; init; } 
    
    /// <summary>
    /// Specifies the opening date of the party.
    /// </summary>
    [IsoId("_kl5JIO5NEeCisYr99QEiWA_462370045")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate OpeningDate { get; init; } 
    
    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    [IsoId("_kl5JIe5NEeCisYr99QEiWA_624499576")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClosingDate { get; init; } 
    
    /// <summary>
    /// Specifies the type classification of the party.
    /// </summary>
    [IsoId("_kl5JIu5NEeCisYr99QEiWA_-1396556059")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SystemPartyType1Code Type { get; init; } 
    
    /// <summary>
    /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
    /// </summary>
    [IsoId("_kl5JI-5NEeCisYr99QEiWA_-49843880")]
    [DisplayName("Technical Address")]
    [IsoXmlTag("TechAdr")]
    public ValueList<TechnicalIdentification1Choice_> TechnicalAddress { get; init; } = [];
    // ID for the above is _kl5JI-5NEeCisYr99QEiWA_-49843880
    
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    [IsoId("_kl5JJO5NEeCisYr99QEiWA_1946756214")]
    [DisplayName("Market Specific Attribute")]
    [IsoXmlTag("MktSpcfcAttr")]
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
    
    /// <summary>
    /// Specifies the name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_kl5JJe5NEeCisYr99QEiWA_211748246")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required PartyName1 Name { get; init; } 
    
    /// <summary>
    /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_kmC6IO5NEeCisYr99QEiWA_-2987803")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public SystemRestriction1? Restriction { get; init; } 
    
    
    #nullable disable
    
}
