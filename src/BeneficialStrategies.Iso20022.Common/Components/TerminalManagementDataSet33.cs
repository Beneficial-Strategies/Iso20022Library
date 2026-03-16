// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Terminal Management Data Set33.
/// </summary>
[IsoId("_r9-3wZRGEe6mHLZGMDWxvg")]
[DisplayName("Terminal Management Data Set33")]
public record TerminalManagementDataSet33
{
    /// <summary>
    /// Content.
    /// </summary>
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public ManagementPlanContent12? Content { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification10 Identification { get; init; }

    /// <summary>
    /// Last Sequence.
    /// </summary>
    [DisplayName("Last Sequence")]
    [IsoXmlTag("LastSeq")]
    public IsoTrueFalseIndicator? LastSequence { get; init; }

    /// <summary>
    /// Sequence Counter.
    /// </summary>
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    public IsoMax9NumericText? SequenceCounter { get; init; }
}
