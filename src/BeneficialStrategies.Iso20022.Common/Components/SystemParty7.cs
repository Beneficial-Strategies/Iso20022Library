// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// System Party7.
/// </summary>
[IsoId("_ZAMbkTE_Ee62xuUQ2zyZww")]
[DisplayName("System Party7")]
public record SystemParty7
{
    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public ValueList<PostalAddress28> Address { get; init; } = [];

    /// <summary>
    /// Closing Date.
    /// </summary>
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public IsoISODate? ClosingDate { get; init; }

    /// <summary>
    /// Contact Details.
    /// </summary>
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public ValueList<Contact14> ContactDetails { get; init; } = [];

    /// <summary>
    /// Lock Status.
    /// </summary>
    [DisplayName("Lock Status")]
    [IsoXmlTag("LckSts")]
    public PartyLockStatus1? LockStatus { get; init; }

    /// <summary>
    /// Market Specific Attribute.
    /// </summary>
    [DisplayName("Market Specific Attribute")]
    [IsoXmlTag("MktSpcfcAttr")]
    public ValueList<MarketSpecificAttribute1> MarketSpecificAttribute { get; init; } = [];

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public PartyName4? Name { get; init; }

    /// <summary>
    /// Opening Date.
    /// </summary>
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    public IsoISODate? OpeningDate { get; init; }

    /// <summary>
    /// Party Identification.
    /// </summary>
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification9 PartyIdentification { get; init; }

    /// <summary>
    /// Residence Type.
    /// </summary>
    [DisplayName("Residence Type")]
    [IsoXmlTag("ResTp")]
    public ResidenceType1Code? ResidenceType { get; init; }

    /// <summary>
    /// Restriction.
    /// </summary>
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public ValueList<SystemRestriction1> Restriction { get; init; } = [];

    /// <summary>
    /// Technical Address.
    /// </summary>
    [DisplayName("Technical Address")]
    [IsoXmlTag("TechAdr")]
    public ValueList<TechnicalIdentification2Choice_> TechnicalAddress { get; init; } = [];

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SystemPartyType1Choice_ Type { get; init; }
}
