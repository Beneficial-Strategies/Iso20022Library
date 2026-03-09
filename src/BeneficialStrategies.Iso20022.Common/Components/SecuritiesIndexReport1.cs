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
/// Provides details on the securities index request operations for national competent authorities.
/// </summary>
[IsoId("_00E_kL3kEeWvRsMSLyTf-A")]
[DisplayName("Securities Index Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesIndexReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesIndexReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesIndexReport1( FinancialInstrument46Choice_ reqIndex )
    {
        Index = reqIndex;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and feedback messages.
    /// Usage:
    /// This identification will be used in the status advice sent back.
    /// </summary>
    [IsoId("_M8By8b7VEeW_FPJ0tzugkw")]
    [DisplayName("Technical Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechRcrdId")]
    #endif
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Country code of the entity that wishes to express an interest in receiving transaction reports for the requested indexes.
    /// </summary>
    [IsoId("_K91sAL3lEeWvRsMSLyTf-A")]
    [DisplayName("Requesting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RqstngNtty")]
    #endif
    [IsoXmlTag("RqstngNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? RequestingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestingEntity { get; init; } 
    #else
    public string? RequestingEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Details the index that is being requested.
    /// </summary>
    [IsoId("_5eLhwL3lEeWvRsMSLyTf-A")]
    [DisplayName("Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Indx")]
    #endif
    [IsoXmlTag("Indx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument46Choice_ Index { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument46Choice_ Index { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument46Choice_ Index { get; init; } 
    #else
    public FinancialInstrument46Choice_ Index { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the national competent authority last expressed its interest in this index.
    /// </summary>
    [IsoId("_mAsbEr31EeWvRsMSLyTf-A")]
    [DisplayName("Validity Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyPrd")]
    #endif
    [IsoXmlTag("VldtyPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4Choice_? ValidityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_? ValidityPeriod { get; init; } 
    #else
    public Period4Choice_? ValidityPeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
