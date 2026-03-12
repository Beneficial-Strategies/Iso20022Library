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
[IsoId("_XaHw3_WfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Data")]
public partial record TrackerData3
{
    #nullable enable
    
    /// <summary>
    /// Point in time when an update to the tracking system has been confirmed. 
    /// Usage: 
    /// This date can be the point in time when an agent provides a pending status update to the tracking system or when the creditor has been credited and can use the amount of money (as confirmed to the tracking system by the creditor agent).
    /// </summary>
    [IsoId("_XaHw4fWfEemtd4wHZYvFUQ")]
    [DisplayName("Confirmed Date")]
    [IsoXmlTag("ConfdDt")]
    public required DateTime1 ConfirmedDate { get; init; } 
    
    /// <summary>
    /// Amount of money confirmed to the tracking system by the agent.
    /// </summary>
    [IsoId("_XaHw4_WfEemtd4wHZYvFUQ")]
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public required RestrictedFINActiveCurrencyAndAmount ConfirmedAmount { get; init; } 
    
    /// <summary>
    /// Provides tracker transaction information for a specific agent involved in the transaction chain. 
    /// </summary>
    [IsoId("_XaHw5fWfEemtd4wHZYvFUQ")]
    [DisplayName("Tracker Record")]
    [IsoXmlTag("TrckrRcrd")]
    public TrackerRecord3? TrackerRecord { get; init; } 
    
    
    #nullable disable
    
}
