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
[IsoId("_AwznWNokEeC60axPepSq7g_-179869955")]
[DisplayName("Underlying Financial Instrument")]
public record UnderlyingFinancialInstrument1
{
    /// <summary>
    /// Identification of the underlying security by an ISIN.
    /// </summary>
    [IsoId("_AwznWdokEeC60axPepSq7g_-1186868251")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification14 Identification { get; init; }

    /// <summary>
    /// Underlying financial instrument attributes to which an trade confirmation is related.
    /// </summary>
    [IsoId("_Aw9YUNokEeC60axPepSq7g_1991755167")]
    [DisplayName("Attributes")]
    [IsoXmlTag("Attrbts")]
    public FinancialInstrumentAttributes31? Attributes { get; init; }
}
