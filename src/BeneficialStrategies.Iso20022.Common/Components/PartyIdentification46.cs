// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity involved in an activity.
/// </summary>
[IsoId("_Rpl8YeaPEd-q8fx_Zl_34A")]
[DisplayName("Party Identification")]
public record PartyIdentification46
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_Rpl8Y-aPEd-q8fx_Zl_34A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification44Choice_ Identification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_Rpl8ZeaPEd-q8fx_Zl_34A")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }
}
