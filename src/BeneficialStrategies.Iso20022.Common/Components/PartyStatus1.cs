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
/// Business status of the party for processing in the system.
/// </summary>
[IsoId("_knY98-5NEeCisYr99QEiWA_336843792")]
[DisplayName("Party Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyStatus1( Status6Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of the party maintenance instruction.
    /// </summary>
    [IsoId("_kniH4O5NEeCisYr99QEiWA_2146103806")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status6Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status6Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status6Code Status { get; init; } 
    #else
    public Status6Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying reason for the status of an object.
    /// </summary>
    [IsoId("_kniH4e5NEeCisYr99QEiWA_-1456967057")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReasonInformation10? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReasonInformation10? StatusReason { get; init; } 
    #else
    public StatusReasonInformation10? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Specifications of a party defined within a system.
    /// </summary>
    [IsoId("_kniH4u5NEeCisYr99QEiWA_-124739370")]
    [DisplayName("System Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysPtyId")]
    #endif
    [IsoXmlTag("SysPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification3? SystemPartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification3? SystemPartyIdentification { get; init; } 
    #else
    public SystemPartyIdentification3? SystemPartyIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
