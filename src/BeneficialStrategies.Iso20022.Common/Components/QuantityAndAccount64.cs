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
[IsoId("_8lCN0a5YEeey8N0JWnVPUw")]
[DisplayName("Quantity And Account")]
public record QuantityAndAccount64
{
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_8v4y-65YEeey8N0JWnVPUw")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required Quantity6Choice_ SettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_8v4zA65YEeey8N0JWnVPUw")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_8v4zC65YEeey8N0JWnVPUw")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    [IsoId("_8v4zE65YEeey8N0JWnVPUw")]
    [DisplayName("Previously Settled Amount")]
    [IsoXmlTag("PrevslySttldAmt")]
    public AmountAndDirection52? PreviouslySettledAmount { get; init; }

    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    [IsoId("_8v4zG65YEeey8N0JWnVPUw")]
    [DisplayName("Remaining To Be Settled Amount")]
    [IsoXmlTag("RmngToBeSttldAmt")]
    public AmountAndDirection52? RemainingToBeSettledAmount { get; init; }

    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    [IsoId("_8v4zI65YEeey8N0JWnVPUw")]
    [DisplayName("Denomination Choice")]
    [IsoXmlTag("DnmtnChc")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? DenominationChoice { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_8v4zK65YEeey8N0JWnVPUw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification98? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_8v4zM65YEeey8N0JWnVPUw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_8v4zO65YEeey8N0JWnVPUw")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_8v4zQ65YEeey8N0JWnVPUw")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown47> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_8v4zS65YEeey8N0JWnVPUw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace1? SafekeepingPlace { get; init; }
}
