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
[IsoId("_VLvDFNp-Ed-ak6NoX_4Aeg_696928207")]
[DisplayName("Aggregate Balance Per Safekeeping Place")]
public partial record AggregateBalancePerSafekeepingPlace2
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_VLvDFdp-Ed-ak6NoX_4Aeg_1033087509")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required BalanceQuantity1Choice_ AggregateBalance { get; init; } 
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_VLvDFtp-Ed-ak6NoX_4Aeg_1033088301")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; } 
    
    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_VLvDF9p-Ed-ak6NoX_4Aeg_1033088415")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> HoldingValue { get; init; } = new ValueList<ActiveOrHistoricCurrencyAndAmount>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VLvDF9p-Ed-ak6NoX_4Aeg_1033088415
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_VLvDGNp-Ed-ak6NoX_4Aeg_1033088517")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_VLvDGdp-Ed-ak6NoX_4Aeg_1033088847")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Securities Depository (ICSD).
    /// </summary>
    [IsoId("_VLvDGtp-Ed-ak6NoX_4Aeg_1033088942")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafekeepingPlaceFormatChoice_ SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_VLvDG9p-Ed-ak6NoX_4Aeg_1210403344")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation1> PriceDetails { get; init; } = new ValueList<PriceInformation1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VLvDG9p-Ed-ak6NoX_4Aeg_1210403344
    
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_VL40ENp-Ed-ak6NoX_4Aeg_-1648443037")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FrgnXchgDtls")]
    public ForeignExchangeTerms3? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_VL40Edp-Ed-ak6NoX_4Aeg_1222411582")]
    [DisplayName("Balance Breakdown Details")]
    [IsoXmlTag("BalBrkdwnDtls")]
    public SubBalanceInformation1? BalanceBreakdownDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_VL40Etp-Ed-ak6NoX_4Aeg_1235339477")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public AdditionalBalanceInformation? AdditionalBalanceBreakdownDetails { get; init; } 
    
    
    #nullable disable
    
}
