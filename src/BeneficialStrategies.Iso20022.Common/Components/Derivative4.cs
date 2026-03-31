// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Represents different types of derivative.
/// </summary>
[IsoId("_PDS2gWp7EemmaZLSPtWX5A")]
[DisplayName("Derivative")]
public record Derivative4
{
    /// <summary>
    /// Parameters for contracts which obligate the buyer to receive and the seller to deliver in the future the assets specified at an agreed price.
    /// </summary>
    [IsoId("_PPMkgWp7EemmaZLSPtWX5A")]
    [DisplayName("Future")]
    [IsoXmlTag("Futr")]
    public Future4? Future { get; init; }

    /// <summary>
    /// Contracts which grant to the holder either the privilege to purchase or the privilege to sell the assets specified at a predetermined price or formula at or within a time in the future.
    /// </summary>
    [IsoId("_PPMkg2p7EemmaZLSPtWX5A")]
    [DisplayName("Option")]
    [IsoXmlTag("Optn")]
    public Option15? Option { get; init; }
}
