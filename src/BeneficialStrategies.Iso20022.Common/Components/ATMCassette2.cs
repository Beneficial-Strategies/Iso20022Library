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
/// Information on the cassette of an ATM.
/// </summary>
[IsoId("_UgWjka4MEeWZgJQOa6iKCQ")]
[DisplayName("ATM Cassette")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCassette2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMCassette2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMCassette2( System.String reqLogicalIdentification,ATMCassetteType1Code reqType )
    {
        LogicalIdentification = reqLogicalIdentification;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Physical identification of the cassette for the ATM.
    /// </summary>
    [IsoId("_UrYH0a4MEeWZgJQOa6iKCQ")]
    [DisplayName("Physical Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysId")]
    #endif
    [IsoXmlTag("PhysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PhysicalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PhysicalIdentification { get; init; } 
    #else
    public System.String? PhysicalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Logical identification of the cassette for the ATM.
    /// </summary>
    [IsoId("_UrYH064MEeWZgJQOa6iKCQ")]
    [DisplayName("Logical Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LogclId")]
    #endif
    [IsoXmlTag("LogclId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text LogicalIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LogicalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LogicalIdentification { get; init; } 
    #else
    public System.String LogicalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Serial number or unique identification of the cassette hardware.
    /// </summary>
    [IsoId("_dqlegK4MEeWZgJQOa6iKCQ")]
    [DisplayName("Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrlNb")]
    #endif
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SerialNumber { get; init; } 
    #else
    public System.String? SerialNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Type of cassette.
    /// </summary>
    [IsoId("_UrYH1a4MEeWZgJQOa6iKCQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMCassetteType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMCassetteType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCassetteType1Code Type { get; init; } 
    #else
    public ATMCassetteType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Type of items the cash-in takes.
    /// </summary>
    [IsoId("_UrYH164MEeWZgJQOa6iKCQ")]
    [DisplayName("Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubTp")]
    #endif
    [IsoXmlTag("SubTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMNoteType1Code? SubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMNoteType1Code? SubType { get; init; } 
    #else
    public ATMNoteType1Code? SubType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of media inside the cassette.
    /// </summary>
    [IsoId("_UrYH2a4MEeWZgJQOa6iKCQ")]
    [DisplayName("Media Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdiaTp")]
    #endif
    [IsoXmlTag("MdiaTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMMediaType1Code? MediaType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMMediaType1Code? MediaType { get; init; } 
    #else
    public ATMMediaType1Code? MediaType { get; set; } 
    #endif
    
    /// <summary>
    /// Counter per unit value or globally.
    /// </summary>
    [IsoId("_UrYH264MEeWZgJQOa6iKCQ")]
    [DisplayName("Media Counters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdiaCntrs")]
    #endif
    [IsoXmlTag("MdiaCntrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCassetteCounters3? MediaCounters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCassetteCounters3? MediaCounters { get; init; } 
    #else
    public ATMCassetteCounters3? MediaCounters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
