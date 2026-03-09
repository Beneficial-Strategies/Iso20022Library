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
[IsoId("_RrBVZ9p-Ed-ak6NoX_4Aeg_467657186")]
[DisplayName("Proprietary Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProprietaryData3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProprietaryData3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProprietaryData3( SkipProcessing reqAny )
    {
        Any = reqAny;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Proprietary content.
    /// </summary>
    [IsoId("_RrBVaNp-Ed-ak6NoX_4Aeg_467657279")]
    [DisplayName("Any")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Any")]
    #endif
    [IsoXmlTag("Any")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SkipProcessing Any { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SkipProcessing Any { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SkipProcessing Any { get; init; } 
    #else
    public SkipProcessing Any { get; set; } 
    #endif
    
    
    #nullable disable
    
}
