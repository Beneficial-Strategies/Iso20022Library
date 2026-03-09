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
/// Specifies the applicable Incoterm and associated location.
/// </summary>
[IsoId("_Sr_qOdp-Ed-ak6NoX_4Aeg_-76606103")]
[DisplayName("Incoterms")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Incoterms2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Incoterms2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Incoterms2( Incoterms1Code reqCode,System.String reqOther,System.String reqLocation )
    {
        Code = reqCode;
        Other = reqOther;
        Location = reqLocation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the applicable Incoterm by means of a code.
    /// </summary>
    [IsoId("_Sr_qOtp-Ed-ak6NoX_4Aeg_-33745991")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Incoterms1Code Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Incoterms1Code Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms1Code Code { get; init; } 
    #else
    public Incoterms1Code Code { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies Incoterm not present in code list.
    /// </summary>
    [IsoId("_Sr_qO9p-Ed-ak6NoX_4Aeg_-33745913")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Other { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Other { get; init; } 
    #else
    public System.String Other { get; set; } 
    #endif
    
    /// <summary>
    /// Location where the Incoterms are actioned.
    /// </summary>
    [IsoId("_SsJbMNp-Ed-ak6NoX_4Aeg_-47973709")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Location { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Location { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Location { get; init; } 
    #else
    public System.String Location { get; set; } 
    #endif
    
    
    #nullable disable
    
}
