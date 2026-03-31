// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_LhHFEQjKEeS5F6qHcKOrew")]
[DisplayName("Organisation")]
public record Organisation17
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_L7TGsQjKEeS5F6qHcKOrew")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, for example, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_L7TGswjKEeS5F6qHcKOrew")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification4Choice_? Identification { get; init; }

    /// <summary>
    /// Purpose of the organisation, for example, charity.
    /// </summary>
    [IsoId("_L7TGtQjKEeS5F6qHcKOrew")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Purpose { get; init; }

    /// <summary>
    /// Country of taxation of an organisation.
    /// </summary>
    [IsoId("_L7TGtwjKEeS5F6qHcKOrew")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; }

    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_L7TGuQjKEeS5F6qHcKOrew")]
    [DisplayName("Registration Country")]
    [IsoXmlTag("RegnCtry")]
    public CountryCode? RegistrationCountry { get; init; }

    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_L7TGuwjKEeS5F6qHcKOrew")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; }

    /// <summary>
    /// Tax identification information.
    /// </summary>
    [IsoId("_L7TGvQjKEeS5F6qHcKOrew")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    public TaxIdentification2? TaxIdentification { get; init; }

    /// <summary>
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    [IsoId("_L7TGvwjKEeS5F6qHcKOrew")]
    [DisplayName("National Registration Number")]
    [IsoXmlTag("NtlRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NationalRegistrationNumber { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_L7TGwQjKEeS5F6qHcKOrew")]
    [DisplayName("Modified Postal Address")]
    [IsoXmlTag("ModfdPstlAdr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<ModificationScope1> ModifiedPostalAddress { get; init; } = [];

    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_L7TGwwjKEeS5F6qHcKOrew")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; }

    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_L7TGxQjKEeS5F6qHcKOrew")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; }

    /// <summary>
    /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
    /// </summary>
    [IsoId("_L7TGxwjKEeS5F6qHcKOrew")]
    [DisplayName("Additional Regulatory Information")]
    [IsoXmlTag("AddtlRgltryInf")]
    public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; }
}
