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
[IsoId("_-ZZzEIqeEeS4a4abTJTSSw")]
[DisplayName("ATM Cassette")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCassette1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMCassette1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMCassette1( System.String reqLogicalIdentification,ATMCassetteType1Code reqType )
    {
        LogicalIdentification = reqLogicalIdentification;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Physical identification of the cassette for the ATM.
    /// </summary>
    [IsoId("_LdNnoIqfEeS4a4abTJTSSw")]
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
    [IsoId("_OFwXMIqfEeS4a4abTJTSSw")]
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
    /// Type of cassette.
    /// </summary>
    [IsoId("_6yEDgIqfEeS4a4abTJTSSw")]
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
    [IsoId("_gIIiEIqgEeS4a4abTJTSSw")]
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
    [IsoId("_oPE0AIqgEeS4a4abTJTSSw")]
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
    [IsoId("_2CdEUIqgEeS4a4abTJTSSw")]
    [DisplayName("Media Counters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdiaCntrs")]
    #endif
    [IsoXmlTag("MdiaCntrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCassetteCounters1? MediaCounters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCassetteCounters1? MediaCounters { get; init; } 
    #else
    public ATMCassetteCounters1? MediaCounters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
