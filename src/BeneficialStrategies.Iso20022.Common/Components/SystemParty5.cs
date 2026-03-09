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
[IsoId("_0NEVZYwXEei289CGNqs21g")]
[DisplayName("System Party")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemParty5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party within the system.
    /// </summary>
    [IsoId("_0XDX24wXEei289CGNqs21g")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification9? PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification9? PartyIdentification { get; init; } 
    #else
    public SystemPartyIdentification9? PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    [IsoId("_0XDX34wXEei289CGNqs21g")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress25? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress25? Address { get; init; } 
    #else
    public PostalAddress25? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the options on how to contact the party.
    /// </summary>
    [IsoId("_CiEaI4waEei289CGNqs21g")]
    [DisplayName("Contact Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctDtls")]
    #endif
    [IsoXmlTag("CtctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact5? ContactDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact5? ContactDetails { get; init; } 
    #else
    public Contact5? ContactDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the opening date of the party.
    /// </summary>
    [IsoId("_0XDX0YwXEei289CGNqs21g")]
    [DisplayName("Opening Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngDt")]
    #endif
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OpeningDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OpeningDate { get; init; } 
    #else
    public System.DateOnly? OpeningDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    [IsoId("_0XDX04wXEei289CGNqs21g")]
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
    [IsoId("_0XDX1YwXEei289CGNqs21g")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyType1Choice_? Type { get; init; } 
    #else
    public SystemPartyType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
    /// </summary>
    [IsoId("_0XDX14wXEei289CGNqs21g")]
    [DisplayName("Technical Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechAdr")]
    #endif
    [IsoXmlTag("TechAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TechnicalIdentification2Choice_? TechnicalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TechnicalIdentification2Choice_? TechnicalAddress { get; init; } 
    #else
    public TechnicalIdentification2Choice_? TechnicalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    [IsoId("_0XDX2YwXEei289CGNqs21g")]
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
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_0XDX3YwXEei289CGNqs21g")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyName4? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyName4? Name { get; init; } 
    #else
    public PartyName4? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// </summary>
    [IsoId("_CiEaJIwaEei289CGNqs21g")]
    [DisplayName("Residence Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ResTp")]
    #endif
    [IsoXmlTag("ResTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResidenceType1Code? ResidenceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResidenceType1Code? ResidenceType { get; init; } 
    #else
    public ResidenceType1Code? ResidenceType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the party is locked or not, and the reason for this status, when required.
    /// </summary>
    [IsoId("_CiEaJYwaEei289CGNqs21g")]
    [DisplayName("Lock Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LckSts")]
    #endif
    [IsoXmlTag("LckSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyLockStatus1? LockStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyLockStatus1? LockStatus { get; init; } 
    #else
    public PartyLockStatus1? LockStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_0XDX4YwXEei289CGNqs21g")]
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
