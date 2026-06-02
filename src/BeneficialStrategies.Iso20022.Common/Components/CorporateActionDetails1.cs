// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key information about the related Corporate Action event.
/// </summary>
[IsoId("_MknmcN_FEe-Ned3-G07x_A")]
[DisplayName("Corporate Action Details1")]
public record CorporateActionDetails1
{
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_YyqQod_FEe-Ned3-G07x_A")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation195 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Selected buyer protection instructions options.
    /// </summary>
    [IsoId("_ozq2IN_FEe-Ned3-G07x_A")]
    [DisplayName("Corporate Action Option")]
    [IsoXmlTag("CorpActnOptn")]
    public required CorporateActionOptionStatement1 CorporateActionOption { get; init; }
}
