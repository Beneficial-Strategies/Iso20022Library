// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the lottery.
/// </summary>
[IsoId("_1RIYZTL3EeKU9IrkkToqcw_-395277893")]
[DisplayName("Corporate Action SD")]
public record CorporateActionSD6
{
    /// <summary>
    /// Status of the fields of lottery record.
    /// </summary>
    [IsoId("_1RSJYDL3EeKU9IrkkToqcw_1163055922")]
    [DisplayName("Lottery Record Status")]
    [IsoXmlTag("LtryRcrdSts")]
    public required WorkflowStatus1Code LotteryRecordStatus { get; init; }
}
