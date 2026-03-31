// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
[IsoId("_QqzOgNp-Ed-ak6NoX_4Aeg_1086698428")]
[DisplayName("Statement")]
public record Statement16
{
    /// <summary>
    /// Date or period of the statement.
    /// </summary>
    [IsoId("_QqzOgdp-Ed-ak6NoX_4Aeg_-1736465071")]
    [DisplayName("Statement Date Or Period")]
    [IsoXmlTag("StmtDtOrPrd")]
    public DateAndPeriod1Choice_? StatementDateOrPeriod { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_QqzOgtp-Ed-ak6NoX_4Aeg_1086698789")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency4Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_QqzOg9p-Ed-ak6NoX_4Aeg_1086698814")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType2Choice_? UpdateType { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_QqzOhNp-Ed-ak6NoX_4Aeg_1086698891")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public StatementBasis3Choice_? StatementBasis { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_QqzOhdp-Ed-ak6NoX_4Aeg_-980737258")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public StatementType2Choice_? StatementType { get; init; }
}
