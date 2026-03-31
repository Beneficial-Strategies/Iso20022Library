// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organisation43.
/// </summary>
[IsoId("_3YgJsTEyEe6g-ffJsqGiSA")]
[DisplayName("Organisation43")]
public record Organisation43
{
    /// <summary>
    /// Board Resolution Indicator.
    /// </summary>
    [DisplayName("Board Resolution Indicator")]
    [IsoXmlTag("BrdRsltnInd")]
    public IsoTrueFalseIndicator? BoardResolutionIndicator { get; init; }

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
    public CountryCode? CountryOfOperation { get; init; }

    /// <summary>
    /// Established Date.
    /// </summary>
    [DisplayName("Established Date")]
    [IsoXmlTag("EstblishdDt")]
    public IsoISODate? EstablishedDate { get; init; }

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
    public PostalAddress27? LegalAddress { get; init; }

    /// <summary>
    /// Main Mandate Holder.
    /// </summary>
    [DisplayName("Main Mandate Holder")]
    [IsoXmlTag("MainMndtHldr")]
    public ValueList<PartyIdentification272> MainMandateHolder { get; init; } = [];

    /// <summary>
    /// Operational Address.
    /// </summary>
    [DisplayName("Operational Address")]
    [IsoXmlTag("OprlAdr")]
    public PostalAddress27? OperationalAddress { get; init; }

    /// <summary>
    /// Organisation Legal Status.
    /// </summary>
    [DisplayName("Organisation Legal Status")]
    [IsoXmlTag("OrgLglSts")]
    public OrganisationLegalStatus1Code? OrganisationLegalStatus { get; init; }

    /// <summary>
    /// Registration Country.
    /// </summary>
    [DisplayName("Registration Country")]
    [IsoXmlTag("RegnCtry")]
    public CountryCode? RegistrationCountry { get; init; }

    /// <summary>
    /// Registration Date.
    /// </summary>
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    public IsoISODate? RegistrationDate { get; init; }

    /// <summary>
    /// Registration Number.
    /// </summary>
    [DisplayName("Registration Number")]
    [IsoXmlTag("RegnNb")]
    public IsoMax70Text? RegistrationNumber { get; init; }

    /// <summary>
    /// Representative Officer.
    /// </summary>
    [DisplayName("Representative Officer")]
    [IsoXmlTag("RprtvOffcr")]
    public ValueList<PartyIdentification272> RepresentativeOfficer { get; init; } = [];

    /// <summary>
    /// Sender.
    /// </summary>
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public ValueList<PartyIdentification272> Sender { get; init; } = [];

    /// <summary>
    /// Taxation Country.
    /// </summary>
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; }

    /// <summary>
    /// Taxation Identification Number.
    /// </summary>
    [DisplayName("Taxation Identification Number")]
    [IsoXmlTag("TaxtnIdNb")]
    public IsoMax35Text? TaxationIdentificationNumber { get; init; }

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
    public PartyIdentification272? TreasuryManager { get; init; }
}
