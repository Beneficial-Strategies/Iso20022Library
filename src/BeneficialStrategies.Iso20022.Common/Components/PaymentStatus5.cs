// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the payment transaction status and optionally the reason for that status. 
/// </summary>
[IsoId("_Gkqk8KXXEeaBtJ1HvhzRtg")]
[DisplayName("Payment Status")]
public partial record PaymentStatus5
{
    #nullable enable
    
    /// <summary>
    /// Provides more details on the status in process.
    /// </summary>
    [IsoId("_chNUwaXXEeaBtJ1HvhzRtg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransactionIndividualStatus4Code Status { get; init; } 
    
    /// <summary>
    /// Contains optionally the reason for the status of a payment transaction.
    /// </summary>
    [IsoId("_7hBb4KXXEeaBtJ1HvhzRtg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public PaymentStatusReason2Code? Reason { get; init; } 
    
    
    #nullable disable
    
}
