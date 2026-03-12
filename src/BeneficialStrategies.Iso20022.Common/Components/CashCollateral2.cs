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
[IsoId("_2ysxIWNyEeSIWbZ6by9dnA")]
[DisplayName("Cash Collateral")]
public partial record CashCollateral2
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_ipL8oHbjEeS6_fJs6jm_Kw")]
    [DisplayName("Collateral Identification")]
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CollateralIdentification { get; init; } 
    
    /// <summary>
    /// Provides the identification of the clearing member &apos;s cash account.
    /// </summary>
    [IsoId("_DW0ZAGNzEeSIWbZ6by9dnA")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public AccountIdentification4Choice_? CashAccountIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether excess of cash should be returned or not.
    /// </summary>
    [IsoId("_i9w8IGN0EeSIWbZ6by9dnA")]
    [DisplayName("Return Excess")]
    [IsoXmlTag("RtrXcss")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReturnExcess { get; init; } 
    
    /// <summary>
    /// Amount of the deposit.
    /// </summary>
    [IsoId("_3SJGMWNyEeSIWbZ6by9dnA")]
    [DisplayName("Deposit Amount")]
    [IsoXmlTag("DpstAmt")]
    public ActiveCurrencyAndAmount? DepositAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the deposit is fixed term or call/notice.
    /// </summary>
    [IsoId("_3SJGM2NyEeSIWbZ6by9dnA")]
    [DisplayName("Deposit Type")]
    [IsoXmlTag("DpstTp")]
    public DepositType1Code? DepositType { get; init; } 
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_3SJGNWNyEeSIWbZ6by9dnA")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; } 
    
    /// <summary>
    /// Valuation date of the cash taken as collateral.
    /// </summary>
    [IsoId("_3SJGN2NyEeSIWbZ6by9dnA")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; } 
    
    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_3SJGOWNyEeSIWbZ6by9dnA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_3SJGO2NyEeSIWbZ6by9dnA")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    
    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_3SJGPWNyEeSIWbZ6by9dnA")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; } 
    
    
    #nullable disable
    
}
