// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Relates an amount to a period of time.
/// </summary>
[IsoId("_OTgzMzgw-AOSNFX-8224502")]
[DisplayName("Amount And Period")]
public partial record AmountAndPeriod1
{
    #nullable enable
    
    /// <summary>
    /// Amount of this period.
    /// </summary>
    [IsoId("_OTgzMzgx-AOSNFX-8224502")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Start of period or immediate if not specified.
    /// </summary>
    [IsoId("_OTgzMzgy-AOSNFX-8224502")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; } 
    
    /// <summary>
    /// End of period or indefinite if not specified.
    /// </summary>
    [IsoId("_OTgzMzgz-AOSNFX-8224502")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; } 
    
    
    #nullable disable
    
}
