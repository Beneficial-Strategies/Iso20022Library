// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional information related to the message.
/// </summary>
[IsoId("_Qoao5dp-Ed-ak6NoX_4Aeg_478592239")]
[DisplayName("Additional Information")]
public record AdditionalInformation5
{
    /// <summary>
    /// Contains additional information related to the message.
    /// </summary>
    [IsoId("_Qoao5tp-Ed-ak6NoX_4Aeg_1159536818")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    public SimpleValueList<System.String> Information { get; init; } = [];
    // ID for the above is _Qoao5tp-Ed-ak6NoX_4Aeg_1159536818
}
