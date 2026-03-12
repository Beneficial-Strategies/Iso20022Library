// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Diagnosis Response message.
/// </summary>
[IsoId("_sVO1MU6rEeyGi9JAv6wq7Q")]
[DisplayName("Diagnosis Response")]
public partial record DiagnosisResponse4
{
    #nullable enable
    
    /// <summary>
    /// Sale Terminal logged to.
    /// </summary>
    [IsoId("_sbX5cU6rEeyGi9JAv6wq7Q")]
    [DisplayName("Logged Sale Identification")]
    [IsoXmlTag("LggdSaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LoggedSaleIdentification { get; init; } 
    
    /// <summary>
    /// Status of the POI.
    /// </summary>
    [IsoId("_sbX5c06rEeyGi9JAv6wq7Q")]
    [DisplayName("POI Status")]
    [IsoXmlTag("POISts")]
    public StatusReportContent11? POIStatus { get; init; } 
    
    /// <summary>
    /// State of a Host.
    /// </summary>
    [IsoId("_sbX5dU6rEeyGi9JAv6wq7Q")]
    [DisplayName("Host Status")]
    [IsoXmlTag("HstSts")]
    public HostStatus1? HostStatus { get; init; } 
    
    
    #nullable disable
    
}
