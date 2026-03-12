// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the activities that took place during a certain period for one trade transaction.
/// </summary>
[IsoId("_RJDQwNp-Ed-ak6NoX_4Aeg_2070733092")]
[DisplayName("Activity Details")]
public partial record ActivityDetails1
{
    #nullable enable
    
    /// <summary>
    /// Date and time when the activity occurred.
    /// </summary>
    [IsoId("_RJDQwdp-Ed-ak6NoX_4Aeg_-1926860432")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateTime { get; init; } 
    
    /// <summary>
    /// Description of the reported activities.
    /// </summary>
    [IsoId("_RJDQwtp-Ed-ak6NoX_4Aeg_-108739135")]
    [DisplayName("Activity")]
    [IsoXmlTag("Actvty")]
    public required Activity1 Activity { get; init; } 
    
    /// <summary>
    /// Financial institution which initiated the activity.
    /// </summary>
    [IsoId("_RJDQw9p-Ed-ak6NoX_4Aeg_-1724607144")]
    [DisplayName("Initiator")]
    [IsoXmlTag("Initr")]
    public required BICIdentification1 Initiator { get; init; } 
    
    
    #nullable disable
    
}
