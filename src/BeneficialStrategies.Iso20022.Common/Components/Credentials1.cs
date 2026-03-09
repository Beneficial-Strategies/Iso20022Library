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
/// Contains credential information.
/// </summary>
[IsoId("_AwRLkMV4Eee3gsS0IxDWIA")]
[DisplayName("Credentials")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Credentials1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Credentials1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Credentials1( Identification2Code reqIdentificationCode,System.String reqIdentificationValue )
    {
        IdentificationCode = reqIdentificationCode;
        IdentificationValue = reqIdentificationValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the type of credential.
    /// </summary>
    [IsoId("_OEL4sMV4Eee3gsS0IxDWIA")]
    [DisplayName("Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdCd")]
    #endif
    [IsoXmlTag("IdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Identification2Code IdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Identification2Code IdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Identification2Code IdentificationCode { get; init; } 
    #else
    public Identification2Code IdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Used when OtherNational or OtherPrivate value is selected in identification code list. 
    /// </summary>
    [IsoId("_tNXSEJcVEeme5LKU36W8xA")]
    [DisplayName("Other Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrIdCd")]
    #endif
    [IsoXmlTag("OthrIdCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherIdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherIdentificationCode { get; init; } 
    #else
    public System.String? OtherIdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Value of identification.
    /// </summary>
    [IsoId("_UR2U0MV4Eee3gsS0IxDWIA")]
    [DisplayName("Identification Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdVal")]
    #endif
    [IsoXmlTag("IdVal")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text IdentificationValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IdentificationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IdentificationValue { get; init; } 
    #else
    public System.String IdentificationValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
