// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the rejection or repair status.
/// </summary>
[IsoId("_UW1bYtp-Ed-ak6NoX_4Aeg_1414166172")]
[DisplayName("Rejection Or Repair Reason")]
public record RejectionOrRepairReason4
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected or repair status.
    /// </summary>
    [IsoId("_UW1bY9p-Ed-ak6NoX_4Aeg_-268700611")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public ValueList<RejectionAndRepairReason4Choice_> Code { get; init; } = [];

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_UW1bZNp-Ed-ak6NoX_4Aeg_-1009685629")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
