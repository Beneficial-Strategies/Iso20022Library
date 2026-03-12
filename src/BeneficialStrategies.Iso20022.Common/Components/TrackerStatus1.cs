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
[IsoId("_sTptYM7wEemEIuVuDudp4g")]
[DisplayName("Tracker Status")]
public partial record TrackerStatus1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_pLlJMs7wEemEIuVuDudp4g")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ExternalPaymentTransactionStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Date for the status.
    /// </summary>
    [IsoId("_uY9TgM_hEemHcp9lKLekIw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public DateAndDateTime2Choice_? Date { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_pLlJM87wEemEIuVuDudp4g")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public PaymentStatusReason1? StatusReason { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    [IsoId("_vhy8UPSrEemJpbG3s5kY2A")]
    [DisplayName("Reject Return Reason")]
    [IsoXmlTag("RjctRtrRsn")]
    public PaymentRejectReturnReason1? RejectReturnReason { get; init; } 
    
    
    #nullable disable
    
}
