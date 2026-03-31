// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the opening and valuation conditions for the non deliverable forward.
/// </summary>
[IsoId("_lUCXwJR9Eeak6e8_Fc5fQg")]
[DisplayName("Non Deliverable Forward Conditions")]
public record NonDeliverableForwardConditions1
{
    /// <summary>
    /// Specifies whether the instruction is an NDF opening or fixing.
    /// </summary>
    [IsoId("_OiuGoJR-Eeak6e8_Fc5fQg")]
    [DisplayName("Opening Indicator")]
    [IsoXmlTag("OpngInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator OpeningIndicator { get; init; }

    /// <summary>
    /// Specifies either the conditions for an NDF oepning or an NDF fixing confirmation.
    /// </summary>
    [IsoId("_MFrkkJUPEeak6e8_Fc5fQg")]
    [DisplayName("Opening Fixing Conditions")]
    [IsoXmlTag("OpngFxgConds")]
    public required NDFOpeningFixing1Choice_ OpeningFixingConditions { get; init; }
}
