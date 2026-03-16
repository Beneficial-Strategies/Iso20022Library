// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary identification of the reason related to a status.
/// </summary>
[IsoId("_UatOxNp-Ed-ak6NoX_4Aeg_497607860")]
[DisplayName("Proprietary Reason")]
public record ProprietaryReason1
{
    /// <summary>
    /// Proprietary identification of the reason related to a status.
    /// </summary>
    [IsoId("_UatOxdp-Ed-ak6NoX_4Aeg_-1135929071")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public GenericIdentification20? Reason { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_UatOxtp-Ed-ak6NoX_4Aeg_-1133156666")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
