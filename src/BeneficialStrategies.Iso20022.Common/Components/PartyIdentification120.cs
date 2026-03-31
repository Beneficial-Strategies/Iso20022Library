// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about identification of the party.
/// </summary>
[IsoId("_b7F3I62hEeaYS91sTIbkkQ")]
[DisplayName("Party Identification")]
public record PartyIdentification120
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [IsoId("_cMzR862hEeaYS91sTIbkkQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification58Choice_ Identification { get; init; }

    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    [IsoId("_cMzR-62hEeaYS91sTIbkkQ")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides alternate identification for a party using an id type, a country code and a text field.
    /// </summary>
    [IsoId("_cMzSA62hEeaYS91sTIbkkQ")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public ValueList<AlternatePartyIdentification9> AlternateIdentification { get; init; } = [];
}
