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
/// Details of the collateral value position/balance.
/// </summary>
[IsoId("_EP0opTpyEemk2e6qGBk8IQ")]
[DisplayName("Collateral Value Position")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralValuePosition3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralValuePosition3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralValuePosition3( System.DateTime reqDataAccessTime )
    {
        DataAccessTime = reqDataAccessTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time when the data was last accessed.
    /// </summary>
    [IsoId("_EbS40TpyEemk2e6qGBk8IQ")]
    [DisplayName("Data Access Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataAccsTm")]
    #endif
    [IsoXmlTag("DataAccsTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime DataAccessTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime DataAccessTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime DataAccessTime { get; init; } 
    #else
    public System.DateTime DataAccessTime { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of the collateral valuation.
    /// </summary>
    [IsoId("_EbS40zpyEemk2e6qGBk8IQ")]
    [DisplayName("Total Collateral Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCollValtn")]
    #endif
    [IsoXmlTag("TtlCollValtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalCollateralValuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalCollateralValuation { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalCollateralValuation { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the securities account.
    /// </summary>
    [IsoId("_EbS41TpyEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcct")]
    #endif
    [IsoXmlTag("SctiesAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SecuritiesAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SecuritiesAccount { get; init; } 
    #else
    public SecuritiesAccount19? SecuritiesAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as known by the account owner, to unambiguously identify the securities on which the collateral value position is requested.
    /// </summary>
    [IsoId("_EbS41zpyEemk2e6qGBk8IQ")]
    [DisplayName("Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scties")]
    #endif
    [IsoXmlTag("Scties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityCharacteristics3? Securities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityCharacteristics3? Securities { get; init; } 
    #else
    public SecurityCharacteristics3? Securities { get; set; } 
    #endif
    
    
    #nullable disable
    
}
