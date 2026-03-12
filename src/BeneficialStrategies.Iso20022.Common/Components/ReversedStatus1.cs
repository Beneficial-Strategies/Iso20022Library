// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the reversed status.
/// </summary>
[IsoId("_RQptldp-Ed-ak6NoX_4Aeg_-1949430355")]
[DisplayName("Reversed Status")]
public partial record ReversedStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the reversal status.
    /// </summary>
    [IsoId("_RQptltp-Ed-ak6NoX_4Aeg_-1949430313")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Reason { get; init; } 
    
    /// <summary>
    /// Proprietary identification of the reason for the reversed status.
    /// </summary>
    [IsoId("_RQptl9p-Ed-ak6NoX_4Aeg_-1949430294")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RQptmNp-Ed-ak6NoX_4Aeg_1619833408")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    
    #nullable disable
    
}
