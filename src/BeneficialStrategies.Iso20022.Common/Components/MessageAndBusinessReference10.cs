// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to identify funds order(s).
/// </summary>
[IsoId("_IGLlRzbtEead9bDRE_1DAQ")]
[DisplayName("Message And Business Reference")]
public record MessageAndBusinessReference10
{
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_o3wOAEg9Eea8pJjypp-yMQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public References62Choice_? Reference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_IeuoKzbtEead9bDRE_1DAQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifiers of one or more individual order instructions or individual order cancellation requests.
    /// </summary>
    [IsoId("_IeuoLTbtEead9bDRE_1DAQ")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public ValueList<InvestmentFundOrder8> OrderReference { get; init; } = [];
}
