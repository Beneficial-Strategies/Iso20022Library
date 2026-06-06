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
    /// <summary>
    /// Date or period of the statement.
    /// </summary>
    [IsoId("_rlNiIQJ3EfGAP_FOfstLIw")]
    [DisplayName("Date Or Period")]
    [IsoXmlTag("DtOrPrd")]
    public DateAndPeriod3Choice_? DateOrPeriod { get; init; }

    /// <summary>
    /// Specifies whether the data is either historical (true) or current (false).
    /// </summary>
    [IsoId("_rlNiKQJ3EfGAP_FOfstLIw")]
    [DisplayName("Historic Data")]
    [IsoXmlTag("HstrcData")]
    public required IsoTrueFalseIndicator HistoricData { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_n1RFpgJ3EfGAP_FOfstLIw")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public StatementType7Choice_? StatementType { get; init; }
}
