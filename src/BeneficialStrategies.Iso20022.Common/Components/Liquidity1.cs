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
/// Ability of a financial instrument to be easily traded and converted to cash, at conditions that do not affect its price.
/// </summary>
[IsoId("_SW_DgNp-Ed-ak6NoX_4Aeg_587026413")]
[DisplayName("Liquidity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Liquidity1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Market value of the securities position for which liquidity details are provided.
    /// </summary>
    [IsoId("_SW_Dgdp-Ed-ak6NoX_4Aeg_962899324")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? Value { get; init; } 
    #else
    public ActiveCurrencyAndAmount? Value { get; set; } 
    #endif
    
    /// <summary>
    /// Number of securities for which liquidity range details are provided.
    /// </summary>
    [IsoId("_SW_Dgtp-Ed-ak6NoX_4Aeg_889017115")]
    [DisplayName("Number Of Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfScties")]
    #endif
    [IsoXmlTag("NbOfScties")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? NumberOfSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfSecurities { get; init; } 
    #else
    public System.UInt64? NumberOfSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Upper liquidity indicator, represented as a percentage of the average trade daily volume.
    /// </summary>
    [IsoId("_SW_Dg9p-Ed-ak6NoX_4Aeg_901945694")]
    [DisplayName("Upper")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Upper")]
    #endif
    [IsoXmlTag("Upper")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Upper { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Upper { get; init; } 
    #else
    public System.Decimal? Upper { get; set; } 
    #endif
    
    /// <summary>
    /// Lower liquidity indicator, represented as a percentage of the average trade daily volume.
    /// </summary>
    [IsoId("_SW_DhNp-Ed-ak6NoX_4Aeg_917645433")]
    [DisplayName("Lower")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lwr")]
    #endif
    [IsoXmlTag("Lwr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Lower { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Lower { get; init; } 
    #else
    public System.Decimal? Lower { get; set; } 
    #endif
    
    
    #nullable disable
    
}
