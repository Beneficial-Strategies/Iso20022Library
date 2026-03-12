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
[IsoId("_uu9vLVc8EeunQrLahSRvvA")]
[DisplayName("Tracker Data")]
public partial record TrackerData6
{
    #nullable enable
    
    /// <summary>
    /// Point in time when an update to the tracking system has been confirmed. 
    /// Usage: 
    /// This date can be the point in time when an agent provides a pending status update to the tracking system or when the creditor has been credited and can use the amount of money (as confirmed to the tracking system by the creditor agent).
    /// </summary>
    [IsoId("_uvkLsVc8EeunQrLahSRvvA")]
    [DisplayName("Confirmed Date")]
    [IsoXmlTag("ConfdDt")]
    public required DateAndDateTime2Choice_ ConfirmedDate { get; init; } 
    
    /// <summary>
    /// Amount of money effectively credited to the creditor and confirmed to the tracking system by the agent.
    /// </summary>
    [IsoId("_uvkLs1c8EeunQrLahSRvvA")]
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public required ActiveCurrencyAndAmount ConfirmedAmount { get; init; } 
    
    /// <summary>
    /// Amount of money remaining to be confirmed.
    /// </summary>
    [IsoId("_uvkLtVc8EeunQrLahSRvvA")]
    [DisplayName("Remaining To Be Confirmed Amount")]
    [IsoXmlTag("RmngToBeConfdAmt")]
    public ActiveCurrencyAndAmount? RemainingToBeConfirmedAmount { get; init; } 
    
    /// <summary>
    /// Amount of money previously credited to the creditor and confirmed to the tracking system by the agent.
    /// </summary>
    [IsoId("_uvkLt1c8EeunQrLahSRvvA")]
    [DisplayName("Previously Confirmed Amount")]
    [IsoXmlTag("PrevslyConfdAmt")]
    public ActiveCurrencyAndAmount? PreviouslyConfirmedAmount { get; init; } 
    
    /// <summary>
    /// Point in time when the previous amount was confirmed.
    /// Usage: 
    /// This date provides the point in time when the last previous confirmed amount was provided to the tracker, in case of a partial confirmation.
    /// </summary>
    [IsoId("_uvkLuVc8EeunQrLahSRvvA")]
    [DisplayName("Previously Confirmed Date")]
    [IsoXmlTag("PrevslyConfdDt")]
    public DateAndDateTime2Choice_? PreviouslyConfirmedDate { get; init; } 
    
    
    #nullable disable
    
}
