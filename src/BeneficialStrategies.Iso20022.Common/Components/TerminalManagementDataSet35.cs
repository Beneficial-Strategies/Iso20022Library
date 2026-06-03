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
    [IsoId("_O4bYMbYFEfCUZfsQO4rYeA-id")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification11 Identification { get; init; }

    [IsoId("_O4bYMbYFEfCUZfsQO4rYeA-sqct")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    [IsoId("_O4bYMbYFEfCUZfsQO4rYeA-lsqs")]
    [DisplayName("Last Sequence")]
    [IsoXmlTag("LastSeq")]
    public IsoTrueFalseIndicator? LastSequence { get; init; }

    [IsoId("_O4bYMbYFEfCUZfsQO4rYeA-cntt")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public ManagementPlanContent14? Content { get; init; }
}
