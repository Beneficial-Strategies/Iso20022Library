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
/// Result of the processing of a file action.
/// </summary>
[IsoId("_sP44sVEAEee94_dUz-hvgw")]
[DisplayName("Result Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResultData4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResultData4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResultData4( System.String reqResultDetails )
    {
        ResultDetails = reqResultDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Generic result of the processing.
    /// </summary>
    [IsoId("_sbGDIVEAEee94_dUz-hvgw")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FileActionResult1Code? Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FileActionResult1Code? Result { get; init; } 
    #else
    public FileActionResult1Code? Result { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of result of the processing.
    /// </summary>
    [IsoId("_sbGDI1EAEee94_dUz-hvgw")]
    [DisplayName("Other Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRslt")]
    #endif
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherResult { get; init; } 
    #else
    public System.String? OtherResult { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed results of the processing.
    /// ISO 8583:1987 bit 39, response code list
    /// </summary>
    [IsoId("_sbGDJVEAEee94_dUz-hvgw")]
    [DisplayName("Result Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltDtls")]
    #endif
    [IsoXmlTag("RsltDtls")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact2AlphaNumericText ResultDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ResultDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ResultDetails { get; init; } 
    #else
    public System.String ResultDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
