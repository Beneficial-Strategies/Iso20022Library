// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the cancelled status.
/// </summary>
[IsoId("_RSSsU9p-Ed-ak6NoX_4Aeg_-25230464")]
[DisplayName("Cancelled Status")]
public partial record CancelledStatus3
{
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RSSsVNp-Ed-ak6NoX_4Aeg_-1452392952")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [IsoId("_RSSsVdp-Ed-ak6NoX_4Aeg_-25230446")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CancelledStatusReason3Code Reason { get; init; } 
    
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [IsoId("_RSSsVtp-Ed-ak6NoX_4Aeg_-25230404")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; } 
    
    /// <summary>
    /// Proprietary identification of the reason for the cancelled status.
    /// </summary>
    [IsoId("_RSSsV9p-Ed-ak6NoX_4Aeg_-25230386")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    
    #nullable disable
    
}
