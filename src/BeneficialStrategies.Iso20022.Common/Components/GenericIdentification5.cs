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
/// Information expressed in a proprietary manner.
/// </summary>
[IsoId("_P_b9Wdp-Ed-ak6NoX_4Aeg_652282211")]
[DisplayName("Generic Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GenericIdentification5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GenericIdentification5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GenericIdentification5( System.String reqIssuer,System.String reqInformation )
    {
        Issuer = reqIssuer;
        Information = reqInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_P_b9Wtp-Ed-ak6NoX_4Aeg_691069232")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax8Text Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Issuer { get; init; } 
    #else
    public System.String Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_P_b9W9p-Ed-ak6NoX_4Aeg_691068172")]
    [DisplayName("Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Inf")]
    #endif
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact4AlphaNumericText Information { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Information { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Information { get; init; } 
    #else
    public System.String Information { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information.
    /// </summary>
    [IsoId("_P_luUNp-Ed-ak6NoX_4Aeg_691069664")]
    [DisplayName("Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nrrtv")]
    #endif
    [IsoXmlTag("Nrrtv")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Narrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Narrative { get; init; } 
    #else
    public System.String? Narrative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
