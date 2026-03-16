// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fund Identification6.
/// </summary>
[IsoId("_usoBEXfaEe2I4Iip2NEM0A")]
[DisplayName("Fund Identification6")]
public record FundIdentification6
{
    /// <summary>
    /// Account Identification With Custodian.
    /// </summary>
    [DisplayName("Account Identification With Custodian")]
    [IsoXmlTag("AcctIdWthCtdn")]
    public IsoMax35Text? AccountIdentificationWithCustodian { get; init; }

    /// <summary>
    /// Custodian Identification.
    /// </summary>
    [DisplayName("Custodian Identification")]
    [IsoXmlTag("CtdnId")]
    public PartyIdentification251Choice_? CustodianIdentification { get; init; }

    /// <summary>
    /// Fund Identification.
    /// </summary>
    [DisplayName("Fund Identification")]
    [IsoXmlTag("FndId")]
    public required IsoMax35Text FundIdentification { get; init; }
}
