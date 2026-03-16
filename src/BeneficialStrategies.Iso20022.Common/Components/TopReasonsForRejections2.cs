// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the most common data field that has not passed the validation rule.
/// </summary>
[IsoId("_NeaEeVfdEeqZr5K1Woax-g")]
[DisplayName("Top Reasons For Rejections")]
public record TopReasonsForRejections2
{
    /// <summary>
    /// Identification of the most common data field that has not passed the validation rule for all derivatives.
    /// </summary>
    [IsoId("_N1g84VfdEeqZr5K1Woax-g")]
    [DisplayName("All")]
    [IsoXmlTag("All")]
    public SimpleValueList<IsoMax35Text> All { get; init; } = [];

    /// <summary>
    /// Identification of the most common data field that has not passed the validation rule for derivatives which have been reported as new.
    /// </summary>
    [IsoId("_N1g841fdEeqZr5K1Woax-g")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public SimpleValueList<IsoMax35Text> New { get; init; } = [];

    /// <summary>
    /// Identification of the most common data field that has not passed the validation rule for derivatives which have been reported as modification.
    /// </summary>
    [IsoId("_N1g85VfdEeqZr5K1Woax-g")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    public SimpleValueList<IsoMax35Text> Modification { get; init; } = [];
}
