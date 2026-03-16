// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account information.
/// </summary>
[IsoId("_o7MJQEUqEeSGWeX3z5zSZQ")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount119
{
    /// <summary>
    /// Identification of the party that legally owns the account.
    /// </summary>
    [IsoId("_Bl2FIEUrEeSGWeX3z5zSZQ")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public ValueList<PartyIdentification90> PartyIdentification { get; init; } = [];

    // ID for the above is _Bl2FIEUrEeSGWeX3z5zSZQ

    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_kNHDAEVKEeSGWeX3z5zSZQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public ValueList<AccountIdentification30> AccountIdentification { get; init; } = [];
    // ID for the above is _kNHDAEVKEeSGWeX3z5zSZQ
}
