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
/// Description of the mis-matched situation between two baselines or between a baseline and a data set.
/// </summary>
[IsoId("_RaowANp-Ed-ak6NoX_4Aeg_-1146148189")]
[DisplayName("Mis Match Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MisMatchReport3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MisMatchReport3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MisMatchReport3( System.UInt64 reqNumberOfMisMatches )
    {
        NumberOfMisMatches = reqNumberOfMisMatches;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of mismatches between two baselines or between one baseline and one data set.
    /// </summary>
    [IsoId("_RaowAdp-Ed-ak6NoX_4Aeg_-1146148150")]
    [DisplayName("Number Of Mis Matches")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfMisMtchs")]
    #endif
    [IsoXmlTag("NbOfMisMtchs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfMisMatches { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfMisMatches { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfMisMatches { get; init; } 
    #else
    public System.UInt64 NumberOfMisMatches { get; set; } 
    #endif
    
    /// <summary>
    /// Details of each mismatch occurrence.
    /// </summary>
    [IsoId("_RaowAtp-Ed-ak6NoX_4Aeg_-1146147848")]
    [DisplayName("Mis Match Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MisMtchInf")]
    #endif
    [IsoXmlTag("MisMtchInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValidationResult5? MisMatchInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationResult5? MisMatchInformation { get; init; } 
    #else
    public ValidationResult5? MisMatchInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
