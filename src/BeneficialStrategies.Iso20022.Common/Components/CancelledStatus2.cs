// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is cancelled.
/// </summary>
[IsoId("_RNE1Idp-Ed-ak6NoX_4Aeg_-1718282760")]
[DisplayName("Cancelled Status")]
public partial record CancelledStatus2
{
    #nullable enable
    
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [IsoId("_RNE1Itp-Ed-ak6NoX_4Aeg_-542952390")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CancelledStatusReason2Code Reason { get; init; } 
    
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [IsoId("_RNE1I9p-Ed-ak6NoX_4Aeg_-1164168651")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; } 
    
    /// <summary>
    /// Proprietary identification of the reason for the cancelled status.
    /// </summary>
    [IsoId("_RNE1JNp-Ed-ak6NoX_4Aeg_-1709968726")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RNE1Jdp-Ed-ak6NoX_4Aeg_-1710893214")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    
    #nullable disable
    
}
