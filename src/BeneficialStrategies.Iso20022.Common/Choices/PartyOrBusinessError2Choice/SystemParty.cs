// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.PartyOrBusinessError2Choice
{
    /// <summary>
    /// Specifications of a party defined within a system.
    /// </summary>
    [IsoId("_e5ses_AzEeWPfa2xBhBfLQ")]
    [DisplayName("System Party")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SystemParty : PartyOrBusinessError2Choice_
    #else
    public partial class SystemParty : PartyOrBusinessError2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the opening date of the party.
        /// </summary>
        [IsoId("_kmMrJO5NEeCisYr99QEiWA_518289586")]
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
        [IsoId("_kmV1EO5NEeCisYr99QEiWA_-478782767")]
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
        [IsoId("_kmV1Ee5NEeCisYr99QEiWA_-1475855120")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemPartyType1Code? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemPartyType1Code? Type { get; init; } 
        #else
        public SystemPartyType1Code? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
        /// </summary>
        [IsoId("_kmV1Eu5NEeCisYr99QEiWA_1822039823")]
        [DisplayName("Technical Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechAdr")]
        #endif
        [IsoXmlTag("TechAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TechnicalIdentification1Choice_? TechnicalAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TechnicalIdentification1Choice_? TechnicalAddress { get; init; } 
        #else
        public TechnicalIdentification1Choice_? TechnicalAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Additional attributes defined by a central security depositary for a party.
        /// </summary>
        [IsoId("_kmV1E-5NEeCisYr99QEiWA_824967470")]
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
        /// Unique and unambiguous way to identify an organisation.
        /// </summary>
        [IsoId("_kmV1FO5NEeCisYr99QEiWA_399330754")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemPartyIdentification1? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemPartyIdentification1? Identification { get; init; } 
        #else
        public SystemPartyIdentification1? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Name by which an organisation is known and which is usually used to identify that organisation.
        /// </summary>
        [IsoId("_kmfmEO5NEeCisYr99QEiWA_-2055026817")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyName3? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyName3? Name { get; init; } 
        #else
        public PartyName3? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Information that locates and identifies a specific address.
        /// </summary>
        [IsoId("_kmfmEe5NEeCisYr99QEiWA_-341683547")]
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
        /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
        /// </summary>
        [IsoId("_kmfmEu5NEeCisYr99QEiWA_-437950738")]
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
}
