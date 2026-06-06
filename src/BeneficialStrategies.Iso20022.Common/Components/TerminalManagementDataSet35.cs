// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data set for terminal management.
/// </summary>
[IsoId("_O4bYMbYFEfCUZfsQO4rYeA")]
[DisplayName("Terminal Management Data Set35")]
public record TerminalManagementDataSet35
{
    /// <summary>
    /// Identification of the data set containing the management plan.
    /// </summary>
    [IsoId("_O4bYMbYFEfCUZfsQO4rYeA-id")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification11 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_O4bYMbYFEfCUZfsQO4rYeA-sqct")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Indication of the last sequence in case of split messages.
    /// </summary>
    [IsoId("_O4bYMbYFEfCUZfsQO4rYeA-lsqs")]
    [DisplayName("Last Sequence")]
    [IsoXmlTag("LastSeq")]
    public IsoTrueFalseIndicator? LastSequence { get; init; }

    /// <summary>
    /// Content of the management plan.
    /// </summary>
    [IsoId("_O4bYMbYFEfCUZfsQO4rYeA-cntt")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public ManagementPlanContent14? Content { get; init; }
}
