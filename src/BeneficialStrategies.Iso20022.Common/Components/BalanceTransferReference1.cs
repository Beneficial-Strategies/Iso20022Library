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
/// Reference to enable the receiving account servicer to reconcile the payment with the message.
/// </summary>
[IsoId("_60SyMQ2aEeSNWNtJlXOAhg")]
[DisplayName("Balance Transfer Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceTransferReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BalanceTransferReference1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BalanceTransferReference1( System.String reqBalanceTransferReference )
    {
        BalanceTransferReference = reqBalanceTransferReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Used by the debtor in a suitable reference field of a payment message sent over an alternative payment channel to enable the creditor to match the payment with the payment request.
    /// </summary>
    [IsoId("_-1hL8A2aEeSNWNtJlXOAhg")]
    [DisplayName("Balance Transfer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTrfRef")]
    #endif
    [IsoXmlTag("BalTrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text BalanceTransferReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BalanceTransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BalanceTransferReference { get; init; } 
    #else
    public System.String BalanceTransferReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
