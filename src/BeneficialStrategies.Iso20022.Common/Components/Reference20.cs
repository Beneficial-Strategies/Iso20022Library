// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the updated interest request such the original InterestRequest identification, and optionaly the InterestResponse identification.
/// </summary>
[IsoId("_Qkr_cNp-Ed-ak6NoX_4Aeg_2036685643")]
[DisplayName("Reference")]
public record Reference20
{
    /// <summary>
    /// Provides the reference to the interest payment request.
    /// </summary>
    [IsoId("_Qkr_cdp-Ed-ak6NoX_4Aeg_-1576527728")]
    [DisplayName("Interest Payment Request Identification")]
    [IsoXmlTag("IntrstPmtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InterestPaymentRequestIdentification { get; init; }

    /// <summary>
    /// Provides the reference to the interest payment response.
    /// </summary>
    [IsoId("_Qkr_ctp-Ed-ak6NoX_4Aeg_-1163077636")]
    [DisplayName("Interest Payment Response Identification")]
    [IsoXmlTag("IntrstPmtRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InterestPaymentResponseIdentification { get; init; }
}
