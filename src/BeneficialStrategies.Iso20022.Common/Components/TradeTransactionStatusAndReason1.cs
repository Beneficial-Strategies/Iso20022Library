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
[IsoId("_RXNBgNp-Ed-ak6NoX_4Aeg_1004804431")]
[DisplayName("Trade Transaction Status And Reason")]
public partial record TradeTransactionStatusAndReason1
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the RegulatoryTransactionReport document that was previously sent by the reporting institution.
    /// </summary>
    [IsoId("_RXNBgdp-Ed-ak6NoX_4Aeg_494321735")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RelatedReference { get; init; } 
    
    /// <summary>
    /// Unique identification assigned to a trade once it is received or matched by an executing system.
    /// </summary>
    [IsoId("_RXNBgtp-Ed-ak6NoX_4Aeg_-1568988274")]
    [DisplayName("Trade Reference")]
    [IsoXmlTag("TradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text TradeReference { get; init; } 
    
    /// <summary>
    /// Indicates the status of a trade transaction.
    /// </summary>
    [IsoId("_RXNBg9p-Ed-ak6NoX_4Aeg_461506778")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status2Code Status { get; init; } 
    
    /// <summary>
    /// Indicates that the report is rejected and provides a reason why.
    /// </summary>
    [IsoId("_RXNBhNp-Ed-ak6NoX_4Aeg_1291723379")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    [MinLength(1)]
    [MaxLength(100)]
    public ValueList<RejectedStatusReason9Choice_> Rejected { get; init; } = new ValueList<RejectedStatusReason9Choice_>(){};
    
    
    #nullable disable
    
}
