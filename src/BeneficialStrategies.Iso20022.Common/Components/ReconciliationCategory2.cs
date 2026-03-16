// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies categories of statuses of a derivative when there is no reporting requirement for both counterparties.
/// </summary>
[IsoId("_yeZ-MT6CEe2Z1_pdMHu4SA")]
[DisplayName("Reconciliation Category")]
public record ReconciliationCategory2
{
    /// <summary>
    /// Indicator of derivative reopening, terminated or cancelled by mistake.
    /// </summary>
    [IsoId("_yfOdmT6CEe2Z1_pdMHu4SA")]
    [DisplayName("Revived")]
    [IsoXmlTag("Rvvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Revived { get; init; }

    /// <summary>
    /// Indicator of modification to the terms or details of a previously reported derivative, at a trade or position level, but not a correction of a report.
    /// </summary>
    [IsoId("_yfOdmz6CEe2Z1_pdMHu4SA")]
    [DisplayName("Further Modification")]
    [IsoXmlTag("FrthrMod")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator FurtherModification { get; init; }
}
