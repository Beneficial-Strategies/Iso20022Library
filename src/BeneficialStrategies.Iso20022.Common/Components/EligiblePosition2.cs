// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the voting entitlement.
/// </summary>
[IsoId("_R_4yK9p-Ed-ak6NoX_4Aeg_968137287")]
[DisplayName("Eligible Position")]
public record EligiblePosition2
{
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_R_4yLNp-Ed-ak6NoX_4Aeg_968137289")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Identifies party that legally owns the account.
    /// </summary>
    [IsoId("_SACjINp-Ed-ak6NoX_4Aeg_753462259")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification9Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_SACjIdp-Ed-ak6NoX_4Aeg_1972671566")]
    [DisplayName("Holding Balance")]
    [IsoXmlTag("HldgBal")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<HoldingBalance3> HoldingBalance { get; init; } = [];

    /// <summary>
    /// Identifies owner of the voting rights.
    /// </summary>
    [IsoId("_SACjItp-Ed-ak6NoX_4Aeg_757155583")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification9Choice_> RightsHolder { get; init; } = [];
}
