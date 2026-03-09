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
/// Indicates the reference amount from which contractual payments are determined and the schedule applicable to the payments.
/// </summary>
[IsoId("_0PFHoWEeEe2P-L9DBerEgA")]
[DisplayName("Notional Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotionalAmount6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference amount from which contractual payments are determined.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_0P8qUWEeEe2P-L9DBerEgA")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection106? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection106? Amount { get; init; } 
    #else
    public AmountAndDirection106? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions negotiated in monetary amounts varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_0P8qU2EeEe2P-L9DBerEgA")]
    [DisplayName("Schedule Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchdlPrd")]
    #endif
    [IsoXmlTag("SchdlPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Schedule11? SchedulePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Schedule11? SchedulePeriod { get; init; } 
    #else
    public Schedule11? SchedulePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency of the notional amount.
    /// </summary>
    [IsoId("_oPQ70GTxEe2Qhbz5WMMCCA")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
