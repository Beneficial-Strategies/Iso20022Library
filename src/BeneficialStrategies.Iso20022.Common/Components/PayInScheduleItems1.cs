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
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_SGKyMeKNEeKM3LYZSgb7xw")]
[DisplayName("Pay In Schedule Items")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PayInScheduleItems1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PayInScheduleItems1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PayInScheduleItems1( ActiveCurrencyAndAmount reqAmount,System.DateTime reqDeadline )
    {
        Amount = reqAmount;
        Deadline = reqDeadline;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency and amount to be paid in.
    /// </summary>
    [IsoId("_SkklceKNEeKM3LYZSgb7xw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Time by which the amount must be paid in.
    /// </summary>
    [IsoId("_SkkldeKNEeKM3LYZSgb7xw")]
    [DisplayName("Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ddln")]
    #endif
    [IsoXmlTag("Ddln")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime Deadline { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime Deadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime Deadline { get; init; } 
    #else
    public System.DateTime Deadline { get; set; } 
    #endif
    
    
    #nullable disable
    
}
