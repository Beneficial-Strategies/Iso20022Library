// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the unmatched status.
/// </summary>
[IsoId("_RQNBpdp-Ed-ak6NoX_4Aeg_-544756899")]
[DisplayName("Transfer Unmatched Status")]
public partial record TransferUnmatchedStatus2
{
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RQNBptp-Ed-ak6NoX_4Aeg_-544756882")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    /// <summary>
    /// Reason for the unmatched status.
    /// </summary>
    [IsoId("_RQNBp9p-Ed-ak6NoX_4Aeg_-256618190")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required TransferUnmatchedReason2Code Reason { get; init; } 
    
    /// <summary>
    /// Reason for the unmatched status.
    /// </summary>
    [IsoId("_RQWyoNp-Ed-ak6NoX_4Aeg_-256617853")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; } 
    
    /// <summary>
    /// Proprietary identification of the reason for the unmatched status.
    /// </summary>
    [IsoId("_RQWyodp-Ed-ak6NoX_4Aeg_-544756821")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    
    #nullable disable
    
}
