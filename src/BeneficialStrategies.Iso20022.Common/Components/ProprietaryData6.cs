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
/// Container for proprietary information. Business content of this element is not specified.
/// </summary>
[IsoId("_1gW-cYKYEee7hrXqLO3yQg")]
[DisplayName("Proprietary Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProprietaryData6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProprietaryData6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProprietaryData6( SkipPayload reqAny )
    {
        Any = reqAny;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Proprietary content.
    /// </summary>
    [IsoId("_1oY5E4KYEee7hrXqLO3yQg")]
    [DisplayName("Any")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Any")]
    #endif
    [IsoXmlTag("Any")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SkipPayload Any { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SkipPayload Any { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SkipPayload Any { get; init; } 
    #else
    public SkipPayload Any { get; set; } 
    #endif
    
    
    #nullable disable
    
}
