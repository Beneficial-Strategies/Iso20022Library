// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the return of the transaction.
/// </summary>
[IsoId("_XaAcNfWfEemtd4wHZYvFUQ")]
[DisplayName("Payment Reject Return Reason")]
public partial record PaymentRejectReturnReason2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for the reject or the return.
    /// </summary>
    [IsoId("_XaAcO_WfEemtd4wHZYvFUQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required TrackerReturnReason1 Reason { get; init; } 
    
    
    #nullable disable
    
}
