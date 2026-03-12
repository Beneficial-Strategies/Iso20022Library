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
[IsoId("_Umx74tp-Ed-ak6NoX_4Aeg_872636126")]
[DisplayName("Cash Collateral")]
public partial record CashCollateral1
{
    #nullable enable
    
    /// <summary>
    /// Amount of the deposit.
    /// </summary>
    [IsoId("_Umx749p-Ed-ak6NoX_4Aeg_1707045906")]
    [DisplayName("Deposit Amount")]
    [IsoXmlTag("DpstAmt")]
    public ActiveCurrencyAndAmount? DepositAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the deposit is fixed term or call/notice.
    /// </summary>
    [IsoId("_Umx75Np-Ed-ak6NoX_4Aeg_201968433")]
    [DisplayName("Deposit Type")]
    [IsoXmlTag("DpstTp")]
    public DepositType1Code? DepositType { get; init; } 
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_Umx75dp-Ed-ak6NoX_4Aeg_1407164619")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; } 
    
    /// <summary>
    /// Valuation date of the cash taken as collateral.
    /// </summary>
    [IsoId("_Umx75tp-Ed-ak6NoX_4Aeg_908233328")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; } 
    
    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_Umx759p-Ed-ak6NoX_4Aeg_1333906850")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_Umx76Np-Ed-ak6NoX_4Aeg_1312061120")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    
    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_Umx76dp-Ed-ak6NoX_4Aeg_879882524")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; } 
    
    
    #nullable disable
    
}
