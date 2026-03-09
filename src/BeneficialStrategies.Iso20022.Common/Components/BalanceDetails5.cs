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
/// Balance related details for a portfolio.
/// </summary>
[IsoId("_m9_jw_NBEeCuA5Tr22BnwA_-1587495854")]
[DisplayName("Balance Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceDetails5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BalanceDetails5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BalanceDetails5( BalanceType6Choice_ reqType,AmountAndDirection31 reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Balance type.
    /// </summary>
    [IsoId("_m9_jxPNBEeCuA5Tr22BnwA_-509912192")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceType6Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceType6Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceType6Choice_ Type { get; init; } 
    #else
    public BalanceType6Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Unrealised gain or loss.
    /// </summary>
    [IsoId("_m9_jxfNBEeCuA5Tr22BnwA_1710399089")]
    [DisplayName("Unrealised")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Urlsd")]
    #endif
    [IsoXmlTag("Urlsd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Unrealised1Code? Unrealised { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Unrealised1Code? Unrealised { get; init; } 
    #else
    public Unrealised1Code? Unrealised { get; set; } 
    #endif
    
    /// <summary>
    /// Balance amount.
    /// </summary>
    [IsoId("_m-ItsPNBEeCuA5Tr22BnwA_944599101")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection31 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection31 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection31 Amount { get; init; } 
    #else
    public AmountAndDirection31 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed balance information.
    /// </summary>
    [IsoId("_m-ItsfNBEeCuA5Tr22BnwA_1949015826")]
    [DisplayName("Detailed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldBal")]
    #endif
    [IsoXmlTag("DtldBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceDetails6? DetailedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceDetails6? DetailedBalance { get; init; } 
    #else
    public BalanceDetails6? DetailedBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
