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
/// Specifies the aggregated data and failed rate of internalised settlement instructions.
/// </summary>
[IsoId("_WeS9UO3nEeaWjpoyrnG6Rw")]
[DisplayName("Internalisation Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InternalisationData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InternalisationData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InternalisationData1( InternalisationData2 reqAggregate,InternalisationDataRate1 reqFailedRate )
    {
        Aggregate = reqAggregate;
        FailedRate = reqFailedRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Aggregated volume and value of settled,  failed, total of internalised settlement instructions performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_iT1jwO3uEeaWjpoyrnG6Rw")]
    [DisplayName("Aggregate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Aggt")]
    #endif
    [IsoXmlTag("Aggt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData2 Aggregate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData2 Aggregate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData2 Aggregate { get; init; } 
    #else
    public InternalisationData2 Aggregate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of failed internalised settlement instructions compared to the total volume and value, of internalised settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_kjstkO3uEeaWjpoyrnG6Rw")]
    [DisplayName("Failed Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaildRate")]
    #endif
    [IsoXmlTag("FaildRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationDataRate1 FailedRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationDataRate1 FailedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationDataRate1 FailedRate { get; init; } 
    #else
    public InternalisationDataRate1 FailedRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
