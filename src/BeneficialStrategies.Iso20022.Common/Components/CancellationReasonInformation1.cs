// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information on the cancellation reason of the transaction.
/// </summary>
[IsoId("_TO3Gttp-Ed-ak6NoX_4Aeg_-436227161")]
[DisplayName("Cancellation Reason Information")]
public partial record CancellationReasonInformation1
{
    #nullable enable
    
    /// <summary>
    /// Party issuing the cancellation request.
    /// </summary>
    [IsoId("_TO3Gt9p-Ed-ak6NoX_4Aeg_-436226813")]
    [DisplayName("Cancellation Originator")]
    [IsoXmlTag("CxlOrgtr")]
    public PartyIdentification8? CancellationOriginator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the cancellation.
    /// </summary>
    [IsoId("_TPA3sNp-Ed-ak6NoX_4Aeg_-436226866")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public CancellationReason1Choice_? CancellationReason { get; init; } 
    
    /// <summary>
    /// Further details on the cancellation request reason.||Usage: Additional cancellation reason information can be used to further detail the cancellation request reason.
    /// </summary>
    [IsoId("_TPA3sdp-Ed-ak6NoX_4Aeg_-436227125")]
    [DisplayName("Additional Cancellation Reason Information")]
    [IsoXmlTag("AddtlCxlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalCancellationReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
