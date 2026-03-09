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
/// Deal amount details.
/// </summary>
[IsoId("_gX5CYMLYEei34K_Q744LyA")]
[DisplayName("Collateral Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralAmount12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of the principal. 
    /// </summary>
    [IsoId("_7TuWsMLYEei34K_Q744LyA")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection49? Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection49? Transaction { get; init; } 
    #else
    public AmountAndDirection49? Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of principal plus interests at termination.
    /// </summary>
    [IsoId("_NttwUMLaEei34K_Q744LyA")]
    [DisplayName("Termination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Termntn")]
    #endif
    [IsoXmlTag("Termntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection49? Termination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection49? Termination { get; init; } 
    #else
    public AmountAndDirection49? Termination { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the accrued interest on the value of the principal trade, in the currency of the principal trade.
    /// </summary>
    [IsoId("_xVWwMHDLEemW9qhOy0scyg")]
    [DisplayName("Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acrd")]
    #endif
    [IsoXmlTag("Acrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection49? Accrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection49? Accrued { get; init; } 
    #else
    public AmountAndDirection49? Accrued { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the interest calculation method is simple or compounding.
    /// </summary>
    [IsoId("_3mDFwI9uEeqMo4JxiuZGSw")]
    [DisplayName("Compound Simple Accrual Calculation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpndSmplAcrlClctn")]
    #endif
    [IsoXmlTag("CmpndSmplAcrlClctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CalculationMethod1Code? CompoundSimpleAccrualCalculation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CalculationMethod1Code? CompoundSimpleAccrualCalculation { get; init; } 
    #else
    public CalculationMethod1Code? CompoundSimpleAccrualCalculation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies when the accrued interest is paid.
    /// </summary>
    [IsoId("_IWwX8I9xEeqMo4JxiuZGSw")]
    [DisplayName("Payment Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFrqcy")]
    #endif
    [IsoXmlTag("PmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency38Choice_? PaymentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency38Choice_? PaymentFrequency { get; init; } 
    #else
    public Frequency38Choice_? PaymentFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days after the accrual payment is due.
    /// </summary>
    [IsoId("_pznJQI9xEeqMo4JxiuZGSw")]
    [DisplayName("Interest Payment Delay")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPmtDely")]
    #endif
    [IsoXmlTag("IntrstPmtDely")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? InterestPaymentDelay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterestPaymentDelay { get; init; } 
    #else
    public System.String? InterestPaymentDelay { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral offered or sought. 
    /// </summary>
    [IsoId("_Ya5a4Y96EeqMo4JxiuZGSw")]
    [DisplayName("Value Sought")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValSght")]
    #endif
    [IsoXmlTag("ValSght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection49? ValueSought { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection49? ValueSought { get; init; } 
    #else
    public AmountAndDirection49? ValueSought { get; set; } 
    #endif
    
    
    #nullable disable
    
}
