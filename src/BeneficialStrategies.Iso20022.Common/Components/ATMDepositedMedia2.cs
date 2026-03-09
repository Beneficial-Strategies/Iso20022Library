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
/// Media item that are deposited.
/// </summary>
[IsoId("_udWnMK4DEeWL1uap3dNhCQ")]
[DisplayName("ATM Deposited Media")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMDepositedMedia2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of deposit media.
    /// </summary>
    [IsoId("_3qVUIK4DEeWL1uap3dNhCQ")]
    [DisplayName("Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnt")]
    #endif
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Count { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Count { get; init; } 
    #else
    public System.UInt64? Count { get; set; } 
    #endif
    
    /// <summary>
    /// Amount or denomination of one media item, if the media type is valued or entered by the customer.
    /// </summary>
    [IsoId("_82-_MK4DEeWL1uap3dNhCQ")]
    [DisplayName("Unit Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitVal")]
    #endif
    [IsoXmlTag("UnitVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? UnitValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? UnitValue { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? UnitValue { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of media items, if valued and different from base currency.
    /// </summary>
    [IsoId("_BW11sK4EEeWL1uap3dNhCQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Format of the check code line.
    /// </summary>
    [IsoId("_GV2tYK4EEeWL1uap3dNhCQ")]
    [DisplayName("Code Line Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdLineFrmt")]
    #endif
    [IsoXmlTag("CdLineFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CheckCodeLine1Code? CodeLineFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CheckCodeLine1Code? CodeLineFormat { get; init; } 
    #else
    public CheckCodeLine1Code? CodeLineFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Check code line.
    /// </summary>
    [IsoId("_reFkQK4EEeWL1uap3dNhCQ")]
    [DisplayName("Code Line")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdLine")]
    #endif
    [IsoXmlTag("CdLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CodeLine { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CodeLine { get; init; } 
    #else
    public System.String? CodeLine { get; set; } 
    #endif
    
    /// <summary>
    /// Check amount scanned by the check reader.
    /// </summary>
    [IsoId("_xGiagK4EEeWL1uap3dNhCQ")]
    [DisplayName("Scanned Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScnndVal")]
    #endif
    [IsoXmlTag("ScnndVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? ScannedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? ScannedValue { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? ScannedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the confidence in the check amount.
    /// </summary>
    [IsoId("_1aimUK4EEeWL1uap3dNhCQ")]
    [DisplayName("Confidence Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnfdncLvl")]
    #endif
    [IsoXmlTag("CnfdncLvl")]
    [IsoSimpleType(IsoSimpleType.Percentage)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentage? ConfidenceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ConfidenceLevel { get; init; } 
    #else
    public System.Decimal? ConfidenceLevel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
