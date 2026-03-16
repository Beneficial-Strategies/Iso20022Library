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
[IsoId("_RRZUeNp-Ed-ak6NoX_4Aeg_1545333466")]
[DisplayName("Modification Scope")]
public record ModificationScope11
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RRjFcNp-Ed-ak6NoX_4Aeg_1545333484")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification2Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Detailed information about the party profile information.
    /// </summary>
    [IsoId("_RRjFcdp-Ed-ak6NoX_4Aeg_-1567528514")]
    [DisplayName("Investor Profile Validation")]
    [IsoXmlTag("InvstrPrflVldtn")]
    public required PartyProfileInformation1 InvestorProfileValidation { get; init; }
}
