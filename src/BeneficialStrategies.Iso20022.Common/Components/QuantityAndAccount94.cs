// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on a quantity, account and other related information.
/// </summary>
[IsoId("_fp1QFffYEeiNZp_PtLohLw")]
[DisplayName("Quantity And Account")]
public record QuantityAndAccount94
{
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_fp1QHffYEeiNZp_PtLohLw")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public Quantity10Choice_? SettlementQuantity { get; init; }

    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    [IsoId("_fp1QH_fYEeiNZp_PtLohLw")]
    [DisplayName("Denomination Choice")]
    [IsoXmlTag("DnmtnChc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINXMax210Text? DenominationChoice { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_fp1QIffYEeiNZp_PtLohLw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification156? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_fp1QI_fYEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount30? SafekeepingAccount { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_fp1QJffYEeiNZp_PtLohLw")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification6Choice_? CashAccount { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_fp1QJ_fYEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace4? SafekeepingPlace { get; init; }

    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_fp1QKffYEeiNZp_PtLohLw")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown48> QuantityBreakdown { get; init; } = [];
}
