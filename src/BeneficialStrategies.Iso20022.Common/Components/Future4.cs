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
/// Parameters for contracts which obligate the buyer to receive and the seller to deliver in the future the assets specified at an agreed price.
/// </summary>
[IsoId("_12okUWp7EemmaZLSPtWX5A")]
[DisplayName("Future")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Future4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_2CcLsWp7EemmaZLSPtWX5A")]
    [DisplayName("Contract Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctSz")]
    #endif
    [IsoXmlTag("CtrctSz")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ContractSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ContractSize { get; init; } 
    #else
    public System.Decimal? ContractSize { get; set; } 
    #endif
    
    /// <summary>
    /// Predetermined price at which the holder of a Future will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_2CcLs2p7EemmaZLSPtWX5A")]
    [DisplayName("Exercise Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExrcPric")]
    #endif
    [IsoXmlTag("ExrcPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price8? ExercisePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price8? ExercisePrice { get; init; } 
    #else
    public Price8? ExercisePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which future contracts settle.
    /// </summary>
    [IsoId("_2CcLtWp7EemmaZLSPtWX5A")]
    [DisplayName("Future Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FutrDt")]
    #endif
    [IsoXmlTag("FutrDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? FutureDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? FutureDate { get; init; } 
    #else
    public System.DateTime? FutureDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the minimum ratio or multiply factor used to convert from contracts to shares.
    /// </summary>
    [IsoId("_2CcLt2p7EemmaZLSPtWX5A")]
    [DisplayName("Minimum Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinSz")]
    #endif
    [IsoXmlTag("MinSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MinimumSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MinimumSize { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MinimumSize { get; set; } 
    #endif
    
    /// <summary>
    /// Used to indicate the measurement unit of the underlying commodity on which the contract is based (for example, 2500 lbs of lean cattle, 1000 barrels of crude oil, 1000 bushels of corn, etc.).
    /// </summary>
    [IsoId("_2CcLuWp7EemmaZLSPtWX5A")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure7Choice_? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure7Choice_? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure7Choice_? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Used to indicate a time unit for the contract (for example days, weeks, months, etc.).
    /// </summary>
    [IsoId("_2CcLwWp7EemmaZLSPtWX5A")]
    [DisplayName("Time Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmUnit")]
    #endif
    [IsoXmlTag("TmUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeUnit3Choice_? TimeUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeUnit3Choice_? TimeUnit { get; init; } 
    #else
    public TimeUnit3Choice_? TimeUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Provides more information about the underlying instrument.
    /// </summary>
    [IsoId("_2CcLyWp7EemmaZLSPtWX5A")]
    [DisplayName("Additional Underlying Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlUndrlygAttrbts")]
    #endif
    [IsoXmlTag("AddtlUndrlygAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingAttributes4? AdditionalUnderlyingAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingAttributes4? AdditionalUnderlyingAttributes { get; init; } 
    #else
    public UnderlyingAttributes4? AdditionalUnderlyingAttributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
