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
/// Descriptive fields capturing where no strike price is known.
/// </summary>
[IsoId("_cqBnQOI_EeWWKb0jFHxViQ")]
[DisplayName("Securities Transaction Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTransactionPrice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesTransactionPrice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTransactionPrice1( PriceStatus1Code reqPending )
    {
        Pending = reqPending;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Price is currently not available, but pending.
    /// </summary>
    [IsoId("_lr-v8OI_EeWWKb0jFHxViQ")]
    [DisplayName("Pending")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdg")]
    #endif
    [IsoXmlTag("Pdg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceStatus1Code Pending { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceStatus1Code Pending { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceStatus1Code Pending { get; init; } 
    #else
    public PriceStatus1Code Pending { get; set; } 
    #endif
    
    /// <summary>
    /// Currency that will be used but for which no price is yet known.
    /// </summary>
    [IsoId("_tbdkIOI_EeWWKb0jFHxViQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
