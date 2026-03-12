// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status reason of the transaction.
/// </summary>
[IsoId("_XaAcF_WfEemtd4wHZYvFUQ")]
[DisplayName("Payment Status Reason")]
public partial record PaymentStatusReason2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_XaAcHfWfEemtd4wHZYvFUQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required TrackerStatusReason1 Reason { get; init; } 
    
    
    #nullable disable
    
}
