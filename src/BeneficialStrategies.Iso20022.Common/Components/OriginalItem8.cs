// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Item8.
/// </summary>
[IsoId("_-G48ATEsEe6GxLzpkVnWYg")]
[DisplayName("Original Item8")]
public record OriginalItem8
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Expected Value Date.
    /// </summary>
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Original End To End Identification.
    /// </summary>
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Original Item Identification.
    /// </summary>
    [DisplayName("Original Item Identification")]
    [IsoXmlTag("OrgnlItmId")]
    public required IsoMax35Text OriginalItemIdentification { get; init; }

    /// <summary>
    /// Original Item Reference.
    /// </summary>
    [DisplayName("Original Item Reference")]
    [IsoXmlTag("OrgnlItmRef")]
    public OriginalItemReference7? OriginalItemReference { get; init; }

    /// <summary>
    /// UETR.
    /// </summary>
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public IsoUUIDv4Identifier? UETR { get; init; }
}
