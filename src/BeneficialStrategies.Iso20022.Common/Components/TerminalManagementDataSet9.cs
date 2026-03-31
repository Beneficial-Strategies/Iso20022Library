// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the status report of a point of interaction (POI).
/// </summary>
[IsoId("_7WeMUTV8EeODSIIQsYYKhw")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet9
{
    /// <summary>
    /// Identification of the data set containing the status report.
    /// </summary>
    [IsoId("_7nSPgTV8EeODSIIQsYYKhw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification3 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_7nSPgzV8EeODSIIQsYYKhw")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Content of the status report.
    /// </summary>
    [IsoId("_7nSPhTV8EeODSIIQsYYKhw")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required StatusReportContent3 Content { get; init; }
}
