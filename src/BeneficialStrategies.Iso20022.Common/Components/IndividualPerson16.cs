// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_QBX3Adp-Ed-ak6NoX_4Aeg_-685335209")]
[DisplayName("Individual Person")]
public record IndividualPerson16
{
    /// <summary>
    /// Name received at birth, eg, maiden name.
    /// </summary>
    [IsoId("_QBX3Atp-Ed-ak6NoX_4Aeg_-685335207")]
    [DisplayName("Birth Name")]
    [IsoXmlTag("BirthNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BirthName { get; init; }

    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QBX3A9p-Ed-ak6NoX_4Aeg_-685335178")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a person, eg, passport.
    /// </summary>
    [IsoId("_QBX3BNp-Ed-ak6NoX_4Aeg_-396483904")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification6? Identification { get; init; }

    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_QBX3Bdp-Ed-ak6NoX_4Aeg_-685334684")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LongPostalAddress2Choice_? Address { get; init; }

    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_QBX3Btp-Ed-ak6NoX_4Aeg_-685334776")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification9Choice_? EmployingParty { get; init; }
}
