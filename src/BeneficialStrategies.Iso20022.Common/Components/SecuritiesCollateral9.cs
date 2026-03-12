// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a security posted as collateral.
/// </summary>
[IsoId("_ffAu4QyiEeukOZYTbzKKxw")]
[DisplayName("Securities Collateral")]
public partial record SecuritiesCollateral9
{
    #nullable enable
    
    /// <summary>
    /// Register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_fy8XgQyiEeukOZYTbzKKxw")]
    [DisplayName("Asset Number")]
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AssetNumber { get; init; } 
    
    /// <summary>
    /// Identification of the security.
    /// </summary>
    [IsoId("_fy8XgwyiEeukOZYTbzKKxw")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification19 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_fy8XhQyiEeukOZYTbzKKxw")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DateAndDateTime2Choice_? MaturityDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the collateral is proprietarily owned or client owned.
    /// </summary>
    [IsoId("_fy8XhwyiEeukOZYTbzKKxw")]
    [DisplayName("Collateral Ownership")]
    [IsoXmlTag("CollOwnrsh")]
    public CollateralOwnership3? CollateralOwnership { get; init; } 
    
    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_fy8XiQyiEeukOZYTbzKKxw")]
    [DisplayName("Limited Coverage Indicator")]
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; } 
    
    /// <summary>
    /// Quantity of securities collateral.
    /// </summary>
    [IsoId("_fy8XiwyiEeukOZYTbzKKxw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Quantity blocked by the central counterparty for any reasonable reason ( for example for judicial reasons). In this case the investor can not withdraw or distribute this collateral.
    /// </summary>
    [IsoId("_fy8XjQyiEeukOZYTbzKKxw")]
    [DisplayName("Blocked Quantity")]
    [IsoXmlTag("BlckdQty")]
    public FinancialInstrumentQuantity1Choice_? BlockedQuantity { get; init; } 
    
    /// <summary>
    /// Price of the security.
    /// </summary>
    [IsoId("_fy8XjwyiEeukOZYTbzKKxw")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public Price7? Price { get; init; } 
    
    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_fy8XkQyiEeukOZYTbzKKxw")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveCurrencyAndAmount? MarketValue { get; init; } 
    
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_fy8XkwyiEeukOZYTbzKKxw")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; } 
    
    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_fy8XlQyiEeukOZYTbzKKxw")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public ActiveCurrencyAndAmount? CollateralValue { get; init; } 
    
    /// <summary>
    /// Valuation date of the securities taken as collateral.
    /// </summary>
    [IsoId("_fy8XlwyiEeukOZYTbzKKxw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_fy8XmQyiEeukOZYTbzKKxw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_fy8XmwyiEeukOZYTbzKKxw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafekeepingPlaceFormat29Choice_ SafekeepingPlace { get; init; } 
    
    
    #nullable disable
    
}
