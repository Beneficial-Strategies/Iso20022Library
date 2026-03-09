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
/// Specifies the aggregated data of internalised settlement instructions.
/// </summary>
[IsoId("_RCmFcO3uEeaWjpoyrnG6Rw")]
[DisplayName("Internalisation Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InternalisationData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InternalisationData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InternalisationData2( InternalisationDataVolume1 reqSettled,InternalisationDataVolume1 reqFailed,InternalisationDataVolume1 reqTotal )
    {
        Settled = reqSettled;
        Failed = reqFailed;
        Total = reqTotal;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Aggregated volume and value of internalised settlement instructions settled during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_XApYQO3uEeaWjpoyrnG6Rw")]
    [DisplayName("Settled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttld")]
    #endif
    [IsoXmlTag("Sttld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationDataVolume1 Settled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationDataVolume1 Settled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationDataVolume1 Settled { get; init; } 
    #else
    public InternalisationDataVolume1 Settled { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregated volume and value of internalised settlement instructions failed during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_ZQXYIO3uEeaWjpoyrnG6Rw")]
    [DisplayName("Failed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Faild")]
    #endif
    [IsoXmlTag("Faild")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationDataVolume1 Failed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationDataVolume1 Failed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationDataVolume1 Failed { get; init; } 
    #else
    public InternalisationDataVolume1 Failed { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregated total volume and value of internalised settlement instructions performed (settled and failed) during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_cRK2sO3uEeaWjpoyrnG6Rw")]
    [DisplayName("Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ttl")]
    #endif
    [IsoXmlTag("Ttl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationDataVolume1 Total { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationDataVolume1 Total { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationDataVolume1 Total { get; init; } 
    #else
    public InternalisationDataVolume1 Total { get; set; } 
    #endif
    
    
    #nullable disable
    
}
