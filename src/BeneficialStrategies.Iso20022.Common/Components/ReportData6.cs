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
[IsoId("_fuq9cMlNEeuJ35KoBRZFOg")]
[DisplayName("Report Data")]
public record ReportData6
{
    /// <summary>
    /// Name of the report.
    /// </summary>
    [IsoId("_hWn9QMlOEeuJ35KoBRZFOg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Report identification.
    /// </summary>
    [IsoId("_qKltQMlOEeuJ35KoBRZFOg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Identification { get; init; }

    /// <summary>
    /// Additional specific information to ID (Country, Service, etc.)
    /// </summary>
    [IsoId("_vtcR0MlOEeuJ35KoBRZFOg")]
    [DisplayName("Qualifier")]
    [IsoXmlTag("Qlfr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Qualifier { get; init; }

    /// <summary>
    /// Date of the report.
    /// </summary>
    [IsoId("_7jbBUMlOEeuJ35KoBRZFOg")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Time of the report.
    /// </summary>
    [IsoId("__aO60MlOEeuJ35KoBRZFOg")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Time { get; init; }

    /// <summary>
    /// Contains the specific instance of the report (e.g., sequence “2” of the report within a specific time frame).
    /// </summary>
    [IsoId("_ElHrUMlPEeuJ35KoBRZFOg")]
    [DisplayName("Sequence")]
    [IsoXmlTag("Seq")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? Sequence { get; init; }

    /// <summary>
    /// Contains the expected total number of occurrences of the report within a specific time frame.
    /// </summary>
    [IsoId("_PRaO4MlPEeuJ35KoBRZFOg")]
    [DisplayName("Total Occurrences")]
    [IsoXmlTag("TtlOcrncs")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? TotalOccurrences { get; init; }

    /// <summary>
    /// Report frequency.
    /// </summary>
    [IsoId("__6uG0MlQEeuJ35KoBRZFOg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency17Code? Frequency { get; init; }

    /// <summary>
    /// Identifies that is a corrected version of a report that was previously sent.
    /// </summary>
    [IsoId("_H1V0AclREeuJ35KoBRZFOg")]
    [DisplayName("Correction")]
    [IsoXmlTag("Crrctn")]
    public CorrectionIdentification1? Correction { get; init; }

    /// <summary>
    /// Indicates that report is not complete.
    /// </summary>
    [IsoId("_hC0JEclREeuJ35KoBRZFOg")]
    [DisplayName("Continuation Indicator")]
    [IsoXmlTag("ConttnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ContinuationIndicator { get; init; }

    /// <summary>
    /// Additional report attributes or information.
    /// </summary>
    [IsoId("_ugTB4MlREeuJ35KoBRZFOg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }

    /// <summary>
    /// Report format.
    /// </summary>
    [IsoId("_L19M8MlVEeuJ35KoBRZFOg")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat5Code? Format { get; init; }

    /// <summary>
    /// Other report format defined by national organization or by bi-lateral agreement.
    /// </summary>
    [IsoId("_UY1M8MlVEeuJ35KoBRZFOg")]
    [DisplayName("Other Format")]
    [IsoXmlTag("OthrFrmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherFormat { get; init; }

    /// <summary>
    /// Contains the content of a report.
    /// </summary>
    [IsoId("_syuwAMlVEeuJ35KoBRZFOg")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public ReportContent1? Content { get; init; }
}
