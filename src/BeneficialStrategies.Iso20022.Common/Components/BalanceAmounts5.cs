// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_WQRpQtp-Ed-ak6NoX_4Aeg_1054605263")]
[DisplayName("Balance Amounts")]
public partial record BalanceAmounts5
{
    #nullable enable
    
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_WQRpQ9p-Ed-ak6NoX_4Aeg_1004561672")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public required AmountAndDirection14 HoldingValue { get; init; } 
    
    /// <summary>
    /// Previous value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_WQRpRNp-Ed-ak6NoX_4Aeg_-1103422100")]
    [DisplayName("Previous Holding Value")]
    [IsoXmlTag("PrvsHldgVal")]
    public AmountAndDirection14? PreviousHoldingValue { get; init; } 
    
    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    [IsoId("_WQRpRdp-Ed-ak6NoX_4Aeg_-425897652")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection14? BookValue { get; init; } 
    
    /// <summary>
    /// Difference between holding value and the book value.
    /// </summary>
    [IsoId("_WQRpRtp-Ed-ak6NoX_4Aeg_1761085872")]
    [DisplayName("Unrealised Gain Loss")]
    [IsoXmlTag("UrlsdGnLoss")]
    public AmountAndDirection14? UnrealisedGainLoss { get; init; } 
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_WQRpR9p-Ed-ak6NoX_4Aeg_-1116292121")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection14? AccruedInterestAmount { get; init; } 
    
    
    #nullable disable
    
}
