// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the corporate action reversal occurs.
/// </summary>
[IsoId("_QxDnh9p-Ed-ak6NoX_4Aeg_-2128428826")]
[DisplayName("Corporate Action Reversal Reason")]
public record CorporateActionReversalReason1
{
    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_QxNYgNp-Ed-ak6NoX_4Aeg_1055627051")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CorporateActionReversalReason1Choice_ Reason { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_QxNYgdp-Ed-ak6NoX_4Aeg_2052699404")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalReasonInformation { get; init; }
}
