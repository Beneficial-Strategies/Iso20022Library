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
[IsoId("_VCTJ7ZlQEee-Zps0fZQaFQ")]
[DisplayName("Transaction Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionSearchCriteria7
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
    [IsoId("_VKVrkZlQEee-Zps0fZQaFQ")]
    [DisplayName("Payment To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTo")]
    #endif
    [IsoXmlTag("PmtTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemSearch3? PaymentTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemSearch3? PaymentTo { get; init; } 
    #else
    public SystemSearch3? PaymentTo { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria which are used to search for the origin of the payment.
    /// </summary>
    [IsoId("_VKVrk5lQEee-Zps0fZQaFQ")]
    [DisplayName("Payment From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFr")]
    #endif
    [IsoXmlTag("PmtFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemSearch3? PaymentFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemSearch3? PaymentFrom { get; init; } 
    #else
    public SystemSearch3? PaymentFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria which are used to search for a payment.
    /// </summary>
    [IsoId("_VKVrlZlQEee-Zps0fZQaFQ")]
    [DisplayName("Payment Search")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSch")]
    #endif
    [IsoXmlTag("PmtSch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentSearch7? PaymentSearch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentSearch7? PaymentSearch { get; init; } 
    #else
    public PaymentSearch7? PaymentSearch { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria which are used to search for a cash entry.
    /// </summary>
    [IsoId("_VKVrl5lQEee-Zps0fZQaFQ")]
    [DisplayName("Account Entry Search")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctNtrySch")]
    #endif
    [IsoXmlTag("AcctNtrySch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountEntrySearch5? AccountEntrySearch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountEntrySearch5? AccountEntrySearch { get; init; } 
    #else
    public CashAccountEntrySearch5? AccountEntrySearch { get; set; } 
    #endif
    
    
    #nullable disable
    
}
