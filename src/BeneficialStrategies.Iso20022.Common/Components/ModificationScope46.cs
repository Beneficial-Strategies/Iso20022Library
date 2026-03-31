// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_xm55Ee6UEemVDc1WJaqofw")]
[DisplayName("Modification Scope")]
public record ModificationScope46
{
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_x8B0ge6UEemVDc1WJaqofw")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Information used to determine fees and types of operations that can be carried out on the account.
    /// </summary>
    [IsoId("_x8B0g-6UEemVDc1WJaqofw")]
    [DisplayName("Investor Profile")]
    [IsoXmlTag("InvstrPrfl")]
    public required InvestorProfile2 InvestorProfile { get; init; }
}
