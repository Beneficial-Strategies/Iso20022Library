// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation Category4.
/// </summary>
[IsoId("_x8xuBa-8Ee69JssYImngCA")]
[DisplayName("Reconciliation Category4")]
public record ReconciliationCategory4
{
    /// <summary>
    /// Further Modification.
    /// </summary>
    [DisplayName("Further Modification")]
    [IsoXmlTag("FrthrMod")]
    public required IsoYesNoIndicator FurtherModification { get; init; }

    /// <summary>
    /// Revived.
    /// </summary>
    [DisplayName("Revived")]
    [IsoXmlTag("Rvvd")]
    public required IsoYesNoIndicator Revived { get; init; }
}
