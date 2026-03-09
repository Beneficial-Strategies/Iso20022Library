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
/// Provides the details on the margin calculation per financial instrument or per currency.
/// </summary>
[IsoId("_-d50FKMOEeCojJW5vEuTEQ_1366752768")]
[DisplayName("Margin Calculation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCalculation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginCalculation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginCalculation2( AmountAndDirection20 reqTotalMarginAmount )
    {
        TotalMarginAmount = reqTotalMarginAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_-d50FaMOEeCojJW5vEuTEQ_517225011")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Net total of the transaction exposure of all outstanding deals.
    /// </summary>
    [IsoId("_-d50FqMOEeCojJW5vEuTEQ_-479847342")]
    [DisplayName("Exposure Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrAmt")]
    #endif
    [IsoXmlTag("XpsrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2? ExposureAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2? ExposureAmount { get; init; } 
    #else
    public Amount2? ExposureAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the total margin amount.
    /// </summary>
    [IsoId("_-d50F6MOEeCojJW5vEuTEQ_-118385344")]
    [DisplayName("Total Margin Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlMrgnAmt")]
    #endif
    [IsoXmlTag("TtlMrgnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection20 TotalMarginAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection20 TotalMarginAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection20 TotalMarginAmount { get; init; } 
    #else
    public AmountAndDirection20 TotalMarginAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the valuation of the collateral on deposit.
    /// </summary>
    [IsoId("_-eDlEKMOEeCojJW5vEuTEQ_-2053475098")]
    [DisplayName("Collateral On Deposit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollOnDpst")]
    #endif
    [IsoXmlTag("CollOnDpst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Collateral6? CollateralOnDeposit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Collateral6? CollateralOnDeposit { get; init; } 
    #else
    public Collateral6? CollateralOnDeposit { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum requirement (expressed in the reporting currency) for a participant if their requirement falls below a specific amount set by the central counterparty.
    /// </summary>
    [IsoId("_-eDlEaMOEeCojJW5vEuTEQ_179304187")]
    [DisplayName("Minimum Requirement Deposit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinRqrmntDpst")]
    #endif
    [IsoXmlTag("MinRqrmntDpst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MinimumRequirementDeposit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MinimumRequirementDeposit { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MinimumRequirementDeposit { get; set; } 
    #endif
    
    /// <summary>
    /// Provide details on the margin result taking into consideration the total margin amount and the minimum requirements deposit.
    /// </summary>
    [IsoId("_-eDlEqMOEeCojJW5vEuTEQ_1244419845")]
    [DisplayName("Margin Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnRslt")]
    #endif
    [IsoXmlTag("MrgnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginResult1Choice_? MarginResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginResult1Choice_? MarginResult { get; init; } 
    #else
    public MarginResult1Choice_? MarginResult { get; set; } 
    #endif
    
    /// <summary>
    /// Provides margin calculation details such as the initial margin amount, the variation margin amount or other margin type amounts.
    /// </summary>
    [IsoId("_-eDlE6MOEeCojJW5vEuTEQ_-640461449")]
    [DisplayName("Margin Type Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnTpAmt")]
    #endif
    [IsoXmlTag("MrgnTpAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Margin3? MarginTypeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Margin3? MarginTypeAmount { get; init; } 
    #else
    public Margin3? MarginTypeAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
