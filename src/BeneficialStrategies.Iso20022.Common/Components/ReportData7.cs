// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Data7.
/// </summary>
[IsoId("_FcUxQY7fEe6S0_1AaJzQCA")]
[DisplayName("Report Data7")]
public record ReportData7
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Continuation Indicator.
    /// </summary>
    [DisplayName("Continuation Indicator")]
    [IsoXmlTag("ConttnInd")]
    public IsoTrueFalseIndicator? ContinuationIndicator { get; init; }

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Format.
    /// </summary>
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat5Code? Format { get; init; }

    /// <summary>
    /// Frequency.
    /// </summary>
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency17Code? Frequency { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax140Text? Identification { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Other Format.
    /// </summary>
    [DisplayName("Other Format")]
    [IsoXmlTag("OthrFrmt")]
    public IsoMax35Text? OtherFormat { get; init; }

    /// <summary>
    /// Qualifier.
    /// </summary>
    [DisplayName("Qualifier")]
    [IsoXmlTag("Qlfr")]
    public IsoMax70Text? Qualifier { get; init; }

    /// <summary>
    /// Sequence.
    /// </summary>
    [DisplayName("Sequence")]
    [IsoXmlTag("Seq")]
    public IsoMax5NumericText? Sequence { get; init; }

    /// <summary>
    /// Time.
    /// </summary>
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; }

    /// <summary>
    /// Total Occurrences.
    /// </summary>
    [DisplayName("Total Occurrences")]
    [IsoXmlTag("TtlOcrncs")]
    public IsoMax5NumericText? TotalOccurrences { get; init; }
}
