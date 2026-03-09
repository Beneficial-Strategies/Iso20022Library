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
/// Provides details on the interest statement.
/// </summary>
[IsoId("_Rvb0MWjgEeSwb7MzI8qnfQ")]
[DisplayName("Interest Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestStatement3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InterestStatement3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestStatement3( DatePeriodDetails reqInterestPeriod,System.DateOnly reqValueDate )
    {
        InterestPeriod = reqInterestPeriod;
        ValueDate = reqValueDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the period during which the interest rate has been applied.
    /// </summary>
    [IsoId("_SM5MQWjgEeSwb7MzI8qnfQ")]
    [DisplayName("Interest Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPrd")]
    #endif
    [IsoXmlTag("IntrstPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DatePeriodDetails InterestPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DatePeriodDetails InterestPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodDetails InterestPeriod { get; init; } 
    #else
    public DatePeriodDetails InterestPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the total amount of interest that is due to partyA.
    /// </summary>
    [IsoId("_SM5MQ2jgEeSwb7MzI8qnfQ")]
    [DisplayName("Total Interest Amount Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlIntrstAmtDueToA")]
    #endif
    [IsoXmlTag("TtlIntrstAmtDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToA { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the total amount of interest that is due to partyB.
    /// </summary>
    [IsoId("_SM5MRWjgEeSwb7MzI8qnfQ")]
    [DisplayName("Total Interest Amount Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlIntrstAmtDueToB")]
    #endif
    [IsoXmlTag("TtlIntrstAmtDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToB { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToB { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the value date of the interest statement.
    /// </summary>
    [IsoId("_SM5MR2jgEeSwb7MzI8qnfQ")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValueDate { get; init; } 
    #else
    public System.DateOnly ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the reference to the interest payment request.
    /// </summary>
    [IsoId("_SM5MSWjgEeSwb7MzI8qnfQ")]
    [DisplayName("Interest Payment Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPmtReqId")]
    #endif
    [IsoXmlTag("IntrstPmtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InterestPaymentRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterestPaymentRequestIdentification { get; init; } 
    #else
    public System.String? InterestPaymentRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the interest calculation.
    /// </summary>
    [IsoId("_SM5MS2jgEeSwb7MzI8qnfQ")]
    [DisplayName("Interest Calculation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstClctn")]
    #endif
    [IsoXmlTag("IntrstClctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestCalculation3? InterestCalculation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestCalculation3? InterestCalculation { get; init; } 
    #else
    public InterestCalculation3? InterestCalculation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
