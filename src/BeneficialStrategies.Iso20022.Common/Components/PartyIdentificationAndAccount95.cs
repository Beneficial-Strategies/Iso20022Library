// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[IsoId("_3tE73dTLEeKvJeoOII0e7w")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount95
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_4DPYwdTLEeKvJeoOII0e7w")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification71Choice_ PartyIdentification { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_4DPYydTLEeKvJeoOII0e7w")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public SecuritiesAccount22? AccountIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_4DPY0dTLEeKvJeoOII0e7w")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }
}
