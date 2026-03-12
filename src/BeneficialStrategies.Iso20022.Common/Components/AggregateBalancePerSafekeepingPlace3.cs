// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_R-_aRdp-Ed-ak6NoX_4Aeg_1472551753")]
[DisplayName("Aggregate Balance Per Safekeeping Place")]
public partial record AggregateBalancePerSafekeepingPlace3
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_R-_aRtp-Ed-ak6NoX_4Aeg_1472551779")]
    [DisplayName("Aggregate Quantity")]
    [IsoXmlTag("AggtQty")]
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; } 
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is available.
    /// </summary>
    [IsoId("_R-_aR9p-Ed-ak6NoX_4Aeg_1472551795")]
    [DisplayName("Available Quantity")]
    [IsoXmlTag("AvlblQty")]
    public BalanceQuantity1Choice_? AvailableQuantity { get; init; } 
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is not available.
    /// </summary>
    [IsoId("_R-_aSNp-Ed-ak6NoX_4Aeg_1472551830")]
    [DisplayName("Not Available Quantity")]
    [IsoXmlTag("NotAvlblQty")]
    public BalanceQuantity1Choice_? NotAvailableQuantity { get; init; } 
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_R-_aSdp-Ed-ak6NoX_4Aeg_1472551848")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; } 
    
    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_R-_aStp-Ed-ak6NoX_4Aeg_1472551873")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public ActiveOrHistoricCurrencyAndAmount? HoldingValue { get; init; } 
    
    /// <summary>
    /// Previous total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_R_JLQNp-Ed-ak6NoX_4Aeg_1824415231")]
    [DisplayName("Previous Holding Value")]
    [IsoXmlTag("PrvsHldgVal")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousHoldingValue { get; init; } 
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_R_JLQdp-Ed-ak6NoX_4Aeg_1472551890")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether the accrued interest is a positive or negative amount.
    /// </summary>
    [IsoId("_R_JLQtp-Ed-ak6NoX_4Aeg_1824415266")]
    [DisplayName("Accrued Interest Amount Sign")]
    [IsoXmlTag("AcrdIntrstAmtSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? AccruedInterestAmountSign { get; init; } 
    
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_R_JLQ9p-Ed-ak6NoX_4Aeg_1472551908")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_R_JLRNp-Ed-ak6NoX_4Aeg_1472552181")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafekeepingPlaceFormatChoice_ SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_R_JLRdp-Ed-ak6NoX_4Aeg_1472552243")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation2? PriceDetails { get; init; } 
    
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_R_JLRtp-Ed-ak6NoX_4Aeg_1472552276")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_R_JLR9p-Ed-ak6NoX_4Aeg_1472552294")]
    [DisplayName("Balance Breakdown Details")]
    [IsoXmlTag("BalBrkdwnDtls")]
    public SubBalanceInformation2? BalanceBreakdownDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_R_JLSNp-Ed-ak6NoX_4Aeg_1472552337")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; init; } 
    
    
    #nullable disable
    
}
