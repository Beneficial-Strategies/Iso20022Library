// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains information that identifies or is specific to a transaction jurisdiction.
/// </summary>
[IsoId("_uh9kAMVaEeuips4fuphvoQ")]
[DisplayName("Jurisdiction")]
public record Jurisdiction2
{
    /// <summary>
    /// When true, indicates the transaction is considered to be domestic.
    /// </summary>
    [IsoId("_YK-ecMVbEeuips4fuphvoQ")]
    [DisplayName("Domestic Indicator")]
    [IsoXmlTag("DmstInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DomesticIndicator { get; init; }

    /// <summary>
    /// Identifies the reason the transaction is considered to be domestic or non-domestic.
    /// </summary>
    [IsoId("_eot98MVbEeuips4fuphvoQ")]
    [DisplayName("Domestic Qualification")]
    [IsoXmlTag("DmstQlfctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DomesticQualification { get; init; }
}
