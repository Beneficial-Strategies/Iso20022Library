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
[IsoId("_fGQ-kSi4Eeurkfo6MpvKDA")]
[DisplayName("Diagnosis Response")]
public partial record DiagnosisResponse3
{
    #nullable enable
    
    /// <summary>
    /// Sale Terminal logged to.
    /// </summary>
    [IsoId("_fUavUSi4Eeurkfo6MpvKDA")]
    [DisplayName("Logged Sale Identification")]
    [IsoXmlTag("LggdSaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LoggedSaleIdentification { get; init; } 
    
    /// <summary>
    /// Status of the POI.
    /// </summary>
    [IsoId("_fUavUyi4Eeurkfo6MpvKDA")]
    [DisplayName("POI Status")]
    [IsoXmlTag("POISts")]
    public StatusReportContent10? POIStatus { get; init; } 
    
    /// <summary>
    /// State of a Host.
    /// </summary>
    [IsoId("_fUavVSi4Eeurkfo6MpvKDA")]
    [DisplayName("Host Status")]
    [IsoXmlTag("HstSts")]
    public HostStatus1? HostStatus { get; init; } 
    
    
    #nullable disable
    
}
