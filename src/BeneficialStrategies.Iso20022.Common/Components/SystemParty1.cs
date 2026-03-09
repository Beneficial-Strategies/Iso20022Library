// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the definition of a party within a system. 
/// A party shall denote any legal or organisational entity required in the system. 
/// This entity shall store the parties from the first three levels: the system operator, the central securities depositaries, the participants of the central securities depositaries, the national central banks and payment banks.
/// </summary>
[IsoId("_klv_Mu5NEeCisYr99QEiWA_234780156")]
[DisplayName("System Party")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemParty1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemParty1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemParty1( SystemPartyIdentification1 reqIdentification,System.DateOnly reqOpeningDate,SystemPartyType1Code reqType,PartyName1 reqName )
    {
        Identification = reqIdentification;
        OpeningDate = reqOpeningDate;
        Type = reqType;
        Name = reqName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_klv_M-5NEeCisYr99QEiWA_-1745842741")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification1 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyIdentification1 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification1 Identification { get; init; } 
    #else
    public SystemPartyIdentification1 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    [IsoId("_klv_NO5NEeCisYr99QEiWA_-925270798")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress10? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress10? Address { get; init; } 
    #else
    public PostalAddress10? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the opening date of the party.
    /// </summary>
    [IsoId("_kl5JIO5NEeCisYr99QEiWA_462370045")]
    [DisplayName("Opening Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngDt")]
    #endif
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate OpeningDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly OpeningDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly OpeningDate { get; init; } 
    #else
    public System.DateOnly OpeningDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    [IsoId("_kl5JIe5NEeCisYr99QEiWA_624499576")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ClosingDate { get; init; } 
    #else
    public System.DateOnly? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type classification of the party.
    /// </summary>
    [IsoId("_kl5JIu5NEeCisYr99QEiWA_-1396556059")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyType1Code Type { get; init; } 
    #else
    public SystemPartyType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
    /// </summary>
    [IsoId("_kl5JI-5NEeCisYr99QEiWA_-49843880")]
    [DisplayName("Technical Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechAdr")]
    #endif
    [IsoXmlTag("TechAdr")]
    public ValueList<TechnicalIdentification1Choice_> TechnicalAddress { get; init; } = new ValueList<TechnicalIdentification1Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _kl5JI-5NEeCisYr99QEiWA_-49843880
    
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    [IsoId("_kl5JJO5NEeCisYr99QEiWA_1946756214")]
    [DisplayName("Market Specific Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktSpcfcAttr")]
    #endif
    [IsoXmlTag("MktSpcfcAttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
    #else
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_kl5JJe5NEeCisYr99QEiWA_211748246")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyName1 Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyName1 Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyName1 Name { get; init; } 
    #else
    public PartyName1 Name { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_kmC6IO5NEeCisYr99QEiWA_-2987803")]
    [DisplayName("Restriction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rstrctn")]
    #endif
    [IsoXmlTag("Rstrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemRestriction1? Restriction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemRestriction1? Restriction { get; init; } 
    #else
    public SystemRestriction1? Restriction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
