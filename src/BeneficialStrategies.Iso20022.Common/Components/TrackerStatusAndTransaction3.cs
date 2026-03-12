// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction and it&apos;s status to be updated in the tracker.
/// </summary>
[IsoId("_XZ_N8_WfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Status And Transaction")]
public partial record TrackerStatusAndTransaction3
{
    #nullable enable
    
    /// <summary>
    /// Provides detailed information on the transaction status to be updated in the tracker.
    /// </summary>
    [IsoId("_XZ_N9_WfEemtd4wHZYvFUQ")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TrackerStatus3 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    [IsoId("_XZ_N-fWfEemtd4wHZYvFUQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TrackerPaymentTransaction3 Transaction { get; init; } 
    
    
    #nullable disable
    
}
