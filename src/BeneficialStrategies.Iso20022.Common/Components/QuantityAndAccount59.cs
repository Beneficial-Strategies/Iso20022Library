// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the quantity, account and other related information involved in a transaction.
/// </summary>
[IsoId("_LlLWcaWgEeatOerspsHe_g")]
[DisplayName("Quantity And Account")]
public record QuantityAndAccount59
{
    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    [IsoId("_L0gL4aWgEeatOerspsHe_g")]
    [DisplayName("Denomination Choice")]
    [IsoXmlTag("DnmtnChc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINXMax210Text? DenominationChoice { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_L0gL46WgEeatOerspsHe_g")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification119? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_L0gL5aWgEeatOerspsHe_g")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification6Choice_? CashAccount { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_L0gL56WgEeatOerspsHe_g")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace2? SafekeepingPlace { get; init; }

    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series, etc.
    /// </summary>
    [IsoId("_L0gL6aWgEeatOerspsHe_g")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown38> QuantityBreakdown { get; init; } = [];
}
