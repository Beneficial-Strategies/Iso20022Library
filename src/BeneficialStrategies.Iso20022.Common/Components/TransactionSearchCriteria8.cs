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
/// Defines the criteria which are used to search for a payment transaction.
/// </summary>
[IsoId("_O2c0zW49EeiU9cctagi5ow")]
[DisplayName("Transaction Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionSearchCriteria8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the criteria which are used to search for the destination of the payment.
    /// </summary>
    [IsoId("_PEwWgW49EeiU9cctagi5ow")]
    [DisplayName("Payment To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTo")]
    #endif
    [IsoXmlTag("PmtTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemSearch4? PaymentTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemSearch4? PaymentTo { get; init; } 
    #else
    public SystemSearch4? PaymentTo { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria which are used to search for the origin of the payment.
    /// </summary>
    [IsoId("_PEwWg249EeiU9cctagi5ow")]
    [DisplayName("Payment From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFr")]
    #endif
    [IsoXmlTag("PmtFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemSearch4? PaymentFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemSearch4? PaymentFrom { get; init; } 
    #else
    public SystemSearch4? PaymentFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria which are used to search for a payment.
    /// </summary>
    [IsoId("_PEwWhW49EeiU9cctagi5ow")]
    [DisplayName("Payment Search")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSch")]
    #endif
    [IsoXmlTag("PmtSch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentSearch8? PaymentSearch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentSearch8? PaymentSearch { get; init; } 
    #else
    public PaymentSearch8? PaymentSearch { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria which are used to search for a cash entry.
    /// </summary>
    [IsoId("_PEwWh249EeiU9cctagi5ow")]
    [DisplayName("Account Entry Search")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctNtrySch")]
    #endif
    [IsoXmlTag("AcctNtrySch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountEntrySearch6? AccountEntrySearch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountEntrySearch6? AccountEntrySearch { get; init; } 
    #else
    public CashAccountEntrySearch6? AccountEntrySearch { get; set; } 
    #endif
    
    
    #nullable disable
    
}
