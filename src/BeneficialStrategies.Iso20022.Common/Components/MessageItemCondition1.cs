// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Presence condition of a message item.
/// </summary>
[IsoId("_K86DNH1DEeCF8NjrBemJWQ_-909229730")]
[DisplayName("Message Item Condition")]
public record MessageItemCondition1
{
    /// <summary>
    /// Unique identification of the message and the message item.
    /// </summary>
    [IsoId("_K86DNX1DEeCF8NjrBemJWQ_2010387496")]
    [DisplayName("Item Identification")]
    [IsoXmlTag("ItmId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text ItemIdentification { get; init; }

    /// <summary>
    /// Condition of presence of the message item.
    /// </summary>
    [IsoId("_K86DNn1DEeCF8NjrBemJWQ_-694076707")]
    [DisplayName("Condition")]
    [IsoXmlTag("Cond")]
    public required MessageItemCondition1Code Condition { get; init; }

    /// <summary>
    /// Value to be used for the message item.
    /// </summary>
    [IsoId("_K86DN31DEeCF8NjrBemJWQ_-1677320126")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Value { get; init; }
}
