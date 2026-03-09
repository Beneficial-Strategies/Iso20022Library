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
/// Additional functions or services that have been or are to be performed in conjunction with the transaction.
/// </summary>
[IsoId("_KvaacZ1JEeublrfU-wN95w")]
[DisplayName("Additional Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalService2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalService2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalService2( AdditionalServiceType2Code reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of additional service applied to the transaction.
    /// </summary>
    [IsoId("_K04wUZ1JEeublrfU-wN95w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalServiceType2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalServiceType2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalServiceType2Code Type { get; init; } 
    #else
    public AdditionalServiceType2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other additional service applied to the transaction.
    /// </summary>
    [IsoId("_K05XYZ1JEeublrfU-wN95w")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Result from performing the identified service.
    /// </summary>
    [IsoId("_eIwNsJ1JEeublrfU-wN95w")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalServiceResult1Code? Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalServiceResult1Code? Result { get; init; } 
    #else
    public AdditionalServiceResult1Code? Result { get; set; } 
    #endif
    
    /// <summary>
    /// Other nationally or privately defined additional service result code.
    /// </summary>
    [IsoId("_mYWP4J1KEeublrfU-wN95w")]
    [DisplayName("Other Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRslt")]
    #endif
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherResult { get; init; } 
    #else
    public System.String? OtherResult { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional information for the execution or results of the service.
    /// </summary>
    [IsoId("_DODP4J1LEeublrfU-wN95w")]
    [DisplayName("Service Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcDtl")]
    #endif
    [IsoXmlTag("SvcDtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? ServiceDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? ServiceDetail { get; init; } 
    #else
    public AdditionalData1? ServiceDetail { get; set; } 
    #endif
    
    
    #nullable disable
    
}
