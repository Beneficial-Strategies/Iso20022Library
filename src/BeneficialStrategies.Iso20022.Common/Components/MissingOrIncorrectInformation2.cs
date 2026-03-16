// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further information on the reason for the unable to apply investigation.
/// </summary>
[IsoId("_T-i3N9p-Ed-ak6NoX_4Aeg_-689240837")]
[DisplayName("Missing Or Incorrect Information")]
public record MissingOrIncorrectInformation2
{
    /// <summary>
    /// Indicates whether the request is related to an AML (Anti Money Laundering) investigation or not.
    /// </summary>
    [IsoId("_T-soMNp-Ed-ak6NoX_4Aeg_257368960")]
    [DisplayName("Anti Money Laundering Request")]
    [IsoXmlTag("AMLReq")]
    [IsoSimpleType(IsoSimpleType.AMLIndicator)]
    public IsoAMLIndicator? AntiMoneyLaunderingRequest { get; init; }

    /// <summary>
    /// Indicates the missing information.
    /// </summary>
    [IsoId("_T-soMdp-Ed-ak6NoX_4Aeg_-689240580")]
    [DisplayName("Missing Information")]
    [IsoXmlTag("MssngInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public SimpleValueList<UnableToApplyMissingInformation2Code> MissingInformation { get; init; } =
        [];

    /// <summary>
    /// Indicates, in a coded form, the incorrect information.
    /// </summary>
    [IsoId("_T-soMtp-Ed-ak6NoX_4Aeg_-689240558")]
    [DisplayName("Incorrect Information")]
    [IsoXmlTag("IncrrctInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public SimpleValueList<UnableToApplyIncorrectInformation3Code> IncorrectInformation { get; init; } =
        [];
}
