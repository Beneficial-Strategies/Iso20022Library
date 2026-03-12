// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction and it&apos;s status as updated in the tracker.
/// </summary>
[IsoId("_nz76AWRPEeqImsG9JNoSQw")]
[DisplayName("Tracker Status And Transaction")]
public partial record TrackerStatusAndTransaction7
{
    #nullable enable
    
    /// <summary>
    /// Provides detailed information on the transaction status to be updated in the tracker.
    /// </summary>
    [IsoId("_n7bpIWRPEeqImsG9JNoSQw")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TrackerStatus2? TransactionStatus { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the alert notification in the tracker.
    /// </summary>
    [IsoId("_n7bpI2RPEeqImsG9JNoSQw")]
    [DisplayName("Alert Status")]
    [IsoXmlTag("AlrtSts")]
    public required TrackerAlertNotificationStatus1 AlertStatus { get; init; } 
    
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    [IsoId("_n7bpJWRPEeqImsG9JNoSQw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<TrackerPaymentTransaction7> Transaction { get; init; } = new ValueList<TrackerPaymentTransaction7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _n7bpJWRPEeqImsG9JNoSQw
    
    
    #nullable disable
    
}
