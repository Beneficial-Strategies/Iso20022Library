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
[IsoId("_w8kXkRRyEeOKWo1NF21OVw")]
[DisplayName("Modification Scope")]
public record ModificationScope19
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_xUE4oRRyEeOKWo1NF21OVw")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification2Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Detailed information about the party profile information.
    /// </summary>
    [IsoId("_xUE4oxRyEeOKWo1NF21OVw")]
    [DisplayName("Investor Profile Validation")]
    [IsoXmlTag("InvstrPrflVldtn")]
    public required PartyProfileInformation3 InvestorProfileValidation { get; init; }
}
