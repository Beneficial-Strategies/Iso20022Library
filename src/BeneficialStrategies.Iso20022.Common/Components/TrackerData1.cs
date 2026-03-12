// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the detailed information as provided by a payment tracking system.
/// </summary>
[IsoId("_kOqpAIW2EeiDBOVr6AJAFA")]
[DisplayName("Tracker Data")]
public partial record TrackerData1
{
    #nullable enable
    
    /// <summary>
    /// Point in time when an update to the tracking system has been confirmed. 
    /// Usage: 
    /// This date can be the point in time when an agent provides a pending status update to the tracking system or when the creditor has been credited and can use the amount of money (as confirmed to the tracking system by the creditor agent).
    /// </summary>
    [IsoId("_n9zF0IW5EeiDBOVr6AJAFA")]
    [DisplayName("Confirmed Date")]
    [IsoXmlTag("ConfdDt")]
    public required DateAndDateTime2Choice_ ConfirmedDate { get; init; } 
    
    /// <summary>
    /// Amount of money confirmed to the tracking system by the agent.
    /// </summary>
    [IsoId("_se8VwIW5EeiDBOVr6AJAFA")]
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public required ActiveCurrencyAndAmount ConfirmedAmount { get; init; } 
    
    /// <summary>
    /// Provides tracker transaction information for a specific agent involved in the transaction chain. 
    /// </summary>
    [IsoId("_x5xmwIW5EeiDBOVr6AJAFA")]
    [DisplayName("Tracker Record")]
    [IsoXmlTag("TrckrRcrd")]
    public ValueList<TrackerRecord1> TrackerRecord { get; init; } = new ValueList<TrackerRecord1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _x5xmwIW5EeiDBOVr6AJAFA
    
    
    #nullable disable
    
}
