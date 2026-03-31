// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance expressed with a data source scheme.
/// </summary>
[IsoId("_P_luUdp-Ed-ak6NoX_4Aeg_2128666136")]
[DisplayName("Generic Identification")]
public record GenericIdentification6
{
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_P_luUtp-Ed-ak6NoX_4Aeg_-1713450015")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public required IsoMax8Text Issuer { get; init; }

    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_P_luU9p-Ed-ak6NoX_4Aeg_-1801508836")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText Information { get; init; }

    /// <summary>
    /// Value of the balance.
    /// </summary>
    [IsoId("_P_luVNp-Ed-ak6NoX_4Aeg_-1695902189")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Balance { get; init; }
}
