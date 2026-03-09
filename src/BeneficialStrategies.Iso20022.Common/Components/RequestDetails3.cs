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
/// Details of data request.
/// </summary>
[IsoId("_SuwKGQEcEeCQm6a_G2yO_w_49393758")]
[DisplayName("Request Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestDetails3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestDetails3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestDetails3( System.String reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data being requested, for example, a sub-member BIC.
    /// </summary>
    [IsoId("_SuwKGgEcEeCQm6a_G2yO_w_-1627802492")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Type { get; init; } 
    #else
    public System.String Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specific report data requested, for example, a BIC.
    /// </summary>
    [IsoId("_SuwKGwEcEeCQm6a_G2yO_w_467150931")]
    [DisplayName("Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Key")]
    #endif
    [IsoXmlTag("Key")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Key { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Key { get; init; } 
    #else
    public System.String? Key { get; set; } 
    #endif
    
    
    #nullable disable
    
}
