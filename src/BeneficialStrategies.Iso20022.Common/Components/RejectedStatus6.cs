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
[IsoId("_RLlnZtp-Ed-ak6NoX_4Aeg_-1014963759")]
[DisplayName("Rejected Status")]
public partial record RejectedStatus6
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RLlnZ9p-Ed-ak6NoX_4Aeg_-111758778")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectedStatusReason7Code Reason { get; init; } 
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RLlnaNp-Ed-ak6NoX_4Aeg_156983939")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; } 
    
    /// <summary>
    /// Proprietary identification of the reason for the rejected status.
    /// </summary>
    [IsoId("_RLlnadp-Ed-ak6NoX_4Aeg_-1014963739")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    /// <summary>
    /// Additional information about the rejected status reason.
    /// </summary>
    [IsoId("_RLlnatp-Ed-ak6NoX_4Aeg_1953886383")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
