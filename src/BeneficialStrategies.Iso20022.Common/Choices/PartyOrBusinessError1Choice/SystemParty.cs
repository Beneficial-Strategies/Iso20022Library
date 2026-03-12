// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyOrBusinessError1Choice
{
    /// <summary>
    /// Specifications of a party defined within a system.
    /// </summary>
    [IsoId("_kn1p4O5NEeCisYr99QEiWA_321016681")]
    [DisplayName("System Party")]
    public partial record SystemParty : PartyOrBusinessError1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the opening date of the party.
        /// </summary>
        [IsoId("_kmMrJO5NEeCisYr99QEiWA_518289586")]
        [DisplayName("Opening Date")]
        [IsoXmlTag("OpngDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? OpeningDate { get; init; } 
        
        /// <summary>
        /// Specifies the closing date of the party.
        /// </summary>
        [IsoId("_kmV1EO5NEeCisYr99QEiWA_-478782767")]
        [DisplayName("Closing Date")]
        [IsoXmlTag("ClsgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ClosingDate { get; init; } 
        
        /// <summary>
        /// Specifies the type classification of the party.
        /// </summary>
        [IsoId("_kmV1Ee5NEeCisYr99QEiWA_-1475855120")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public SystemPartyType1Code? Type { get; init; } 
        
        /// <summary>
        /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
        /// </summary>
        [IsoId("_kmV1Eu5NEeCisYr99QEiWA_1822039823")]
        [DisplayName("Technical Address")]
        [IsoXmlTag("TechAdr")]
        public TechnicalIdentification1Choice_? TechnicalAddress { get; init; } 
        
        /// <summary>
        /// Additional attributes defined by a central security depositary for a party.
        /// </summary>
        [IsoId("_kmV1E-5NEeCisYr99QEiWA_824967470")]
        [DisplayName("Market Specific Attribute")]
        [IsoXmlTag("MktSpcfcAttr")]
        public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous way to identify an organisation.
        /// </summary>
        [IsoId("_kmV1FO5NEeCisYr99QEiWA_399330754")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public SystemPartyIdentification1? Identification { get; init; } 
        
        /// <summary>
        /// Name by which an organisation is known and which is usually used to identify that organisation.
        /// </summary>
        [IsoId("_kmfmEO5NEeCisYr99QEiWA_-2055026817")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        public PartyName3? Name { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address.
        /// </summary>
        [IsoId("_kmfmEe5NEeCisYr99QEiWA_-341683547")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public PostalAddress10? Address { get; init; } 
        
        /// <summary>
        /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
        /// </summary>
        [IsoId("_kmfmEu5NEeCisYr99QEiWA_-437950738")]
        [DisplayName("Restriction")]
        [IsoXmlTag("Rstrctn")]
        public SystemRestriction1? Restriction { get; init; } 
        
        
        #nullable disable
        
    }
}
