// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to be present in a dispute.
/// </summary>
[IsoId("_1xe1ccZiEeiCDcGzDHI_9Q")]
[DisplayName("Dispute Data")]
public record DisputeData2
{
    /// <summary>
    /// Indicates the cycle of presentment or of the chargeback  (1= first cycle for chargeback, 2= second cycle of presentment or chargeback, etc.).
    /// </summary>
    [IsoId("_18M3scZiEeiCDcGzDHI_9Q")]
    [DisplayName("Presentment Cycle")]
    [IsoXmlTag("PresntmntCycl")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    public IsoExact1NumericText? PresentmentCycle { get; init; }

    /// <summary>
    /// Condition of the dispute.
    /// </summary>
    [IsoId("_18M3s8ZiEeiCDcGzDHI_9Q")]
    [DisplayName("Dispute Condition")]
    [IsoXmlTag("DsptCond")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DisputeCondition { get; init; }

    /// <summary>
    /// Reference for the dispute.
    /// </summary>
    [IsoId("_18M3ucZiEeiCDcGzDHI_9Q")]
    [DisplayName("Dispute Reference")]
    [IsoXmlTag("DsptRef")]
    public DisputeReference1? DisputeReference { get; init; }
}
