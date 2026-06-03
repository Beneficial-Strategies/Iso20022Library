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
[IsoId("b315373d-7975-479b-a9fd-5abb96bde549")]
[DisplayName("Message And Business Reference15")]
public record MessageAndBusinessReference15
{
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("68fea2f0-bd0e-4cd6-83d2-435b5ae7cce6")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public References87Choice_? Reference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("74920da4-01c6-4d9a-8a8b-1ac898b735d1")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifiers of one or more individual order instructions or individual order cancellation requests.
    /// </summary>
    [IsoId("25c43a49-89ae-4e7e-93ba-5226971f52fe")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public ValueList<InvestmentFundOrder12> OrderReference { get; init; } = [];
}
