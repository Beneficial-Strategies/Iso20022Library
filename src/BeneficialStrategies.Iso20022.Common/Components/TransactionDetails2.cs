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
/// Reference of the trade transaction.
/// </summary>
[IsoId("_S-xcR9p-Ed-ak6NoX_4Aeg_946629114")]
[DisplayName("Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionDetails2( System.String reqTradeReference )
    {
        TradeReference = reqTradeReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned to a trade once it is received or matched by an executing system.
    /// </summary>
    [IsoId("_S-6mMNp-Ed-ak6NoX_4Aeg_1406541847")]
    [DisplayName("Trade Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradRef")]
    #endif
    [IsoXmlTag("TradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text TradeReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeReference { get; init; } 
    #else
    public System.String TradeReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
