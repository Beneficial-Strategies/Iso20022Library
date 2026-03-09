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
/// Specifies the compensation data of an incorrect billing.
/// </summary>
[IsoId("_6PzSsJqlEeGSON8vddiWzQ_-1213048629")]
[DisplayName("Billing Compensation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingCompensation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingCompensation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingCompensation1( BillingCompensationType1Choice_ reqType,AmountAndDirection34 reqValue )
    {
        Type = reqType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the type of billing compensation.
    /// </summary>
    [IsoId("_6PzSsZqlEeGSON8vddiWzQ_-1034929957")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingCompensationType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BillingCompensationType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingCompensationType1Choice_ Type { get; init; } 
    #else
    public BillingCompensationType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the value of compensation.
    /// </summary>
    [IsoId("_6PzSspqlEeGSON8vddiWzQ_2084846314")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 Value { get; init; } 
    #else
    public AmountAndDirection34 Value { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the currency type used to report the value or total, in a coded form, such as Settlement (STLM).
    /// </summary>
    [IsoId("_6PzSs5qlEeGSON8vddiWzQ_-564853547")]
    [DisplayName("Currency Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyTp")]
    #endif
    [IsoXmlTag("CcyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingCurrencyType2Code? CurrencyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingCurrencyType2Code? CurrencyType { get; init; } 
    #else
    public BillingCurrencyType2Code? CurrencyType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
