// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Status2.
/// </summary>
[IsoId("_CXmCmFRtEe23M4WgERMsYw")]
[DisplayName("Investigation Status2")]
public partial record InvestigationStatus2
{
    #nullable enable

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ExternalInvestigationStatus1Code Status { get; init; } 

    /// <summary>
    /// Status Reason.
    /// </summary>
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public InvestigationStatusReason1Choice_? StatusReason { get; init; } 

    
    #nullable disable
    
}
