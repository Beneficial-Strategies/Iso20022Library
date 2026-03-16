// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Underlying financial instrument to which an trade confirmation is related.
/// </summary>
[IsoId("_P3mnMRkOEeKSublfJr3XCg")]
[DisplayName("Underlying Financial Instrument")]
public record UnderlyingFinancialInstrument2
{
    /// <summary>
    /// Identification of the underlying security by an ISIN.
    /// </summary>
    [IsoId("_QQV3URkOEeKSublfJr3XCg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification14 Identification { get; init; }

    /// <summary>
    /// Underlying financial instrument attributes to which an trade confirmation is related.
    /// </summary>
    [IsoId("_QQV3WxkOEeKSublfJr3XCg")]
    [DisplayName("Attributes")]
    [IsoXmlTag("Attrbts")]
    public FinancialInstrumentAttributes44? Attributes { get; init; }
}
