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
/// Content of the Balance Inquiry Request message.
/// </summary>
[IsoId("_YW_NMYYLEemxIqbaFEE8-w")]
[DisplayName("Balance Inquiry Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceInquiryRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data related to the account pointed by the payment card.
    /// </summary>
    [IsoId("_YhOuUYYLEemxIqbaFEE8-w")]
    [DisplayName("Payment Account Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAcctReq")]
    #endif
    [IsoXmlTag("PmtAcctReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; } 
    #else
    public PaymentAccountRequest1? PaymentAccountRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a requested Loyalty program or account.
    /// </summary>
    [IsoId("_YhOuU4YLEemxIqbaFEE8-w")]
    [DisplayName("Loyalty Account Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyAcctReq")]
    #endif
    [IsoXmlTag("LltyAcctReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyAccountRequest1? LoyaltyAccountRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAccountRequest1? LoyaltyAccountRequest { get; init; } 
    #else
    public LoyaltyAccountRequest1? LoyaltyAccountRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a requested Stored value account.
    /// </summary>
    [IsoId("_YhOuVYYLEemxIqbaFEE8-w")]
    [DisplayName("Stored Value Account Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValAcctReq")]
    #endif
    [IsoXmlTag("StordValAcctReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueRequest2? StoredValueAccountRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueRequest2? StoredValueAccountRequest { get; init; } 
    #else
    public StoredValueRequest2? StoredValueAccountRequest { get; set; } 
    #endif
    
    
    #nullable disable
    
}
