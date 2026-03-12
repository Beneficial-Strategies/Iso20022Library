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
[IsoId("_RXgjgNp-Ed-ak6NoX_4Aeg_167456466")]
[DisplayName("Report Status And Reason")]
public partial record ReportStatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the RegulatoryTransactionReportCancellationRequest document that was previously sent by the reporting institution.
    /// </summary>
    [IsoId("_RXgjgdp-Ed-ak6NoX_4Aeg_167456485")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RelatedReference { get; init; } 
    
    /// <summary>
    /// Indicates the status of a report cancellation request message.
    /// </summary>
    [IsoId("_RXgjgtp-Ed-ak6NoX_4Aeg_167456544")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status2Code Status { get; init; } 
    
    /// <summary>
    /// Indicates that the cancellation is rejected and provides a reason why.
    /// </summary>
    [IsoId("_RXgjg9p-Ed-ak6NoX_4Aeg_167456605")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    [MinLength(1)]
    [MaxLength(100)]
    public ValueList<RejectedCancellationStatusReason1Choice_> Rejected { get; init; } = new ValueList<RejectedCancellationStatusReason1Choice_>(){};
    
    
    #nullable disable
    
}
