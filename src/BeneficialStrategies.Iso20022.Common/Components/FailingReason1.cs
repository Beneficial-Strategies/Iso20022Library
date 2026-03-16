// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
[IsoId("_UZqs89p-Ed-ak6NoX_4Aeg_-782936752")]
[DisplayName("Failing Reason")]
public record FailingReason1
{
    /// <summary>
    /// Specifies the reason why the instruction has a failing status.
    /// </summary>
    [IsoId("_UZqs9Np-Ed-ak6NoX_4Aeg_686367356")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required FailingReason1Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_UZqs9dp-Ed-ak6NoX_4Aeg_-604818080")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
