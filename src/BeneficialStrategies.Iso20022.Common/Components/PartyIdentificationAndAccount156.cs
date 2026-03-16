// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a settlement party.
/// </summary>
[IsoId("_9DljPYftEeevKP8c-ilVhA")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount156
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_9UshMYftEeevKP8c-ilVhA")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public PartyIdentification113? PartyIdentification { get; init; }

    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_9UshM4ftEeevKP8c-ilVhA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_9UshNYftEeevKP8c-ilVhA")]
    [DisplayName("Place Of Settlement")]
    [IsoXmlTag("PlcOfSttlm")]
    public required PartyIdentification113 PlaceOfSettlement { get; init; }
}
