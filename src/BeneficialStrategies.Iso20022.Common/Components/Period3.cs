// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
[IsoId("_T5oiA9p-Ed-ak6NoX_4Aeg_1742147586")]
[DisplayName("Period")]
public partial record Period3
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_T5oiBNp-Ed-ak6NoX_4Aeg_1743067755")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public required DateFormat12Choice_ StartDate { get; init; } 
    
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_T5oiBdp-Ed-ak6NoX_4Aeg_1743067910")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public required DateFormat12Choice_ EndDate { get; init; } 
    
    
    #nullable disable
    
}
