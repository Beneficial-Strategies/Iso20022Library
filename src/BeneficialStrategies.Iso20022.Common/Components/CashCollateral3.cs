// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the cash posted as collateral.
/// </summary>
[IsoId("_3yXwUWNwEeSIWbZ6by9dnA")]
[DisplayName("Cash Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashCollateral3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashCollateral3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashCollateral3( ActiveCurrencyAndAmount reqCollateralValue )
    {
        CollateralValue = reqCollateralValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_TzbnkG8HEeSo8eobdW7kLw")]
    [DisplayName("Collateral Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollId")]
    #endif
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CollateralIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralIdentification { get; init; } 
    #else
    public System.String? CollateralIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identification of the clearing member &apos;s cash account.
    /// </summary>
    [IsoId("_pst84GNzEeSIWbZ6by9dnA")]
    [DisplayName("Cash Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctId")]
    #endif
    [IsoXmlTag("CshAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? CashAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? CashAccountIdentification { get; init; } 
    #else
    public AccountIdentification4Choice_? CashAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the deposit.
    /// </summary>
    [IsoId("_4QYiAWNwEeSIWbZ6by9dnA")]
    [DisplayName("Deposit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstAmt")]
    #endif
    [IsoXmlTag("DpstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? DepositAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? DepositAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? DepositAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the deposit is fixed term or call/notice.
    /// </summary>
    [IsoId("_4QYiA2NwEeSIWbZ6by9dnA")]
    [DisplayName("Deposit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstTp")]
    #endif
    [IsoXmlTag("DpstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DepositType1Code? DepositType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DepositType1Code? DepositType { get; init; } 
    #else
    public DepositType1Code? DepositType { get; set; } 
    #endif
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_4QYiBWNwEeSIWbZ6by9dnA")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation date of the cash taken as collateral.
    /// </summary>
    [IsoId("_4QYiB2NwEeSIWbZ6by9dnA")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValueDate { get; init; } 
    #else
    public System.DateOnly? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_4QYiCWNwEeSIWbZ6by9dnA")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExchangeRate { get; init; } 
    #else
    public System.Decimal? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_4QYiC2NwEeSIWbZ6by9dnA")]
    [DisplayName("Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollVal")]
    #endif
    [IsoXmlTag("CollVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount CollateralValue { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_4QYiDWNwEeSIWbZ6by9dnA")]
    [DisplayName("Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hrcut")]
    #endif
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Haircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Haircut { get; init; } 
    #else
    public System.Decimal? Haircut { get; set; } 
    #endif
    
    
    #nullable disable
    
}
