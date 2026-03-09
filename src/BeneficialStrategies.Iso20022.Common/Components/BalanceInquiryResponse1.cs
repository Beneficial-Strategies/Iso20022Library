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
/// Content of the Balance Inquiry Response message.
/// </summary>
[IsoId("_XCUYcO19Eei-V5h0ja04AA")]
[DisplayName("Balance Inquiry Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceInquiryResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Payment account information.
    /// </summary>
    [IsoId("_layS0O19Eei-V5h0ja04AA")]
    [DisplayName("Payment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAcct")]
    #endif
    [IsoXmlTag("PmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentAccount2? PaymentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentAccount2? PaymentAccount { get; init; } 
    #else
    public PaymentAccount2? PaymentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_RYOG8e1-Eei-V5h0ja04AA")]
    [DisplayName("Loyalty Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyAcct")]
    #endif
    [IsoXmlTag("LltyAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyAccount1? LoyaltyAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAccount1? LoyaltyAccount { get; init; } 
    #else
    public LoyaltyAccount1? LoyaltyAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Stored value account information.
    /// </summary>
    [IsoId("_mjz68e1-Eei-V5h0ja04AA")]
    [DisplayName("Stored Value Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValAcct")]
    #endif
    [IsoXmlTag("StordValAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueAccount1? StoredValueAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueAccount1? StoredValueAccount { get; init; } 
    #else
    public StoredValueAccount1? StoredValueAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Receipt to print after a balance inquiry.
    /// </summary>
    [IsoId("_tVd08e1-Eei-V5h0ja04AA")]
    [DisplayName("Receipt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rct")]
    #endif
    [IsoXmlTag("Rct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentReceipt1? Receipt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentReceipt1? Receipt { get; init; } 
    #else
    public PaymentReceipt1? Receipt { get; set; } 
    #endif
    
    
    #nullable disable
    
}
