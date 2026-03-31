// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the elements used to uniquely identify a standing order.
/// </summary>
[IsoId("_CZ-QhW4-EeiU9cctagi5ow")]
[DisplayName("Standing Order Identification")]
public record StandingOrderIdentification4
{
    /// <summary>
    /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
    /// </summary>
    [IsoId("_Cj8r424-EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.|.
    /// </summary>
    [IsoId("_Cj8r5W4-EeiU9cctagi5ow")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount38 Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Cj8r524-EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; }
}
