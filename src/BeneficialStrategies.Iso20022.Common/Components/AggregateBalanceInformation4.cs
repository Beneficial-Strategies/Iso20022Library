// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account. A securities balance is calculated from the sum of securities&apos; receipts minus the sum of securities&apos; deliveries.
/// </summary>
[IsoId("_R_SVNtp-Ed-ak6NoX_4Aeg_1705166747")]
[DisplayName("Aggregate Balance Information")]
public partial record AggregateBalanceInformation4
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_R_SVN9p-Ed-ak6NoX_4Aeg_1705166749")]
    [DisplayName("Aggregate Quantity")]
    [IsoXmlTag("AggtQty")]
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; } 
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is available.
    /// </summary>
    [IsoId("_R_SVONp-Ed-ak6NoX_4Aeg_1705166764")]
    [DisplayName("Available Quantity")]
    [IsoXmlTag("AvlblQty")]
    public BalanceQuantity1Choice_? AvailableQuantity { get; init; } 
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is not available.
    /// </summary>
    [IsoId("_R_SVOdp-Ed-ak6NoX_4Aeg_1705166842")]
    [DisplayName("Not Available Quantity")]
    [IsoXmlTag("NotAvlblQty")]
    public BalanceQuantity1Choice_? NotAvailableQuantity { get; init; } 
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_R_SVOtp-Ed-ak6NoX_4Aeg_1705166867")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; } 
    
    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_R_SVO9p-Ed-ak6NoX_4Aeg_1705166884")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public ActiveOrHistoricCurrencyAndAmount? HoldingValue { get; init; } 
    
    /// <summary>
    /// Previous total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_R_SVPNp-Ed-ak6NoX_4Aeg_-800017737")]
    [DisplayName("Previous Holding Value")]
    [IsoXmlTag("PrvsHldgVal")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousHoldingValue { get; init; } 
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_R_cGMNp-Ed-ak6NoX_4Aeg_1705166902")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether the accrued interest is a positive or negative amount.
    /// </summary>
    [IsoId("_R_cGMdp-Ed-ak6NoX_4Aeg_-761228933")]
    [DisplayName("Accrued Interest Amount Sign")]
    [IsoXmlTag("AcrdIntrstAmtSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? AccruedInterestAmountSign { get; init; } 
    
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_R_cGMtp-Ed-ak6NoX_4Aeg_1705167154")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_R_cGM9p-Ed-ak6NoX_4Aeg_1705167179")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormatChoice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Security held on the account for which the balance is calculated.
    /// </summary>
    [IsoId("_R_cGNNp-Ed-ak6NoX_4Aeg_1705167660")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_R_cGNdp-Ed-ak6NoX_4Aeg_1705167618")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation2? PriceDetails { get; init; } 
    
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_R_cGNtp-Ed-ak6NoX_4Aeg_1705167583")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_R_cGN9p-Ed-ak6NoX_4Aeg_1705167257")]
    [DisplayName("Balance Breakdown Details")]
    [IsoXmlTag("BalBrkdwnDtls")]
    public SubBalanceInformation2? BalanceBreakdownDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_R_l3MNp-Ed-ak6NoX_4Aeg_1705167225")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
    /// </summary>
    [IsoId("_R_l3Mdp-Ed-ak6NoX_4Aeg_1705167292")]
    [DisplayName("Balance At Safekeeping Place")]
    [IsoXmlTag("BalAtSfkpgPlc")]
    public AggregateBalancePerSafekeepingPlace3? BalanceAtSafekeepingPlace { get; init; } 
    
    
    #nullable disable
    
}
