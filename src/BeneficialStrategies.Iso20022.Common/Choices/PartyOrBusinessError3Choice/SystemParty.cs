// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyOrBusinessError3Choice
{
    /// <summary>
    /// Specifications of a party defined within a system.
    /// </summary>
    [IsoId("_0NEVY4wXEei289CGNqs21g")]
    [DisplayName("System Party")]
    public partial record SystemParty : PartyOrBusinessError3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identification of the party within the system.
        /// </summary>
        [IsoId("_0XDX24wXEei289CGNqs21g")]
        [DisplayName("Party Identification")]
        [IsoXmlTag("PtyId")]
        public SystemPartyIdentification9? PartyIdentification { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address.
        /// </summary>
        [IsoId("_0XDX34wXEei289CGNqs21g")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public PostalAddress25? Address { get; init; } 
        
        /// <summary>
        /// Specifies the options on how to contact the party.
        /// </summary>
        [IsoId("_CiEaI4waEei289CGNqs21g")]
        [DisplayName("Contact Details")]
        [IsoXmlTag("CtctDtls")]
        public Contact5? ContactDetails { get; init; } 
        
        /// <summary>
        /// Specifies the opening date of the party.
        /// </summary>
        [IsoId("_0XDX0YwXEei289CGNqs21g")]
        [DisplayName("Opening Date")]
        [IsoXmlTag("OpngDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? OpeningDate { get; init; } 
        
        /// <summary>
        /// Specifies the closing date of the party.
        /// </summary>
        [IsoId("_0XDX04wXEei289CGNqs21g")]
        [DisplayName("Closing Date")]
        [IsoXmlTag("ClsgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ClosingDate { get; init; } 
        
        /// <summary>
        /// Specifies the type classification of the party.
        /// </summary>
        [IsoId("_0XDX1YwXEei289CGNqs21g")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public SystemPartyType1Choice_? Type { get; init; } 
        
        /// <summary>
        /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
        /// </summary>
        [IsoId("_0XDX14wXEei289CGNqs21g")]
        [DisplayName("Technical Address")]
        [IsoXmlTag("TechAdr")]
        public TechnicalIdentification2Choice_? TechnicalAddress { get; init; } 
        
        /// <summary>
        /// Additional attributes defined by a central security depositary for a party.
        /// </summary>
        [IsoId("_0XDX2YwXEei289CGNqs21g")]
        [DisplayName("Market Specific Attribute")]
        [IsoXmlTag("MktSpcfcAttr")]
        public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_0XDX3YwXEei289CGNqs21g")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        public PartyName4? Name { get; init; } 
        
        /// <summary>
        /// Specifies the type of residence where the party has its permanent home or principal establishment.
        /// </summary>
        [IsoId("_CiEaJIwaEei289CGNqs21g")]
        [DisplayName("Residence Type")]
        [IsoXmlTag("ResTp")]
        public ResidenceType1Code? ResidenceType { get; init; } 
        
        /// <summary>
        /// Specifies whether the party is locked or not, and the reason for this status, when required.
        /// </summary>
        [IsoId("_CiEaJYwaEei289CGNqs21g")]
        [DisplayName("Lock Status")]
        [IsoXmlTag("LckSts")]
        public PartyLockStatus1? LockStatus { get; init; } 
        
        /// <summary>
        /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
        /// </summary>
        [IsoId("_0XDX4YwXEei289CGNqs21g")]
        [DisplayName("Restriction")]
        [IsoXmlTag("Rstrctn")]
        public SystemRestriction1? Restriction { get; init; } 
        
        
        #nullable disable
        
    }
}
