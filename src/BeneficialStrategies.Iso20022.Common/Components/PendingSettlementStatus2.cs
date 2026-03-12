// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the pending settlement status.
/// </summary>
[IsoId("_RRPjdtp-Ed-ak6NoX_4Aeg_-685618546")]
[DisplayName("Pending Settlement Status")]
public partial record PendingSettlementStatus2
{
    #nullable enable
    
    /// <summary>
    /// Reason for the settlement pending status.
    /// </summary>
    [IsoId("_RRPjd9p-Ed-ak6NoX_4Aeg_1818056284")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required PendingSettlementStatusReason2Code Reason { get; init; } 
    
    /// <summary>
    /// Reason for the settlement pending status.
    /// </summary>
    [IsoId("_RRPjeNp-Ed-ak6NoX_4Aeg_1820827730")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; } 
    
    /// <summary>
    /// Proprietary identification of the reason for the pending settlement status.
    /// </summary>
    [IsoId("_RRPjedp-Ed-ak6NoX_4Aeg_-685618492")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RRPjetp-Ed-ak6NoX_4Aeg_-685618527")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    
    #nullable disable
    
}
