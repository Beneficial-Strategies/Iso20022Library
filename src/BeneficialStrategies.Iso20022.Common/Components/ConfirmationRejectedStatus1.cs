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
[IsoId("_RM7EItp-Ed-ak6NoX_4Aeg_490888050")]
[DisplayName("Confirmation Rejected Status")]
public partial record ConfirmationRejectedStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RM7EI9p-Ed-ak6NoX_4Aeg_490888052")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectedConfirmationStatusReason1Code Reason { get; init; } 
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RM7EJNp-Ed-ak6NoX_4Aeg_490888068")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; } 
    
    /// <summary>
    /// Proprietary identification of the reason for a rejected status.
    /// </summary>
    [IsoId("_RM7EJdp-Ed-ak6NoX_4Aeg_490888104")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    
    #nullable disable
    
}
