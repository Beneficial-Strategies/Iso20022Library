// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of the movement status types.
/// </summary>
[IsoId("_VxnB0eSkEe-qVZLXW4RRBw")]
[DisplayName("Intra Position Status And Reason4")]
public record IntraPositionStatusAndReason4
{
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_Xhm_0eSkEe-qVZLXW4RRBw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ValueList<ProcessingStatus99Choice_> ProcessingStatus { get; init; } = [];

    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [IsoId("_Xhm_0-SkEe-qVZLXW4RRBw")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public ValueList<SettlementStatus34Choice_> SettlementStatus { get; init; } = [];

    /// <summary>
    /// Specifies the state or the condition.
    /// </summary>
    [IsoId("_Xhm_1eSkEe-qVZLXW4RRBw")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; }
}
