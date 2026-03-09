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
/// Identifies the return excess cash type and the collateral currency.
/// </summary>
[IsoId("_hAr8AALpEeutW5-TpeYJhA")]
[DisplayName("Return Excess Cash")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReturnExcessCash1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReturnExcessCash1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReturnExcessCash1( ReturnExcessCash1Choice_ reqReturnExcessCashType,string reqCashCollateralCurrency )
    {
        ReturnExcessCashType = reqReturnExcessCashType;
        CashCollateralCurrency = reqCashCollateralCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the return excess cash type.
    /// </summary>
    [IsoId("_8whgIALpEeutW5-TpeYJhA")]
    [DisplayName("Return Excess Cash Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrXcssCshTp")]
    #endif
    [IsoXmlTag("RtrXcssCshTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReturnExcessCash1Choice_ ReturnExcessCashType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReturnExcessCash1Choice_ ReturnExcessCashType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReturnExcessCash1Choice_ ReturnExcessCashType { get; init; } 
    #else
    public ReturnExcessCash1Choice_ ReturnExcessCashType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the cash collateral.
    /// </summary>
    [IsoId("_I7x8EALqEeutW5-TpeYJhA")]
    [DisplayName("Cash Collateral Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCollCcy")]
    #endif
    [IsoXmlTag("CshCollCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode CashCollateralCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CashCollateralCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CashCollateralCurrency { get; init; } 
    #else
    public string CashCollateralCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
