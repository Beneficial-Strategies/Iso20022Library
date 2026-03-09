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
/// Special conditions for the loan.
/// </summary>
[IsoId("_pqRrgdOCEeSQ_-lmj1tzfw")]
[DisplayName("Special Condition")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SpecialCondition1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SpecialCondition1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SpecialCondition1( ActiveCurrencyAndAmount reqIncomingAmount,ActiveCurrencyAndAmount reqOutgoingAmount )
    {
        IncomingAmount = reqIncomingAmount;
        OutgoingAmount = reqOutgoingAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Incoming amount on special conditions.
    /// </summary>
    [IsoId("_uNbGkNOCEeSQ_-lmj1tzfw")]
    [DisplayName("Incoming Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmgAmt")]
    #endif
    [IsoXmlTag("IncmgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount IncomingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount IncomingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount IncomingAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount IncomingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Outgoing amount on special conditions.
    /// </summary>
    [IsoId("_xOYWINOCEeSQ_-lmj1tzfw")]
    [DisplayName("Outgoing Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutgngAmt")]
    #endif
    [IsoXmlTag("OutgngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount OutgoingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount OutgoingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount OutgoingAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount OutgoingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Incoming amount to other account on special conditions.
    /// </summary>
    [IsoId("_9TKtYwtLEeWkxvNyFrBT8Q")]
    [DisplayName("Incoming Amount To Other Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmgAmtToOthrAcct")]
    #endif
    [IsoXmlTag("IncmgAmtToOthrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? IncomingAmountToOtherAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? IncomingAmountToOtherAccount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? IncomingAmountToOtherAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Outgoing payment amount from other account on special conditions.
    /// </summary>
    [IsoId("_HfRVAAtMEeWkxvNyFrBT8Q")]
    [DisplayName("Payment From Other Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFrOthrAcct")]
    #endif
    [IsoXmlTag("PmtFrOthrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PaymentFromOtherAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PaymentFromOtherAccount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PaymentFromOtherAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
