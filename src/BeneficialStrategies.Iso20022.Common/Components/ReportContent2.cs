// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Content2.
/// </summary>
[IsoId("_X0VqYY7fEe6S0_1AaJzQCA")]
[DisplayName("Report Content2")]
public record ReportContent2
{
    /// <summary>
    /// Formatted Content.
    /// </summary>
    [DisplayName("Formatted Content")]
    [IsoXmlTag("FrmtdCntt")]
    public required ReportContent2Choice_ FormattedContent { get; init; }

    /// <summary>
    /// Report Line Sequence.
    /// </summary>
    [DisplayName("Report Line Sequence")]
    [IsoXmlTag("RptLineSeq")]
    public IsoMax10NumericText? ReportLineSequence { get; init; }
}
