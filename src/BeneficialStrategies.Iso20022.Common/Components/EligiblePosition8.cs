// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the voting entitlement for rights holders.
/// </summary>
[IsoId("_VIOZJ67yEemG7MmivSuE5g")]
[DisplayName("Eligible Position")]
public record EligiblePosition8
{
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_Vcv3pa7yEemG7MmivSuE5g")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Vcv3p67yEemG7MmivSuE5g")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification223? AccountOwner { get; init; }

    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, for example, sub-balance per status.
    /// </summary>
    [IsoId("_Vcv3qa7yEemG7MmivSuE5g")]
    [DisplayName("Holding Balance")]
    [IsoXmlTag("HldgBal")]
    [MinLength(0)]
    [MaxLength(15)]
    public ValueList<HoldingBalance9> HoldingBalance { get; init; } = [];

    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_Vcv3q67yEemG7MmivSuE5g")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification231> RightsHolder { get; init; } = [];
}
