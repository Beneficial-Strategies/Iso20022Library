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
/// Set of elements that further identifies the type of local instruments being requested by the initiating party.
/// </summary>
[IsoId("_VyVJA9p-Ed-ak6NoX_4Aeg_-2089814377")]
[DisplayName("Local Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LocalInstrument1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LocalInstrument1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LocalInstrument1( System.String reqCode )
    {
        Code = reqCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the local instrument published in an external local instrument code list - restricted to B2B or CORE within SEPA.
    /// </summary>
    [IsoId("_VyVJBNp-Ed-ak6NoX_4Aeg_-2089814375")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.RestrictedB2BCORECodeText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedB2BCORECodeText Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Code { get; init; } 
    #else
    public System.String Code { get; set; } 
    #endif
    
    
    #nullable disable
    
}
