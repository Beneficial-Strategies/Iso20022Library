// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the definition of a party within a system.
/// A party shall denote any legal or organisational entity required in the system.
/// This entity shall store the parties from the first three levels: the system operator, the central securities depositaries, the participants of the central securities depositaries, the national central banks and payment banks.
/// </summary>
[IsoId("_-ojlcRirEeiNm9ItaZcR2A")]
[DisplayName("System Party")]
public record SystemParty4
{
    /// <summary>
    /// Unique identification of the party within the system.
    /// </summary>
    [IsoId("_C6RDgBiyEeiwzPn_GduuTA")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification9 PartyIdentification { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    [IsoId("_-7V-kxirEeiNm9ItaZcR2A")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public PostalAddress25? Address { get; init; }

    /// <summary>
    /// Specifies the options on how to contact the party.
    /// </summary>
    [IsoId("_Q47wEBitEeiNm9ItaZcR2A")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public Contact5? ContactDetails { get; init; }

    /// <summary>
    /// Specifies the opening date of the party.
    /// </summary>
    [IsoId("_-7V-lRirEeiNm9ItaZcR2A")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OpeningDate { get; init; }

    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    [IsoId("_-7V-lxirEeiNm9ItaZcR2A")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClosingDate { get; init; }

    /// <summary>
    /// Specifies the type classification of the party.
    /// </summary>
    [IsoId("_-7V-mRirEeiNm9ItaZcR2A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SystemPartyType1Choice_ Type { get; init; }

    /// <summary>
    /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
    /// </summary>
    [IsoId("_-7V-mxirEeiNm9ItaZcR2A")]
    [DisplayName("Technical Address")]
    [IsoXmlTag("TechAdr")]
    public TechnicalIdentification2Choice_? TechnicalAddress { get; init; }

    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    [IsoId("_-7V-nRirEeiNm9ItaZcR2A")]
    [DisplayName("Market Specific Attribute")]
    [IsoXmlTag("MktSpcfcAttr")]
    public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_-7V-nxirEeiNm9ItaZcR2A")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public PartyName4? Name { get; init; }

    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// </summary>
    [IsoId("_Pyc6gGjNEeiRg5NzP0jkQg")]
    [DisplayName("Residence Type")]
    [IsoXmlTag("ResTp")]
    public ResidenceType1Code? ResidenceType { get; init; }

    /// <summary>
    /// Specifies whether the party is locked or not, and the reason for this status, when required.
    /// </summary>
    [IsoId("_N6pTEGjHEeiCUdTMLdZoIg")]
    [DisplayName("Lock Status")]
    [IsoXmlTag("LckSts")]
    public PartyLockStatus1? LockStatus { get; init; }

    /// <summary>
    /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_-7V-oRirEeiNm9ItaZcR2A")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public SystemRestriction1? Restriction { get; init; }
}
