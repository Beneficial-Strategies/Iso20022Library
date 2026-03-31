// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organisation42.
/// </summary>
[IsoId("_02SEkTEyEe6g-ffJsqGiSA")]
[DisplayName("Organisation42")]
public record Organisation42
{
    /// <summary>
    /// Billing Address.
    /// </summary>
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public PostalAddress27? BillingAddress { get; init; }

    /// <summary>
    /// Business Address.
    /// </summary>
    [DisplayName("Business Address")]
    [IsoXmlTag("BizAdr")]
    public PostalAddress27? BusinessAddress { get; init; }

    /// <summary>
    /// Country Of Operation.
    /// </summary>
    [DisplayName("Country Of Operation")]
    [IsoXmlTag("CtryOfOpr")]
    public required CountryCode CountryOfOperation { get; init; }

    /// <summary>
    /// Full Legal Name.
    /// </summary>
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    public required IsoMax350Text FullLegalName { get; init; }

    /// <summary>
    /// Legal Address.
    /// </summary>
    [DisplayName("Legal Address")]
    [IsoXmlTag("LglAdr")]
    public required PostalAddress27 LegalAddress { get; init; }

    /// <summary>
    /// Legal Representative.
    /// </summary>
    [DisplayName("Legal Representative")]
    [IsoXmlTag("LglRprtv")]
    public ValueList<PartyIdentification274> LegalRepresentative { get; init; } = [];

    /// <summary>
    /// Main Mandate Holder.
    /// </summary>
    [DisplayName("Main Mandate Holder")]
    [IsoXmlTag("MainMndtHldr")]
    public ValueList<PartyIdentification274> MainMandateHolder { get; init; } = [];

    /// <summary>
    /// Operational Address.
    /// </summary>
    [DisplayName("Operational Address")]
    [IsoXmlTag("OprlAdr")]
    public PostalAddress27? OperationalAddress { get; init; }

    /// <summary>
    /// Organisation Identification.
    /// </summary>
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification39 OrganisationIdentification { get; init; }

    /// <summary>
    /// Registration Date.
    /// </summary>
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    public IsoISODate? RegistrationDate { get; init; }

    /// <summary>
    /// Representative Officer.
    /// </summary>
    [DisplayName("Representative Officer")]
    [IsoXmlTag("RprtvOffcr")]
    public ValueList<PartyIdentification274> RepresentativeOfficer { get; init; } = [];

    /// <summary>
    /// Sender.
    /// </summary>
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public ValueList<PartyIdentification274> Sender { get; init; } = [];

    /// <summary>
    /// Trading Name.
    /// </summary>
    [DisplayName("Trading Name")]
    [IsoXmlTag("TradgNm")]
    public IsoMax350Text? TradingName { get; init; }

    /// <summary>
    /// Treasury Manager.
    /// </summary>
    [DisplayName("Treasury Manager")]
    [IsoXmlTag("TrsrMgr")]
    public PartyIdentification274? TreasuryManager { get; init; }
}
