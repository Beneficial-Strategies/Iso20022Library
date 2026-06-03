// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the attributes of a report and its content.
/// </summary>
[IsoId("_7yb4AXFWEfC68Y4jZPNEug")]
[DisplayName("Report Data8")]
public record ReportData8
{
    /// <summary>
    /// Name of the report.
    /// </summary>
    [IsoId("_71Aq4XFWEfC68Y4jZPNEug")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Report identification.
    /// </summary>
    [IsoId("_71Aq43FWEfC68Y4jZPNEug")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax140Text? Identification { get; init; }

    /// <summary>
    /// Additional specific information to ID (Country, Service, etc.)
    /// </summary>
    [IsoId("_71Aq5XFWEfC68Y4jZPNEug")]
    [DisplayName("Qualifier")]
    [IsoXmlTag("Qlfr")]
    public IsoMax70Text? Qualifier { get; init; }

    /// <summary>
    /// Date of the report.
    /// </summary>
    [IsoId("_71Aq53FWEfC68Y4jZPNEug")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Time of the report.
    /// </summary>
    [IsoId("_71Aq6XFWEfC68Y4jZPNEug")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; }

    /// <summary>
    /// Contains the specific instance of the report within a specific time frame.
    /// </summary>
    [IsoId("_71Aq63FWEfC68Y4jZPNEug")]
    [DisplayName("Sequence")]
    [IsoXmlTag("Seq")]
    public IsoMax5NumericText? Sequence { get; init; }

    /// <summary>
    /// Contains the expected total number of occurrences of the report within a specific time frame.
    /// </summary>
    [IsoId("_71Aq7XFWEfC68Y4jZPNEug")]
    [DisplayName("Total Occurrences")]
    [IsoXmlTag("TtlOcrncs")]
    public IsoMax5NumericText? TotalOccurrences { get; init; }

    /// <summary>
    /// Report frequency.
    /// </summary>
    [IsoId("_71Aq73FWEfC68Y4jZPNEug")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency17Code? Frequency { get; init; }

    /// <summary>
    /// Indicates that report is not complete.
    /// </summary>
    [IsoId("_71Aq8XFWEfC68Y4jZPNEug")]
    [DisplayName("Continuation Indicator")]
    [IsoXmlTag("ConttnInd")]
    public IsoTrueFalseIndicator? ContinuationIndicator { get; init; }

    /// <summary>
    /// Report format.
    /// </summary>
    [IsoId("_71Aq9XFWEfC68Y4jZPNEug")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat7Code? Format { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("__CiW0nFWEfC68Y4jZPNEug")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("__CiW03FWEfC68Y4jZPNEug")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
