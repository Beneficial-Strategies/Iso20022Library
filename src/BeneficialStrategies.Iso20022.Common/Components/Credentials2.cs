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
[IsoId("_3tXfsad2EeuEcqP2FGAFaA")]
[DisplayName("Credentials")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Credentials2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Credentials2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Credentials2( Identification3Code reqIdentificationCode,System.String reqIdentificationValue )
    {
        IdentificationCode = reqIdentificationCode;
        IdentificationValue = reqIdentificationValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the type of credential.
    /// </summary>
    [IsoId("_3zANoad2EeuEcqP2FGAFaA")]
    [DisplayName("Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdCd")]
    #endif
    [IsoXmlTag("IdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Identification3Code IdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Identification3Code IdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Identification3Code IdentificationCode { get; init; } 
    #else
    public Identification3Code IdentificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Used when OtherNational or OtherPrivate value is selected in identification code list. 
    /// </summary>
    [IsoId("_3zA0sad2EeuEcqP2FGAFaA")]
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
    [IsoId("_3zA0s6d2EeuEcqP2FGAFaA")]
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
    
    /// <summary>
    /// Expiration date of the identification.
    /// </summary>
    [IsoId("_HbqHgCX9Eeym0KcvJF9aDQ")]
    [DisplayName("Identification Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdXpryDt")]
    #endif
    [IsoXmlTag("IdXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? IdentificationExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? IdentificationExpiryDate { get; init; } 
    #else
    public System.UInt16? IdentificationExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that assigns and manages this type of identification.
    /// </summary>
    [IsoId("_JSH9oKd8EeuEcqP2FGAFaA")]
    [DisplayName("Assigner Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssgnrAuthrty")]
    #endif
    [IsoXmlTag("AssgnrAuthrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Authority1? AssignerAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Authority1? AssignerAuthority { get; init; } 
    #else
    public Authority1? AssignerAuthority { get; set; } 
    #endif
    
    
    #nullable disable
    
}
