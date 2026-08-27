// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// New instrument related data report.
/// </summary>
[IsoId("_iaQV0GFSEfC91ZUW7iS7ww")]
[DisplayName("Instrument Report1")]
public record InstrumentReport1
{
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_qBNgIGFSEfC91ZUW7iS7ww")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public IsoMax140Text? ReportIdentification { get; init; }

    /// <summary>
    /// Information about the status of a financial instrument.
    /// </summary>
    [IsoId("_uIthAGFSEfC91ZUW7iS7ww")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    [MinLength(1)]
    public ValueList<InstrumentData1> Instrument { get; init; } = [];
}
