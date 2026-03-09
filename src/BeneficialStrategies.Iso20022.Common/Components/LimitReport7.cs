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
/// Reports either on the risk management limit or on a business error.
/// </summary>
[IsoId("_DAtgZ24-EeiU9cctagi5ow")]
[DisplayName("Limit Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitReport7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LimitReport7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LimitReport7( LimitIdentification5 reqLimitIdentification,LimitOrError4Choice_ reqLimitOrError )
    {
        LimitIdentification = reqLimitIdentification;
        LimitOrError = reqLimitOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the limit on which information is requested.
    /// </summary>
    [IsoId("_DMyNg24-EeiU9cctagi5ow")]
    [DisplayName("Limit Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtId")]
    #endif
    [IsoXmlTag("LmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LimitIdentification5 LimitIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LimitIdentification5 LimitIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitIdentification5 LimitIdentification { get; init; } 
    #else
    public LimitIdentification5 LimitIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested information on the limit or business error report when information has not been found.
    /// </summary>
    [IsoId("_DMyNhW4-EeiU9cctagi5ow")]
    [DisplayName("Limit Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtOrErr")]
    #endif
    [IsoXmlTag("LmtOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LimitOrError4Choice_ LimitOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LimitOrError4Choice_ LimitOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitOrError4Choice_ LimitOrError { get; init; } 
    #else
    public LimitOrError4Choice_ LimitOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
