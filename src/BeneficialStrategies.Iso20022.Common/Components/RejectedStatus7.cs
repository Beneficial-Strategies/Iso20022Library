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
[IsoId("_RLb2Z9p-Ed-ak6NoX_4Aeg_1179401448")]
[DisplayName("Rejected Status")]
public partial record RejectedStatus7
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RLlnYNp-Ed-ak6NoX_4Aeg_1344713949")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectedStatusReason8Code Reason { get; init; } 
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RLlnYdp-Ed-ak6NoX_4Aeg_1379808154")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; } 
    
    /// <summary>
    /// Proprietary identification of the reason for the rejcted status.
    /// </summary>
    [IsoId("_RLlnYtp-Ed-ak6NoX_4Aeg_1179401475")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    
    #nullable disable
    
}
