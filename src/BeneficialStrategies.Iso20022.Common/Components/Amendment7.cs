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
/// Details of the amendment.
/// </summary>
[IsoId("_9_dIgXltEeG7BsjMvd1mEw_2073465972")]
[DisplayName("Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amendment7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amendment7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amendment7( Amendment8 reqAmendmentIdentification,UndertakingStatus2Code reqAmendmentStatus )
    {
        AmendmentIdentification = reqAmendmentIdentification;
        AmendmentStatus = reqAmendmentStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the proposed amendment.
    /// </summary>
    [IsoId("_9_dIgnltEeG7BsjMvd1mEw_357421067")]
    [DisplayName("Amendment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntId")]
    #endif
    [IsoXmlTag("AmdmntId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amendment8 AmendmentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amendment8 AmendmentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amendment8 AmendmentIdentification { get; init; } 
    #else
    public Amendment8 AmendmentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Proposed undertaking amendment status.
    /// </summary>
    [IsoId("_wBqaoH-REeGkFKx_uxUapg")]
    [DisplayName("Amendment Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntSts")]
    #endif
    [IsoXmlTag("AmdmntSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingStatus2Code AmendmentStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingStatus2Code AmendmentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingStatus2Code AmendmentStatus { get; init; } 
    #else
    public UndertakingStatus2Code AmendmentStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
