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
[IsoId("_QDA1xdp-Ed-ak6NoX_4Aeg_-729109084")]
[DisplayName("Individual Person")]
public record IndividualPerson14
{
    /// <summary>
    /// Name received at birth, eg, maiden name.
    /// </summary>
    [IsoId("_QDA1xtp-Ed-ak6NoX_4Aeg_-729109066")]
    [DisplayName("Birth Name")]
    [IsoXmlTag("BirthNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BirthName { get; init; }

    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QDA1x9p-Ed-ak6NoX_4Aeg_-729109014")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a person, eg passport.
    /// </summary>
    [IsoId("_QDA1yNp-Ed-ak6NoX_4Aeg_-729108496")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification2? Identification { get; init; }

    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_QDA1ydp-Ed-ak6NoX_4Aeg_-729108599")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public PostalAddress1? Address { get; init; }

    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_QDA1ytp-Ed-ak6NoX_4Aeg_-729108910")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification9Choice_? EmployingParty { get; init; }
}
