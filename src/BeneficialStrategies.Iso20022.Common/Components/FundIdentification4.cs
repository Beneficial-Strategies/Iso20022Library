// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Distinct pool of financial instruments managed by a single investment policy. May or may not be part of an umbrella fund.The pool is issued in at least one investment fund class.
/// </summary>
[IsoId("_cxglQSjaEeK1Sbo8NpBROA")]
[DisplayName("Fund Identification")]
public record FundIdentification4
{
    /// <summary>
    /// Identification of the investment fund.
    /// </summary>
    [IsoId("_c94NUSjaEeK1Sbo8NpBROA")]
    [DisplayName("Fund Identification")]
    [IsoXmlTag("FndId")]
    public required PartyIdentification60 FundIdentification { get; init; }

    /// <summary>
    /// Identifies the account of the fund held with the custodian.
    /// </summary>
    [IsoId("_c94NVSjaEeK1Sbo8NpBROA")]
    [DisplayName("Account Identification With Custodian")]
    [IsoXmlTag("AcctIdWthCtdn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentificationWithCustodian { get; init; }

    /// <summary>
    /// Identification of the custodian which services the account of the fund.
    /// </summary>
    [IsoId("_c94NWSjaEeK1Sbo8NpBROA")]
    [DisplayName("Custodian Identification")]
    [IsoXmlTag("CtdnId")]
    public PartyIdentification73Choice_? CustodianIdentification { get; init; }
}
