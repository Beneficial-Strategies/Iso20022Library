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
/// Contains information about the payload.
/// </summary>
[IsoId("_jLvfUu5NEeCisYr99QEiWA_-1263684777")]
[DisplayName("Payload Description")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PayloadDescription1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PayloadDescription1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PayloadDescription1( PayloadDetails1 reqPayloadDetails,PayloadTypeDetails1 reqPayloadTypeDetails )
    {
        PayloadDetails = reqPayloadDetails;
        PayloadTypeDetails = reqPayloadTypeDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// This component is used to identify the instance of the document exchanged.
    /// </summary>
    [IsoId("_jLvfU-5NEeCisYr99QEiWA_897283407")]
    [DisplayName("Payload Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyldDtls")]
    #endif
    [IsoXmlTag("PyldDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PayloadDetails1 PayloadDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PayloadDetails1 PayloadDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PayloadDetails1 PayloadDetails { get; init; } 
    #else
    public PayloadDetails1 PayloadDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Contains business information that is considered as necessary by the service provider.
    /// </summary>
    [IsoId("_jLvfVO5NEeCisYr99QEiWA_-232163905")]
    [DisplayName("Application Specific Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplSpcfcInf")]
    #endif
    [IsoXmlTag("ApplSpcfcInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ApplicationSpecifics1? ApplicationSpecificInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ApplicationSpecifics1? ApplicationSpecificInformation { get; init; } 
    #else
    public ApplicationSpecifics1? ApplicationSpecificInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the type of payload.
    /// </summary>
    [IsoId("_jL4pQO5NEeCisYr99QEiWA_-1404370216")]
    [DisplayName("Payload Type Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyldTpDtls")]
    #endif
    [IsoXmlTag("PyldTpDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PayloadTypeDetails1 PayloadTypeDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PayloadTypeDetails1 PayloadTypeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PayloadTypeDetails1 PayloadTypeDetails { get; init; } 
    #else
    public PayloadTypeDetails1 PayloadTypeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Manifest that describes the related items or attachments.
    /// This block is repeated for each different type of item.
    /// </summary>
    [IsoId("_jL4pQe5NEeCisYr99QEiWA_54247380")]
    [DisplayName("Manifest Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnfstDtls")]
    #endif
    [IsoXmlTag("MnfstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ManifestDetails1? ManifestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ManifestDetails1? ManifestDetails { get; init; } 
    #else
    public ManifestDetails1? ManifestDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
