// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the rejection status of a global movement.
/// </summary>
[IsoId("_RlXZUtp-Ed-ak6NoX_4Aeg_-2041243325")]
[DisplayName("Distribution Rejection Status")]
public partial record DistributionRejectionStatus1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_RlXZU9p-Ed-ak6NoX_4Aeg_-1641361615")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason19FormatChoice_> Reason { get; init; } = new ValueList<RejectionReason19FormatChoice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RlXZU9p-Ed-ak6NoX_4Aeg_-1641361615
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RlXZVNp-Ed-ak6NoX_4Aeg_-1641361369")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
