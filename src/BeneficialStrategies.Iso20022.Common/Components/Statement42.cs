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
[IsoId("_dJfNDzeNEeWm5uvLSn0jEw")]
[DisplayName("Statement")]
public record Statement42
{
    /// <summary>
    /// Date or period of the statement.
    /// </summary>
    [IsoId("_dpBohTeNEeWm5uvLSn0jEw")]
    [DisplayName("Statement Date Or Period")]
    [IsoXmlTag("StmtDtOrPrd")]
    public DateAndPeriod1Choice_? StatementDateOrPeriod { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_dpBojTeNEeWm5uvLSn0jEw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency25Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_dpBolTeNEeWm5uvLSn0jEw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType15Choice_? UpdateType { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_dpBonTeNEeWm5uvLSn0jEw")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public StatementBasis7Choice_? StatementBasis { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_dpBopTeNEeWm5uvLSn0jEw")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public StatementType5Choice_? StatementType { get; init; }
}
