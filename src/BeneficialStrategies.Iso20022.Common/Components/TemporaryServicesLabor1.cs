// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details of the labour performed and associated duration and billing rate. 
/// </summary>
[IsoId("_4TwEBPfdEei89sMSHxl1ew")]
[DisplayName("Temporary Services Labor")]
public partial record TemporaryServicesLabor1
{
    #nullable enable
    
    /// <summary>
    /// Contains the time sheet identification number.
    /// </summary>
    [IsoId("_4TwEBffdEei89sMSHxl1ew")]
    [DisplayName("Time Sheet Number")]
    [IsoXmlTag("TmSheetNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TimeSheetNumber { get; init; } 
    
    /// <summary>
    /// Contains the date of the end of the billing cycle. 
    /// </summary>
    [IsoId("_4TwEBvfdEei89sMSHxl1ew")]
    [DisplayName("Week Ending")]
    [IsoXmlTag("WkEndg")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? WeekEnding { get; init; } 
    
    /// <summary>
    /// Contains details of the amount charged. 
    /// </summary>
    [IsoId("_4TwEB_fdEei89sMSHxl1ew")]
    [DisplayName("Charge")]
    [IsoXmlTag("Chrg")]
    public Amount12? Charge { get; init; } 
    
    
    #nullable disable
    
}
