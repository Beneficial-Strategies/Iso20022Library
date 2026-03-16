// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a date code and a time.
/// </summary>
[IsoId("_bf0RMUENEeWVgfuHGaKtRQ")]
[DisplayName("Date Code And Time Format")]
public record DateCodeAndTimeFormat3
{
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_btDb8UENEeWVgfuHGaKtRQ")]
    [DisplayName("Date Code")]
    [IsoXmlTag("DtCd")]
    public required DateCode21Choice_ DateCode { get; init; }

    /// <summary>
    /// Specifies the time.
    /// </summary>
    [IsoId("_btDb-UENEeWVgfuHGaKtRQ")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime Time { get; init; }
}
