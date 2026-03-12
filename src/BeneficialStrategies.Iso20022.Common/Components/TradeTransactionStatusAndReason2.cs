// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the transaction with a trade reference and provides its status. If the status is rejected, a reason for this status must be given.
/// </summary>
[IsoId("_RXgjh9p-Ed-ak6NoX_4Aeg_587723747")]
[DisplayName("Trade Transaction Status And Reason")]
public partial record TradeTransactionStatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the RegulatoryTransactionReportCancellationRequest document that was previously sent by the reporting institution.
    /// </summary>
    [IsoId("_RXgjiNp-Ed-ak6NoX_4Aeg_851724068")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RelatedReference { get; init; } 
    
    /// <summary>
    /// Unique identification assigned to a trade once it is received or matched by an executing system.
    /// </summary>
    [IsoId("_RXgjidp-Ed-ak6NoX_4Aeg_987608632")]
    [DisplayName("Trade Reference")]
    [IsoXmlTag("TradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text TradeReference { get; init; } 
    
    /// <summary>
    /// Indicates the status of an instruction, request or report message.
    /// </summary>
    [IsoId("_RXgjitp-Ed-ak6NoX_4Aeg_587724041")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status2Code Status { get; init; } 
    
    /// <summary>
    /// Indicates that the cancellation is rejected and provides a reason why.
    /// </summary>
    [IsoId("_RXptcNp-Ed-ak6NoX_4Aeg_587724102")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    [MinLength(1)]
    [MaxLength(100)]
    public ValueList<RejectedCancellationStatusReason1Choice_> Rejected { get; init; } = new ValueList<RejectedCancellationStatusReason1Choice_>(){};
    
    
    #nullable disable
    
}
