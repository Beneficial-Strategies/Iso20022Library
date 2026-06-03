// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on the securities account positions.
/// </summary>
[IsoId("_rgEjcQJ3EfGAP_FOfstLIw")]
[DisplayName("Statement89")]
public record Statement89
{
    [IsoId("_rlNiIQJ3EfGAP_FOfstLIw")]
    [DisplayName("Date Or Period")]
    [IsoXmlTag("DtOrPrd")]
    public DateAndPeriod3Choice? DateOrPeriod { get; init; }

    [IsoId("_rlNiKQJ3EfGAP_FOfstLIw")]
    [DisplayName("Historic Data")]
    [IsoXmlTag("HstrcData")]
    public required IsoTrueFalseIndicator HistoricData { get; init; }

    [IsoId("_n1RFpgJ3EfGAP_FOfstLIw")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public StatementType7Choice? StatementType { get; init; }
}
