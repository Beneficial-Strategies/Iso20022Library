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
[IsoId("_PcH049p-Ed-ak6NoX_4Aeg_-1219999095")]
[DisplayName("Party Identification")]
public record PartyIdentification26
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_PcH05Np-Ed-ak6NoX_4Aeg_-1219999063")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned to a party using a proprietary identification scheme.
    /// </summary>
    [IsoId("_PcH05dp-Ed-ak6NoX_4Aeg_53536454")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification4? ProprietaryIdentification { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_PcH05tp-Ed-ak6NoX_4Aeg_-1219998601")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public required PostalAddress5 PostalAddress { get; init; }
}
