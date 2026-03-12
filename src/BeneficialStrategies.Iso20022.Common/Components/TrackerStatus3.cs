// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction status to be updated in the tracker.
/// </summary>
[IsoId("_XZ_1A_WfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Status")]
public partial record TrackerStatus3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_XZ_1BfWfEemtd4wHZYvFUQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TrackerPaymentStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_XZ_1CfWfEemtd4wHZYvFUQ")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public PaymentStatusReason2? StatusReason { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the reject or return reason.
    /// </summary>
    [IsoId("_XZ_1C_WfEemtd4wHZYvFUQ")]
    [DisplayName("Reject Return Reason")]
    [IsoXmlTag("RjctRtrRsn")]
    public PaymentRejectReturnReason2? RejectReturnReason { get; init; } 
    
    
    #nullable disable
    
}
