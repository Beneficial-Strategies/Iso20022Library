// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details of the job or task of the individual working in a temporary capacity.
/// </summary>
[IsoId("_blvrpPfWEei89sMSHxl1ew")]
[DisplayName("Temporary Services Job")]
public partial record TemporaryServicesJob1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the job or task being performed by the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_blvrpvfWEei89sMSHxl1ew")]
    [DisplayName("Job Code")]
    [IsoXmlTag("JobCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? JobCode { get; init; } 
    
    /// <summary>
    /// Contains the description of the job or task of the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_blvrp_fWEei89sMSHxl1ew")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Description { get; init; } 
    
    /// <summary>
    /// Contains the start date of the job. 
    /// </summary>
    [IsoId("_PZTnI_faEei89sMSHxl1ew")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; } 
    
    /// <summary>
    /// Duration of the job expressed in number of days. 
    /// </summary>
    [IsoId("_PZTnJffaEei89sMSHxl1ew")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? Duration { get; init; } 
    
    /// <summary>
    /// Contains the end date of the job. 
    /// </summary>
    [IsoId("_PZTnJPfaEei89sMSHxl1ew")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; } 
    
    
    #nullable disable
    
}
