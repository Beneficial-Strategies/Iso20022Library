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
[IsoId("_XjHp9249EeiU9cctagi5ow")]
[DisplayName("Organisation")]
public record Organisation35
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_XtGsYW49EeiU9cctagi5ow")]
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text FullLegalName { get; init; }

    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another.
    /// </summary>
    [IsoId("_XtGsY249EeiU9cctagi5ow")]
    [DisplayName("Trading Name")]
    [IsoXmlTag("TradgNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? TradingName { get; init; }

    /// <summary>
    /// Status of a legal entity.
    /// </summary>
    [IsoId("_XtGsZW49EeiU9cctagi5ow")]
    [DisplayName("Organisation Legal Status")]
    [IsoXmlTag("OrgLglSts")]
    public OrganisationLegalStatus1Code? OrganisationLegalStatus { get; init; }

    /// <summary>
    /// Date of establishment or date of founding of an institution is the date on which that institution chooses to claim as its starting point.
    /// </summary>
    [IsoId("_XtGsZ249EeiU9cctagi5ow")]
    [DisplayName("Established Date")]
    [IsoXmlTag("EstblishdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EstablishedDate { get; init; }

    /// <summary>
    /// Registration number for the organisation.
    /// </summary>
    [IsoId("_XtGsaW49EeiU9cctagi5ow")]
    [DisplayName("Registration Number")]
    [IsoXmlTag("RegnNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? RegistrationNumber { get; init; }

    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_XtGsa249EeiU9cctagi5ow")]
    [DisplayName("Registration Country")]
    [IsoXmlTag("RegnCtry")]
    public CountryCode? RegistrationCountry { get; init; }

    /// <summary>
    /// Date a given organisation was officially registered.
    /// </summary>
    [IsoId("_XtGsbW49EeiU9cctagi5ow")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; }

    /// <summary>
    /// Taxation unique reference number.
    /// </summary>
    [IsoId("_XtGsb249EeiU9cctagi5ow")]
    [DisplayName("Taxation Identification Number")]
    [IsoXmlTag("TaxtnIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxationIdentificationNumber { get; init; }

    /// <summary>
    /// Country of taxation of an individual person or an organisation.
    /// </summary>
    [IsoId("_XtGscW49EeiU9cctagi5ow")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; }

    /// <summary>
    /// Country in which the organisation has its business activity.
    /// </summary>
    [IsoId("_XtGsc249EeiU9cctagi5ow")]
    [DisplayName("Country Of Operation")]
    [IsoXmlTag("CtryOfOpr")]
    public CountryCode? CountryOfOperation { get; init; }

    /// <summary>
    /// Indicates that the new bank holds a copy of a registered company’s board resolution for the account switch.
    /// </summary>
    [IsoId("_XtGsdW49EeiU9cctagi5ow")]
    [DisplayName("Board Resolution Indicator")]
    [IsoXmlTag("BrdRsltnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BoardResolutionIndicator { get; init; }

    /// <summary>
    /// Address where the business activity is taking place.
    /// </summary>
    [IsoId("_XtGsd249EeiU9cctagi5ow")]
    [DisplayName("Business Address")]
    [IsoXmlTag("BizAdr")]
    public PostalAddress24? BusinessAddress { get; init; }

    /// <summary>
    /// Address, for example, of a shared services centre.
    /// </summary>
    [IsoId("_XtGseW49EeiU9cctagi5ow")]
    [DisplayName("Operational Address")]
    [IsoXmlTag("OprlAdr")]
    public PostalAddress24? OperationalAddress { get; init; }

    /// <summary>
    /// Address where the entity resides and is registered. More generically, it is the home address (residential address).
    /// </summary>
    [IsoId("_XtGse249EeiU9cctagi5ow")]
    [DisplayName("Legal Address")]
    [IsoXmlTag("LglAdr")]
    public PostalAddress24? LegalAddress { get; init; }

    /// <summary>
    /// Person in the customer&apos;s organisation who can be contacted by the account servicer.
    /// </summary>
    [IsoId("_XtGsfW49EeiU9cctagi5ow")]
    [DisplayName("Representative Officer")]
    [IsoXmlTag("RprtvOffcr")]
    public PartyIdentification135? RepresentativeOfficer { get; init; }

    /// <summary>
    /// Person responsible of the treasury department within an organisation.
    /// </summary>
    [IsoId("_XtGsf249EeiU9cctagi5ow")]
    [DisplayName("Treasury Manager")]
    [IsoXmlTag("TrsrMgr")]
    public PartyIdentification135? TreasuryManager { get; init; }

    /// <summary>
    /// Person who will delegate some authority to other individuals (mandate holders) to perform some specific bank operations on the account.
    /// </summary>
    [IsoId("_XtGsgW49EeiU9cctagi5ow")]
    [DisplayName("Main Mandate Holder")]
    [IsoXmlTag("MainMndtHldr")]
    public PartyIdentification135? MainMandateHolder { get; init; }

    /// <summary>
    /// Sender of a message related to the life cycle of an account.
    /// </summary>
    [IsoId("_XtGsg249EeiU9cctagi5ow")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification135? Sender { get; init; }
}
