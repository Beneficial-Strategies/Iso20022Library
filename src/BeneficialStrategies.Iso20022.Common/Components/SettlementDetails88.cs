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
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
[IsoId("_nKLWIWQMEeSTN56gbbyx2g")]
[DisplayName("Settlement Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDetails88
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementDetails88 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementDetails88( System.DateTime reqTradeDate,CollateralOwnership1 reqCollateralOwnership )
    {
        TradeDate = reqTradeDate;
        CollateralOwnership = reqCollateralOwnership;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the date as known by the two parties to be used for matching purposes when settlement of securities occurs.
    /// </summary>
    [IsoId("_gjXS0GQPEeSTN56gbbyx2g")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TradeDate { get; init; } 
    #else
    public System.DateTime TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on either the delivering or receiving settlement parties.
    /// </summary>
    [IsoId("_tAAkQGQQEeSTN56gbbyx2g")]
    [DisplayName("Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPties")]
    #endif
    [IsoXmlTag("SttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties3Choice_? SettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties3Choice_? SettlementParties { get; init; } 
    #else
    public SettlementParties3Choice_? SettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the collateral ownership.
    /// </summary>
    [IsoId("_39SJIGQbEeSTN56gbbyx2g")]
    [DisplayName("Collateral Ownership")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollOwnrsh")]
    #endif
    [IsoXmlTag("CollOwnrsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralOwnership1 CollateralOwnership { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralOwnership1 CollateralOwnership { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralOwnership1 CollateralOwnership { get; init; } 
    #else
    public CollateralOwnership1 CollateralOwnership { get; set; } 
    #endif
    
    
    #nullable disable
    
}
