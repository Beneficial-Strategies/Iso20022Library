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
/// Provides the reason for a status on the execution of an investigation.
/// </summary>
[IsoId("_L5azsCFhEeicwehH70nfgw")]
[DisplayName("Investigation Execution Status Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestigationExecutionStatusReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the reason why the payment cancellation was rejected.
    /// </summary>
    [IsoId("_YeuHUCFhEeicwehH70nfgw")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCancellationRejection3Code? Rejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCancellationRejection3Code? Rejected { get; init; } 
    #else
    public PaymentCancellationRejection3Code? Rejected { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the reason why the payment cancellation is pending.
    /// </summary>
    [IsoId("_l9vRMCFhEeicwehH70nfgw")]
    [DisplayName("Pending")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdg")]
    #endif
    [IsoXmlTag("Pdg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingPaymentCancellationReason1Code? Pending { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingPaymentCancellationReason1Code? Pending { get; init; } 
    #else
    public PendingPaymentCancellationReason1Code? Pending { get; set; } 
    #endif
    
    
    #nullable disable
    
}
