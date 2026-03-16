// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose. For example, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_aQ9X8Q2cEeSNWNtJlXOAhg")]
[DisplayName("Organisation")]
public record Organisation20
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_7US2AA2cEeSNWNtJlXOAhg")]
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text FullLegalName { get; init; }

    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another.
    /// </summary>
    [IsoId("_3H7jQA2cEeSNWNtJlXOAhg")]
    [DisplayName("Trading Name")]
    [IsoXmlTag("TradgNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? TradingName { get; init; }

    /// <summary>
    /// Status of a legal entity.
    /// </summary>
    [IsoId("_-V_scA2cEeSNWNtJlXOAhg")]
    [DisplayName("Organisation Legal Status")]
    [IsoXmlTag("OrgLglSts")]
    public OrganisationLegalStatus1Code? OrganisationLegalStatus { get; init; }

    /// <summary>
    /// Date of establishment or date of founding of an institution is the date on which that institution chooses to claim as its starting point.
    /// </summary>
    [IsoId("_giyiYA2cEeSNWNtJlXOAhg")]
    [DisplayName("Established Date")]
    [IsoXmlTag("EstblishdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EstablishedDate { get; init; }

    /// <summary>
    /// Registration number for the organisation.
    /// </summary>
    [IsoId("_lEmgsA2cEeSNWNtJlXOAhg")]
    [DisplayName("Registration Number")]
    [IsoXmlTag("RegnNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? RegistrationNumber { get; init; }

    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_lBHSYA2dEeSNWNtJlXOAhg")]
    [DisplayName("Registration Country")]
    [IsoXmlTag("RegnCtry")]
    public CountryCode? RegistrationCountry { get; init; }

    /// <summary>
    /// Date a given organisation was officially registered.
    /// </summary>
    [IsoId("_nwk-wA2cEeSNWNtJlXOAhg")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; }

    /// <summary>
    /// Taxation unique reference number.
    /// </summary>
    [IsoId("_h68ysA2dEeSNWNtJlXOAhg")]
    [DisplayName("Taxation Identification Number")]
    [IsoXmlTag("TaxtnIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxationIdentificationNumber { get; init; }

    /// <summary>
    /// Country of taxation of an individual person or an organisation.
    /// </summary>
    [IsoId("_exg8kA2dEeSNWNtJlXOAhg")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; }

    /// <summary>
    /// Country in which the organisation has its business activity.
    /// </summary>
    [IsoId("_0Fo28A2cEeSNWNtJlXOAhg")]
    [DisplayName("Country Of Operation")]
    [IsoXmlTag("CtryOfOpr")]
    public CountryCode? CountryOfOperation { get; init; }

    /// <summary>
    /// Indicates that the new bank holds a copy of a registered company’s board resolution for the account switch.
    /// </summary>
    [IsoId("_r1gMwA2cEeSNWNtJlXOAhg")]
    [DisplayName("Board Resolution Indicator")]
    [IsoXmlTag("BrdRsltnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BoardResolutionIndicator { get; init; }

    /// <summary>
    /// Address where the business activity is taking place.
    /// </summary>
    [IsoId("_w50bMA2cEeSNWNtJlXOAhg")]
    [DisplayName("Business Address")]
    [IsoXmlTag("BizAdr")]
    public PostalAddress6? BusinessAddress { get; init; }

    /// <summary>
    /// Address, for example, of a shared services centre.
    /// </summary>
    [IsoId("_DeoaMA2dEeSNWNtJlXOAhg")]
    [DisplayName("Operational Address")]
    [IsoXmlTag("OprlAdr")]
    public PostalAddress6? OperationalAddress { get; init; }

    /// <summary>
    /// Address where the entity resides and is registered. More generically, it is the home address (residential address).
    /// </summary>
    [IsoId("_GJIRkA2dEeSNWNtJlXOAhg")]
    [DisplayName("Legal Address")]
    [IsoXmlTag("LglAdr")]
    public PostalAddress6? LegalAddress { get; init; }

    /// <summary>
    /// Person in the customer&apos;s organisation who can be contacted by the account servicer.
    /// </summary>
    [IsoId("_ReY5oA2dEeSNWNtJlXOAhg")]
    [DisplayName("Representative Officer")]
    [IsoXmlTag("RprtvOffcr")]
    public PartyIdentification125? RepresentativeOfficer { get; init; }

    /// <summary>
    /// Person responsible of the treasury department within an organisation.
    /// </summary>
    [IsoId("_VkE8oA2dEeSNWNtJlXOAhg")]
    [DisplayName("Treasury Manager")]
    [IsoXmlTag("TrsrMgr")]
    public PartyIdentification125? TreasuryManager { get; init; }

    /// <summary>
    /// Person who will delegate some authority to other individuals (mandate holders) to perform some specific bank operations on the account.
    /// </summary>
    [IsoId("_bueCUA2dEeSNWNtJlXOAhg")]
    [DisplayName("Main Mandate Holder")]
    [IsoXmlTag("MainMndtHldr")]
    public PartyIdentification125? MainMandateHolder { get; init; }

    /// <summary>
    /// Sender of a message related to the life cyle of an account.
    /// </summary>
    [IsoId("_pG9GYA2dEeSNWNtJlXOAhg")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification125? Sender { get; init; }
}
