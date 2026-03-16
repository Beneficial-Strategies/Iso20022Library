// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_Pb-D59p-Ed-ak6NoX_4Aeg_-1579248331")]
[DisplayName("Party Identification")]
public record PartyIdentification27
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_PcH04Np-Ed-ak6NoX_4Aeg_-1579248300")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned to a party using a proprietary identification scheme.
    /// </summary>
    [IsoId("_PcH04dp-Ed-ak6NoX_4Aeg_-634486320")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification4? ProprietaryIdentification { get; init; }

    /// <summary>
    /// Specifies the country of the party.
    /// </summary>
    [IsoId("_PcH04tp-Ed-ak6NoX_4Aeg_251171234")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }
}
