// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account identification information.
/// </summary>
[IsoId("_qVQlL-aPEd-q8fx_Zl_34A")]
[DisplayName("Account Identification")]
public record AccountIdentification18
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_qVQlMeaPEd-q8fx_Zl_34A")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_qVQlM-aPEd-q8fx_Zl_34A")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification36Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_qVQlNeaPEd-q8fx_Zl_34A")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    [IsoId("_qVQlN-aPEd-q8fx_Zl_34A")]
    [DisplayName("Confirmed Balance")]
    [IsoXmlTag("ConfdBal")]
    public required BalanceFormat1Choice_ ConfirmedBalance { get; init; }
}
