// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Year in which an ISA plan is issued.
/// </summary>
[IsoId("_1AA5BbNBEeewUI7-Tnew9A")]
[DisplayName("ISA Years Of Issue")]
public partial record ISAYearsOfIssue7
{
    #nullable enable
    
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_1QOfRbNBEeewUI7-Tnew9A")]
    [DisplayName("Current Year")]
    [IsoXmlTag("CurYr")]
    public CurrentYearType2Choice_? CurrentYear { get; init; } 
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_1QOfR7NBEeewUI7-Tnew9A")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYear2Choice_? PreviousYears { get; init; } 
    
    
    #nullable disable
    
}
