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
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_QaMvIDAqEeOqioR9srQH1g")]
[DisplayName("Detailed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedAmount5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Cash-back amount.
    /// </summary>
    [IsoId("_R55K0DArEeOqioR9srQH1g")]
    [DisplayName("Cash Back")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshBck")]
    #endif
    [IsoXmlTag("CshBck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? CashBack { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? CashBack { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? CashBack { get; set; } 
    #endif
    
    /// <summary>
    /// Gratuity amount.
    /// </summary>
    [IsoId("_H5yF4DAtEeOqioR9srQH1g")]
    [DisplayName("Gratuity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grtty")]
    #endif
    [IsoXmlTag("Grtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Gratuity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Gratuity { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Gratuity { get; set; } 
    #endif
    
    /// <summary>
    /// Fees amount.
    /// </summary>
    [IsoId("_x29u8DAsEeOqioR9srQH1g")]
    [DisplayName("Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fees")]
    #endif
    [IsoXmlTag("Fees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount4? Fees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount4? Fees { get; init; } 
    #else
    public DetailedAmount4? Fees { get; set; } 
    #endif
    
    /// <summary>
    /// Global rebate of the transaction. This amount is counted as a negative amount.
    /// </summary>
    [IsoId("_6tylsDAsEeOqioR9srQH1g")]
    [DisplayName("Rebate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rbt")]
    #endif
    [IsoXmlTag("Rbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount4? Rebate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount4? Rebate { get; init; } 
    #else
    public DetailedAmount4? Rebate { get; set; } 
    #endif
    
    /// <summary>
    /// Value added tax amount.
    /// </summary>
    [IsoId("_A-JJcDAtEeOqioR9srQH1g")]
    [DisplayName("Value Added Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValAddedTax")]
    #endif
    [IsoXmlTag("ValAddedTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount4? ValueAddedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount4? ValueAddedTax { get; init; } 
    #else
    public DetailedAmount4? ValueAddedTax { get; set; } 
    #endif
    
    
    #nullable disable
    
}
