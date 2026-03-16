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
[IsoId("_CfguYRKwEeKj15WxqwlXPw")]
[DisplayName("Modification Scope")]
public record ModificationScope13
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_C1j24RKwEeKj15WxqwlXPw")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification2Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Information related to the account to be modified.
    /// </summary>
    [IsoId("_C1j25RKwEeKj15WxqwlXPw")]
    [DisplayName("Fund Details")]
    [IsoXmlTag("FndDtls")]
    public required FinancialInstrument29 FundDetails { get; init; }
}
