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
/// Provides the total margin amount, the collateral amount on deposit and the total minimum requirement that used to calculate the margin result, either an excess or a deficit.
/// </summary>
[IsoId("_-dwqLKMOEeCojJW5vEuTEQ_1443454160")]
[DisplayName("Margin Calculation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCalculation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginCalculation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginCalculation1( AmountAndDirection20 reqTotalMarginAmount )
    {
        TotalMarginAmount = reqTotalMarginAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total margin requirement (expressed in the reporting currency) that must be provided by the clearing member to the central counterparty. This is the total requirement calculated to cover the initial margin and the variation margin.
    /// </summary>
    [IsoId("_-d50EKMOEeCojJW5vEuTEQ_536108073")]
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
    [IsoId("_-d50EaMOEeCojJW5vEuTEQ_-1508761602")]
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
    [IsoId("_-d50EqMOEeCojJW5vEuTEQ_-2109217986")]
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
    [IsoId("_-d50E6MOEeCojJW5vEuTEQ_193184719")]
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
    
    
    #nullable disable
    
}
