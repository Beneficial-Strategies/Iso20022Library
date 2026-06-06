// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the settlement instruction status query criteria including the status period.
/// </summary>
[IsoId("_X5k3wWdnEemMLeaDfmIfIA")]
[DisplayName("Settlement Instruction Query Status3")]
public record SettlementInstructionQueryStatus3
{
    /// <summary>
    /// Defines the status type of query criteria.
    /// </summary>
    [IsoId("_YKBHgWdnEemMLeaDfmIfIA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SettlementTransactionStatusType2 Type { get; init; }

    /// <summary>
    /// Specified date period of the status.
    /// </summary>
    [IsoId("_YKBukWdnEemMLeaDfmIfIA")]
    [DisplayName("Date Period")]
    [IsoXmlTag("DtPrd")]
    public DateAndDateTimeSearch5Choice_? DatePeriod { get; init; }
}
