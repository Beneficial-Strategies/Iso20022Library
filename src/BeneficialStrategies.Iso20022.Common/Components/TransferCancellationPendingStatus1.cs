// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer cancellation status is in pending.
/// </summary>
[IsoId("_RQf8l9p-Ed-ak6NoX_4Aeg_1012324214")]
[DisplayName("Transfer Cancellation Pending Status")]
public partial record TransferCancellationPendingStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the cancellation pending status.
    /// </summary>
    [IsoId("_RQf8mNp-Ed-ak6NoX_4Aeg_1012324216")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Reason { get; init; } 
    
    
    #nullable disable
    
}
