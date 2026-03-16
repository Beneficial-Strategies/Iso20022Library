// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies underlying instruments or index a derivative has.
/// </summary>
[IsoId("_FvixRZ3EEeuwmdq0KtnICg")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument98
{
    /// <summary>
    /// Identification of the index on which the financial instrument is based.
    /// </summary>
    [IsoId("_GHFukZ3EEeuwmdq0KtnICg")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISIN2021Identifier)]
    public IsoISIN2021Identifier? ISIN { get; init; }

    /// <summary>
    /// Name of the index on which the financial instrument is based.
    /// </summary>
    [IsoId("_GHFuk53EEeuwmdq0KtnICg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required FloatingInterestRate8 Name { get; init; }
}
