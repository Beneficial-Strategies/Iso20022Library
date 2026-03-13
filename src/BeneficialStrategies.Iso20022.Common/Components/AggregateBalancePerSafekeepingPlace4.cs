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
[IsoId("_R-sfXNp-Ed-ak6NoX_4Aeg_247962641")]
[DisplayName("Aggregate Balance Per Safekeeping Place")]
public partial record AggregateBalancePerSafekeepingPlace4
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_R-2QUNp-Ed-ak6NoX_4Aeg_247962660")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required BalanceQuantity1Choice_ AggregateBalance { get; init; } 
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_R-2QUdp-Ed-ak6NoX_4Aeg_247962901")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; } 
    
    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_R-2QUtp-Ed-ak6NoX_4Aeg_247962918")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> HoldingValue { get; init; } = [];
    // ID for the above is _R-2QUtp-Ed-ak6NoX_4Aeg_247962918
    
    /// <summary>
    /// Previous total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_R-2QU9p-Ed-ak6NoX_4Aeg_643228530")]
    [DisplayName("Previous Holding Value")]
    [IsoXmlTag("PrvsHldgVal")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousHoldingValue { get; init; } 
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_R-2QVNp-Ed-ak6NoX_4Aeg_247962936")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether the accrued interest is a positive or negative amount.
    /// </summary>
    [IsoId("_R-2QVdp-Ed-ak6NoX_4Aeg_931369469")]
    [DisplayName("Accrued Interest Amount Sign")]
    [IsoXmlTag("AcrdIntrstAmtSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? AccruedInterestAmountSign { get; init; } 
    
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_R-2QVtp-Ed-ak6NoX_4Aeg_247962953")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Securities Depository (ICSD).
    /// </summary>
    [IsoId("_R-2QV9p-Ed-ak6NoX_4Aeg_247962996")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafekeepingPlaceFormatChoice_ SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_R-2QWNp-Ed-ak6NoX_4Aeg_247963400")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation2> PriceDetails { get; init; } = [];
    // ID for the above is _R-2QWNp-Ed-ak6NoX_4Aeg_247963400
    
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_R-2QWdp-Ed-ak6NoX_4Aeg_247963340")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_R-_aQNp-Ed-ak6NoX_4Aeg_247963074")]
    [DisplayName("Balance Breakdown Details")]
    [IsoXmlTag("BalBrkdwnDtls")]
    public SubBalanceInformation2? BalanceBreakdownDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_R-_aQdp-Ed-ak6NoX_4Aeg_247963033")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; init; } 
    
    
    #nullable disable
    
}
