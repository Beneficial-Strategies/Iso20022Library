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
/// Specifies the payment terms of the underlying transaction.
/// </summary>
[IsoId("_ZXBQcRVgEeOrY9qSHVspCA")]
[DisplayName("Payment Terms")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTerms5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTerms5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTerms5( PaymentCodeOrOther2Choice_ reqPaymentTerms,AmountOrPercentage2Choice_ reqAmountOrPercentage )
    {
        PaymentTerms = reqPaymentTerms;
        AmountOrPercentage = reqAmountOrPercentage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the payment terms using a code or other means.
    /// </summary>
    [IsoId("_ZvmvkRVgEeOrY9qSHVspCA")]
    [DisplayName("Payment Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTerms")]
    #endif
    [IsoXmlTag("PmtTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCodeOrOther2Choice_ PaymentTerms { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentCodeOrOther2Choice_ PaymentTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCodeOrOther2Choice_ PaymentTerms { get; init; } 
    #else
    public PaymentCodeOrOther2Choice_ PaymentTerms { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if it is a fixed amount or a percentage.
    /// </summary>
    [IsoId("_ZvwgkRVgEeOrY9qSHVspCA")]
    [DisplayName("Amount Or Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtOrPctg")]
    #endif
    [IsoXmlTag("AmtOrPctg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    #else
    public AmountOrPercentage2Choice_ AmountOrPercentage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
