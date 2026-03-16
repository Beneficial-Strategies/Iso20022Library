// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides system date for all of the changes occurred for an entity.
/// </summary>
[IsoId("_QQL0hZJKEeuAlLVx8pyt3w")]
[DisplayName("Security Statement")]
public record SecurityStatement3
{
    /// <summary>
    /// Date for which the statement is valid.
    /// </summary>
    [IsoId("_QSGgEZJKEeuAlLVx8pyt3w")]
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SystemDate { get; init; }

    /// <summary>
    /// Provides information on the actual change occurred to a financial instrument.
    /// </summary>
    [IsoId("_QSGgE5JKEeuAlLVx8pyt3w")]
    [DisplayName("Change")]
    [IsoXmlTag("Chng")]
    public ValueList<SecuritiesReferenceDataChange3> Change { get; init; } = [];
}
