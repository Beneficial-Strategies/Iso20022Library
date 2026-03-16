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
[IsoId("_8QbA2ZNLEeWGlc8L7oPDIg")]
[DisplayName("Statement")]
public record Statement54
{
    /// <summary>
    /// Date or period of the statement.
    /// </summary>
    [IsoId("_8QbA35NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Date Or Period")]
    [IsoXmlTag("StmtDtOrPrd")]
    public DateAndPeriod1Choice_? StatementDateOrPeriod { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_8QbA55NLEeWGlc8L7oPDIg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency26Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_8QbA75NLEeWGlc8L7oPDIg")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType16Choice_? UpdateType { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_8QbA95NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public StatementBasis9Choice_? StatementBasis { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_8QbA_5NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public StatementType6Choice_? StatementType { get; init; }
}
