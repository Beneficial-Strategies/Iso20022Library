// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the related report identification and its status. If the status is rejected, a reason for this status must be given.
/// </summary>
[IsoId("_RXWygNp-Ed-ak6NoX_4Aeg_-1224288491")]
[DisplayName("Report Status And Reason")]
public partial record ReportStatusAndReason1
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the RegulatoryTransactionReport document that was previously sent by the reporting institution.
    /// </summary>
    [IsoId("_RXWygdp-Ed-ak6NoX_4Aeg_-1224288239")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RelatedReference { get; init; } 
    
    /// <summary>
    /// Indicates the status of a report message.
    /// </summary>
    [IsoId("_RXWygtp-Ed-ak6NoX_4Aeg_-1224288118")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status2Code Status { get; init; } 
    
    /// <summary>
    /// Indicates that the report is rejected and provides a reason why.
    /// </summary>
    [IsoId("_RXWyg9p-Ed-ak6NoX_4Aeg_-1224287697")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    [MinLength(1)]
    [MaxLength(100)]
    public ValueList<RejectedStatusReason9Choice_> Rejected { get; init; } = new ValueList<RejectedStatusReason9Choice_>(){};
    
    
    #nullable disable
    
}
