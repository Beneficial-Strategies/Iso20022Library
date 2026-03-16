// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tracker Data7.
/// </summary>
[IsoId("_1YwfgTEyEe6g-ffJsqGiSA")]
[DisplayName("Tracker Data7")]
public partial record TrackerData7
{
    #nullable enable

    /// <summary>
    /// Confirmed Amount.
    /// </summary>
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public required ActiveCurrencyAndAmount ConfirmedAmount { get; init; } 

    /// <summary>
    /// Confirmed Date.
    /// </summary>
    [DisplayName("Confirmed Date")]
    [IsoXmlTag("ConfdDt")]
    public required DateAndDateTime2Choice_ ConfirmedDate { get; init; } 

    /// <summary>
    /// Tracker Record.
    /// </summary>
    [DisplayName("Tracker Record")]
    [IsoXmlTag("TrckrRcrd")]
    public ValueList<TrackerRecord5> TrackerRecord { get; init; } = [];

    
    #nullable disable
    
}
