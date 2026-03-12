// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason for the status of the transaction.
/// </summary>
[IsoId("_XaAcI_WfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Status Reason")]
public partial record TrackerStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the status, as published in an external reason code list.
    /// </summary>
    [IsoId("_XaAcJ_WfEemtd4wHZYvFUQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required TrackerTransactionStatusReason1Code Code { get; init; } 
    
    
    #nullable disable
    
}
