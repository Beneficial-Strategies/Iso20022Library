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
[IsoId("_VK_cO9p-Ed-ak6NoX_4Aeg_1813959824")]
[DisplayName("Aggregate Balance Information")]
public partial record AggregateBalanceInformation1
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_VK_cPNp-Ed-ak6NoX_4Aeg_957766415")]
    [DisplayName("Aggregate Quantity")]
    [IsoXmlTag("AggtQty")]
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; } 
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is available.
    /// </summary>
    [IsoId("_VK_cPdp-Ed-ak6NoX_4Aeg_1267147930")]
    [DisplayName("Available Quantity")]
    [IsoXmlTag("AvlblQty")]
    public BalanceQuantity1Choice_? AvailableQuantity { get; init; } 
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is not available.
    /// </summary>
    [IsoId("_VLImINp-Ed-ak6NoX_4Aeg_1341028675")]
    [DisplayName("Not Available Quantity")]
    [IsoXmlTag("NotAvlblQty")]
    public BalanceQuantity1Choice_? NotAvailableQuantity { get; init; } 
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_VLImIdp-Ed-ak6NoX_4Aeg_-1779218939")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; } 
    
    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_VLImItp-Ed-ak6NoX_4Aeg_-1535411945")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public ActiveOrHistoricCurrencyAndAmount? HoldingValue { get; init; } 
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_VLImI9p-Ed-ak6NoX_4Aeg_-1521558077")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_VLImJNp-Ed-ak6NoX_4Aeg_-1293449412")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_VLImJdp-Ed-ak6NoX_4Aeg_822246301")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormatChoice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Security held on the account for which the balance is calculated.
    /// </summary>
    [IsoId("_VLImJtp-Ed-ak6NoX_4Aeg_1119190942")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument4 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_VLImJ9p-Ed-ak6NoX_4Aeg_-1877647934")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation1? PriceDetails { get; init; } 
    
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_VLImKNp-Ed-ak6NoX_4Aeg_-2117590231")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FrgnXchgDtls")]
    public ForeignExchangeTerms3? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_VLImKdp-Ed-ak6NoX_4Aeg_-957311041")]
    [DisplayName("Balance Breakdown Details")]
    [IsoXmlTag("BalBrkdwnDtls")]
    public SubBalanceInformation1? BalanceBreakdownDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_VLSXINp-Ed-ak6NoX_4Aeg_451173603")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public AdditionalBalanceInformation? AdditionalBalanceBreakdownDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
    /// </summary>
    [IsoId("_VLSXIdp-Ed-ak6NoX_4Aeg_-1070903194")]
    [DisplayName("Balance At Safekeeping Place")]
    [IsoXmlTag("BalAtSfkpgPlc")]
    public AggregateBalancePerSafekeepingPlace1? BalanceAtSafekeepingPlace { get; init; } 
    
    
    #nullable disable
    
}
