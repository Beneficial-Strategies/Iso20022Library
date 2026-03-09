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
/// Contains detailed information from the cancellation response (for example an MT 196 or an MT 199).
/// </summary>
[IsoId("_SYKDoCFfEeicwehH70nfgw")]
[DisplayName("Cancellation Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancellationResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancellationResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancellationResponse1( InvestigationExecutionConfirmation5Code reqInvestigationExecutionStatus )
    {
        InvestigationExecutionStatus = reqInvestigationExecutionStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the status of the execution of an investigation.
    /// </summary>
    [IsoId("_hxLcECFfEeicwehH70nfgw")]
    [DisplayName("Investigation Execution Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstgtnExctnSts")]
    #endif
    [IsoXmlTag("InvstgtnExctnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestigationExecutionConfirmation5Code InvestigationExecutionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestigationExecutionConfirmation5Code InvestigationExecutionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigationExecutionConfirmation5Code InvestigationExecutionStatus { get; init; } 
    #else
    public InvestigationExecutionConfirmation5Code InvestigationExecutionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the reason for a given status on the execution of an investigation.
    /// </summary>
    [IsoId("_LJOF0CFhEeicwehH70nfgw")]
    [DisplayName("Investigation Execution Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstgtnExctnStsRsn")]
    #endif
    [IsoXmlTag("InvstgtnExctnStsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestigationExecutionStatusReason1? InvestigationExecutionStatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigationExecutionStatusReason1? InvestigationExecutionStatusReason { get; init; } 
    #else
    public InvestigationExecutionStatusReason1? InvestigationExecutionStatusReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
