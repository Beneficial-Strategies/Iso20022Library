// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Distinct pool of financial instruments managed by a single investment policy. May or not be part of an umbrella fund.The pool is issued in at least one investment fund class.
/// </summary>
[IsoId("_S8Ai-AEcEeCQm6a_G2yO_w_740788919")]
[DisplayName("Fund Identification")]
public record FundIdentification3
{
    /// <summary>
    /// Identification of the investment fund.
    /// </summary>
    [IsoId("_S8Ai-QEcEeCQm6a_G2yO_w_626949853")]
    [DisplayName("Fund Identification")]
    [IsoXmlTag("FndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text FundIdentification { get; init; }

    /// <summary>
    /// Identifies the account of the fund held with the custodian.
    /// </summary>
    [IsoId("_S8Ai-gEcEeCQm6a_G2yO_w_-256283434")]
    [DisplayName("Account Identification With Custodian")]
    [IsoXmlTag("AcctIdWthCtdn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentificationWithCustodian { get; init; }

    /// <summary>
    /// Identification of the custodian which services the account of the fund.
    /// </summary>
    [IsoId("_S8Ai-wEcEeCQm6a_G2yO_w_-1253355787")]
    [DisplayName("Custodian Identification")]
    [IsoXmlTag("CtdnId")]
    public PartyIdentification19Choice_? CustodianIdentification { get; init; }
}
