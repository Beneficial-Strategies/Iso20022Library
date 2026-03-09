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
[IsoId("_m91ywPNBEeCuA5Tr22BnwA_934037418")]
[DisplayName("Balance Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceDetails6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BalanceDetails6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BalanceDetails6( AmountAndDirection31 reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Category of the financial asset balance type.
    /// </summary>
    [IsoId("_m91ywfNBEeCuA5Tr22BnwA_889825506")]
    [DisplayName("Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctgy")]
    #endif
    [IsoXmlTag("Ctgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialAssetTypeCategory1Code? Category { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialAssetTypeCategory1Code? Category { get; init; } 
    #else
    public FinancialAssetTypeCategory1Code? Category { get; set; } 
    #endif
    
    /// <summary>
    /// Balance type.
    /// </summary>
    [IsoId("_m91ywvNBEeCuA5Tr22BnwA_1249881108")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceType7Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceType7Choice_? Type { get; init; } 
    #else
    public BalanceType7Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Unrealised gain or loss.
    /// </summary>
    [IsoId("_m91yw_NBEeCuA5Tr22BnwA_1569419041")]
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
    [IsoId("_m91yxPNBEeCuA5Tr22BnwA_-1195789251")]
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
    
    
    #nullable disable
    
}
