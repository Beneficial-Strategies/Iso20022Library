// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party and references.
/// </summary>
[IsoId("_-ZuPpYftEeevKP8c-ilVhA")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount157
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_-rulk4ftEeevKP8c-ilVhA")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification113 PartyIdentification { get; init; }

    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_-rullYftEeevKP8c-ilVhA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Specifies the reference of the transaction at the party identified in the sequence.
    /// </summary>
    [IsoId("_-rull4ftEeevKP8c-ilVhA")]
    [DisplayName("Processing Reference")]
    [IsoXmlTag("PrcgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingReference { get; init; }

    /// <summary>
    /// Date and optionally the time, at which this transaction was processed by the party identified in this sequence.
    /// </summary>
    [IsoId("_-rulmYftEeevKP8c-ilVhA")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTime2Choice_? ProcessingDate { get; init; }
}
