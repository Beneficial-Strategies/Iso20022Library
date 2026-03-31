// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies further details of the party.
/// </summary>
[IsoId("_SlObEPH6Eeaz_YGUGLjP6A")]
[DisplayName("Party Detail")]
public record PartyDetail1
{
    /// <summary>
    /// Full name of the party.
    /// </summary>
    [IsoId("_00Q3QfH6Eeaz_YGUGLjP6A")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FullName { get; init; }

    /// <summary>
    /// Country of the party as recorded in the registration in its legal jurisdiction.
    /// </summary>
    [IsoId("_XbkCcfH7Eeaz_YGUGLjP6A")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Code indicating the type of party as per local regulation.
    /// </summary>
    [IsoId("_tWbeYfKXEeaz_YGUGLjP6A")]
    [DisplayName("Party Type")]
    [IsoXmlTag("PtyTp")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public required IsoMax10Text PartyType { get; init; }

    /// <summary>
    /// Information detail about the institution supervising the party under the local regulation.
    /// </summary>
    [IsoId("_gsrzEPH8Eeaz_YGUGLjP6A")]
    [DisplayName("Supervising Authority")]
    [IsoXmlTag("SprvsgAuthrty")]
    public required SupervisingAuthorityIdentification1Choice_ SupervisingAuthority { get; init; }

    /// <summary>
    /// Address used to communicate with the party as recorded in the registration in its legal jurisdiction.
    /// </summary>
    [IsoId("_My_DEogNEeeMp7TnNqgLag")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }

    /// <summary>
    /// Communication device number or electronic address used for communicating with the party.
    /// </summary>
    [IsoId("_hblHIfIBEeaz_YGUGLjP6A")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public CommunicationAddress7? Contact { get; init; }

    /// <summary>
    /// Any other additional information about the party.
    /// </summary>
    [IsoId("_zxVFQfKXEeaz_YGUGLjP6A")]
    [DisplayName("Comment")]
    [IsoXmlTag("Cmnt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20000Text? Comment { get; init; }
}
