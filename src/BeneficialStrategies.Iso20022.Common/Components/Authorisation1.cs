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
/// Autorisation of the mandate holder.
/// </summary>
[IsoId("_PUrJF9p-Ed-ak6NoX_4Aeg_-504716804")]
[DisplayName("Authorisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Authorisation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Authorisation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Authorisation1( ActiveCurrencyAndAmount reqMinimumAmountPerTransaction,ActiveCurrencyAndAmount reqMaximumAmountPerTransaction )
    {
        MinimumAmountPerTransaction = reqMinimumAmountPerTransaction;
        MaximumAmountPerTransaction = reqMaximumAmountPerTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Minimum amount per transaction allowed by the mandate.
    /// </summary>
    [IsoId("_PUrJGNp-Ed-ak6NoX_4Aeg_1206246780")]
    [DisplayName("Minimum Amount Per Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinAmtPerTx")]
    #endif
    [IsoXmlTag("MinAmtPerTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount MinimumAmountPerTransaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount MinimumAmountPerTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount MinimumAmountPerTransaction { get; init; } 
    #else
    public ActiveCurrencyAndAmount MinimumAmountPerTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount per transaction allowed by the mandate.
    /// </summary>
    [IsoId("_PUrJGdp-Ed-ak6NoX_4Aeg_-151006738")]
    [DisplayName("Maximum Amount Per Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAmtPerTx")]
    #endif
    [IsoXmlTag("MaxAmtPerTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount MaximumAmountPerTransaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount MaximumAmountPerTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount MaximumAmountPerTransaction { get; init; } 
    #else
    public ActiveCurrencyAndAmount MaximumAmountPerTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount allowed over a specific period of time.
    /// </summary>
    [IsoId("_PUrJGtp-Ed-ak6NoX_4Aeg_-1091239434")]
    [DisplayName("Maximum Amount By Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAmtByPrd")]
    #endif
    [IsoXmlTag("MaxAmtByPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MaximumAmountByPeriod1? MaximumAmountByPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MaximumAmountByPeriod1? MaximumAmountByPeriod { get; init; } 
    #else
    public MaximumAmountByPeriod1? MaximumAmountByPeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
