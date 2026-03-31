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
[IsoId("_UbTrv9p-Ed-ak6NoX_4Aeg_1619096303")]
[DisplayName("Quantity And Account")]
public record QuantityAndAccount6
{
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_Ubc1oNp-Ed-ak6NoX_4Aeg_383753548")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required Quantity6Choice_ SettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_Ubc1odp-Ed-ak6NoX_4Aeg_1619096948")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_Ubc1otp-Ed-ak6NoX_4Aeg_1619096905")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    [IsoId("_Ubc1o9p-Ed-ak6NoX_4Aeg_1764919041")]
    [DisplayName("Previously Settled Amount")]
    [IsoXmlTag("PrevslySttldAmt")]
    public AmountAndDirection5? PreviouslySettledAmount { get; init; }

    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    [IsoId("_Ubc1pNp-Ed-ak6NoX_4Aeg_1622699680")]
    [DisplayName("Remaining To Be Settled Amount")]
    [IsoXmlTag("RmngToBeSttldAmt")]
    public AmountAndDirection5? RemainingToBeSettledAmount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Ubc1pdp-Ed-ak6NoX_4Aeg_1619096750")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification13Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Ubc1ptp-Ed-ak6NoX_4Aeg_1619097260")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount13 SafekeepingAccount { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_Ubc1p9p-Ed-ak6NoX_4Aeg_1619096329")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_Ubc1qNp-Ed-ak6NoX_4Aeg_144007370")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; }
}
