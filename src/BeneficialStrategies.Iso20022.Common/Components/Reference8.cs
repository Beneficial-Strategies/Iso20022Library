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
/// Additional references linked to the order.
/// </summary>
[IsoId("_Q_g6SNp-Ed-ak6NoX_4Aeg_-1002805207")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote.
    /// </summary>
    [IsoId("_Q_qrQNp-Ed-ak6NoX_4Aeg_-963092701")]
    [DisplayName("Quote Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtId")]
    #endif
    [IsoXmlTag("QtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QuoteIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QuoteIdentification { get; init; } 
    #else
    public System.String? QuoteIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of indication of interest message.
    /// </summary>
    [IsoId("_Q_qrQdp-Ed-ak6NoX_4Aeg_-959397140")]
    [DisplayName("IOI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IOIId")]
    #endif
    [IsoXmlTag("IOIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IOIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IOIIdentification { get; init; } 
    #else
    public System.String? IOIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Refers to the identification reference to the order being hit or taken. (Required for counter-order selection / Hit / Take Orders).
    /// </summary>
    [IsoId("_Q_qrQtp-Ed-ak6NoX_4Aeg_-1201889385")]
    [DisplayName("Reference Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefOrdrId")]
    #endif
    [IsoXmlTag("RefOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReferenceOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReferenceOrderIdentification { get; init; } 
    #else
    public System.String? ReferenceOrderIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
