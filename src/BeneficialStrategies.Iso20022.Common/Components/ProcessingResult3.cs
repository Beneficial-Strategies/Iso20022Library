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
/// Outcome of the processing of the batch.
/// </summary>
[IsoId("_Rq4CoFA0EeedyPuM0kK2EQ")]
[DisplayName("Processing Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingResult3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProcessingResult3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProcessingResult3( ResultData2 reqResultData )
    {
        ResultData = reqResultData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Result information related to the processing of the transaction.
    /// </summary>
    [IsoId("_6HHA4FA0EeedyPuM0kK2EQ")]
    [DisplayName("Result Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltData")]
    #endif
    [IsoXmlTag("RsltData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResultData2 ResultData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResultData2 ResultData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultData2 ResultData { get; init; } 
    #else
    public ResultData2 ResultData { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_2UFw8Rs2EeqrvK3udMUsNQ")]
    [DisplayName("Original Result Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRsltData")]
    #endif
    [IsoXmlTag("OrgnlRsltData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResultData1? OriginalResultData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultData1? OriginalResultData { get; init; } 
    #else
    public ResultData1? OriginalResultData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
