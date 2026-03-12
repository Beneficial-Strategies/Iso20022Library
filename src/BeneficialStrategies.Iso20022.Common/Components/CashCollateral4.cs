// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the cash posted as collateral.
/// </summary>
[IsoId("_vgU7MWQsEeSTN56gbbyx2g")]
[DisplayName("Cash Collateral")]
public partial record CashCollateral4
{
    #nullable enable
    
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_zYpPEW85EeSYoqRdI5bS5Q")]
    [DisplayName("Asset Number")]
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AssetNumber { get; init; } 
    
    /// <summary>
    /// Amount of the deposit.
    /// </summary>
    [IsoId("_v9exQWQsEeSTN56gbbyx2g")]
    [DisplayName("Deposit Amount")]
    [IsoXmlTag("DpstAmt")]
    public ActiveCurrencyAndAmount? DepositAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the deposit is fixed term or call/notice.
    /// </summary>
    [IsoId("_v9exQ2QsEeSTN56gbbyx2g")]
    [DisplayName("Deposit Type")]
    [IsoXmlTag("DpstTp")]
    public DepositType1Code? DepositType { get; init; } 
    
    /// <summary>
    /// Amount blocked by the central counterparty for any reasonable reason ( for example for judicial reasons). In this case the investor can not withdraw or distribute this collateral.
    /// </summary>
    [IsoId("_-aRyAGQsEeSTN56gbbyx2g")]
    [DisplayName("Blocked Amount")]
    [IsoXmlTag("BlckdAmt")]
    public ActiveCurrencyAndAmount? BlockedAmount { get; init; } 
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_v9exRWQsEeSTN56gbbyx2g")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; } 
    
    /// <summary>
    /// Valuation date of the cash taken as collateral.
    /// </summary>
    [IsoId("_v9exR2QsEeSTN56gbbyx2g")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; } 
    
    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_v9exSWQsEeSTN56gbbyx2g")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_v9exS2QsEeSTN56gbbyx2g")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    
    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_v9exTWQsEeSTN56gbbyx2g")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; } 
    
    
    #nullable disable
    
}
