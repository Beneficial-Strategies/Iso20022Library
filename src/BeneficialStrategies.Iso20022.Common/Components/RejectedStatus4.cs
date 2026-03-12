// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is rejected.
/// </summary>
[IsoId("_U3BXUtp-Ed-ak6NoX_4Aeg_1285193408")]
[DisplayName("Rejected Status")]
public partial record RejectedStatus4
{
    #nullable enable
    
    /// <summary>
    /// Reason for a rejected status.
    /// </summary>
    [IsoId("_U3BXU9p-Ed-ak6NoX_4Aeg_1285193486")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectedStatusReason4 Reason { get; init; } 
    
    /// <summary>
    /// Proprietary identification for a reason of a rejected status in the report.
    /// </summary>
    [IsoId("_U3BXVNp-Ed-ak6NoX_4Aeg_1285193451")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    
    #nullable disable
    
}
