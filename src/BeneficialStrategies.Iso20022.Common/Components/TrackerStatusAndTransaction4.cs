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
[IsoId("_k0GOJ_Y0Eemf4dJxCjghNw")]
[DisplayName("Tracker Status And Transaction")]
public partial record TrackerStatusAndTransaction4
{
    #nullable enable
    
    /// <summary>
    /// Provides detailed information on the alert notification in the tracker.
    /// </summary>
    [IsoId("_k0GOK_Y0Eemf4dJxCjghNw")]
    [DisplayName("Alert Status")]
    [IsoXmlTag("AlrtSts")]
    public required TrackerAlertNotificationStatus2 AlertStatus { get; init; } 
    
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    [IsoId("_k0GOLfY0Eemf4dJxCjghNw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TrackerPaymentTransaction4 Transaction { get; init; } 
    
    
    #nullable disable
    
}
