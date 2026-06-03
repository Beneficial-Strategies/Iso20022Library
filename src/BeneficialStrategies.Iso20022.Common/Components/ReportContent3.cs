// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the content of a report.
/// </summary>
[IsoId("_7I0XcUVdEfCQAqQ9lolFUg")]
[DisplayName("Report Content3")]
public record ReportContent3
{
    /// <summary>
    /// Sequence number of the report line in the report.
    /// </summary>
    [IsoId("_7LR1kUVdEfCQAqQ9lolFUg")]
    [DisplayName("Report Line Sequence")]
    [IsoXmlTag("RptLineSeq")]
    public IsoMax10NumericText? ReportLineSequence { get; init; }

    /// <summary>
    /// Report content in text format.
    /// </summary>
    [IsoId("_z5OOI3FYEfC68Y4jZPNEug")]
    [DisplayName("Text")]
    [IsoXmlTag("Txt")]
    public IsoMax10MbText? Text { get; init; }

    /// <summary>
    /// BASE-64 encoded report content.
    /// </summary>
    [IsoId("_z5OOJHFYEfC68Y4jZPNEug")]
    [DisplayName("Binary")]
    [IsoXmlTag("Binry")]
    public IsoMax20MbBinary? Binary { get; init; }

    /// <summary>
    /// Encrypted report content.
    /// </summary>
    [IsoId("_z5OOJXFYEfC68Y4jZPNEug")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public EncryptedData2? ProtectedData { get; init; }
}
