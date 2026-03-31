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
[IsoId("_QBhoANp-Ed-ak6NoX_4Aeg_-83715953")]
[DisplayName("Individual Person")]
public record IndividualPerson17
{
    /// <summary>
    /// Name received at birth, eg, maiden name.
    /// </summary>
    [IsoId("_QBhoAdp-Ed-ak6NoX_4Aeg_-83715951")]
    [DisplayName("Birth Name")]
    [IsoXmlTag("BirthNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BirthName { get; init; }

    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QBhoAtp-Ed-ak6NoX_4Aeg_-83715899")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a person, eg, passport.
    /// </summary>
    [IsoId("_QBhoA9p-Ed-ak6NoX_4Aeg_-257954065")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification6? Identification { get; init; }

    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_QBhoBNp-Ed-ak6NoX_4Aeg_-83715374")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LongPostalAddress2Choice_? Address { get; init; }

    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_QBhoBdp-Ed-ak6NoX_4Aeg_-83715798")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification9Choice_? EmployingParty { get; init; }

    /// <summary>
    /// Specifies details related to the attendance card.
    /// </summary>
    [IsoId("_QBhoBtp-Ed-ak6NoX_4Aeg_2145914429")]
    [DisplayName("Attendance Card Details")]
    [IsoXmlTag("AttndncCardDtls")]
    public required AttendanceCard2 AttendanceCardDetails { get; init; }
}
