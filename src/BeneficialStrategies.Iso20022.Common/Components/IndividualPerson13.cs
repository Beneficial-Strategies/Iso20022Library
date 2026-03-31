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
[IsoId("_QDA1y9p-Ed-ak6NoX_4Aeg_-1355433292")]
[DisplayName("Individual Person")]
public record IndividualPerson13
{
    /// <summary>
    /// Name received at birth, eg, maiden name.
    /// </summary>
    [IsoId("_QDKmwNp-Ed-ak6NoX_4Aeg_-1355433290")]
    [DisplayName("Birth Name")]
    [IsoXmlTag("BirthNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BirthName { get; init; }

    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QDKmwdp-Ed-ak6NoX_4Aeg_-1355433275")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a person, eg passport.
    /// </summary>
    [IsoId("_QDKmwtp-Ed-ak6NoX_4Aeg_-1355433179")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification2? Identification { get; init; }

    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_QDKmw9p-Ed-ak6NoX_4Aeg_-1355433136")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LongPostalAddress2Choice_? Address { get; init; }

    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_QDKmxNp-Ed-ak6NoX_4Aeg_2100880565")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification9Choice_? EmployingParty { get; init; }

    /// <summary>
    /// Specifies details related to the attendance card.
    /// </summary>
    [IsoId("_QDKmxdp-Ed-ak6NoX_4Aeg_-1159001390")]
    [DisplayName("Attendance Card Details")]
    [IsoXmlTag("AttndncCardDtls")]
    public required AttendanceCard1 AttendanceCardDetails { get; init; }
}
