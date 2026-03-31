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
[IsoId("_Q2uKqNp-Ed-ak6NoX_4Aeg_1100233351")]
[DisplayName("Date Code And Time Format")]
public record DateCodeAndTimeFormat1
{
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_Q2uKqdp-Ed-ak6NoX_4Aeg_-834882430")]
    [DisplayName("Date Code")]
    [IsoXmlTag("DtCd")]
    public required DateCode4Choice_ DateCode { get; init; }

    /// <summary>
    /// Specifies the time.
    /// </summary>
    [IsoId("_Q237oNp-Ed-ak6NoX_4Aeg_713469563")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime Time { get; init; }
}
