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
/// Contains amount details for a specific type of charge.
/// </summary>
[IsoId("_7-MslffJEei89sMSHxl1ew")]
[DisplayName("Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amount11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amount11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amount11( ImpliedCurrencyAndAmount reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of telephone charge.
    /// </summary>
    [IsoId("_7-PI0ffJEei89sMSHxl1ew")]
    [DisplayName("Type Of Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfChrg")]
    #endif
    [IsoXmlTag("TpOfChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfAmount19Code? TypeOfCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount19Code? TypeOfCharge { get; init; } 
    #else
    public TypeOfAmount19Code? TypeOfCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Description of other type of charge.
    /// </summary>
    [IsoId("_7-PI0PfJEei89sMSHxl1ew")]
    [DisplayName("Other Type Of Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTpOfChrg")]
    #endif
    [IsoXmlTag("OthrTpOfChrg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherTypeOfCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherTypeOfCharge { get; init; } 
    #else
    public System.String? OtherTypeOfCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_7-PI0vfJEei89sMSHxl1ew")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount Amount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the amount is a credit or debit. 
    /// </summary>
    [IsoId("_7-PI0_fJEei89sMSHxl1ew")]
    [DisplayName("Credit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtInd")]
    #endif
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CreditIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditIndicator { get; init; } 
    #else
    public System.String? CreditIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
