// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Particular time span specified between a start time and an end time. The time period cannot exceed 24 hours.
/// </summary>
[IsoId("_T-_jK9p-Ed-ak6NoX_4Aeg_808787168")]
[DisplayName("Time Period Details")]
public partial record TimePeriodDetails1
{
    #nullable enable
    
    /// <summary>
    /// Time at which the time span starts.
    /// </summary>
    [IsoId("_T-_jLNp-Ed-ak6NoX_4Aeg_808787185")]
    [DisplayName("From Time")]
    [IsoXmlTag("FrTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime FromTime { get; init; } 
    
    /// <summary>
    /// Time at which the time span ends.
    /// </summary>
    [IsoId("_T_JUINp-Ed-ak6NoX_4Aeg_808787220")]
    [DisplayName("To Time")]
    [IsoXmlTag("ToTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ToTime { get; init; } 
    
    
    #nullable disable
    
}
