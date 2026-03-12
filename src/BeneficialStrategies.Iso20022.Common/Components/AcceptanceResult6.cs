// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide detailed information on the acceptance result.
/// </summary>
[IsoId("_RBvu4dp-Ed-ak6NoX_4Aeg_2046006177")]
[DisplayName("Acceptance Result")]
public partial record AcceptanceResult6
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the mandate request was accepted or rejected.
    /// </summary>
    [IsoId("_RBvu4tp-Ed-ak6NoX_4Aeg_1773632231")]
    [DisplayName("Accepted")]
    [IsoXmlTag("Accptd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Accepted { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the rejection of a mandate request.
    /// </summary>
    [IsoId("_RBvu49p-Ed-ak6NoX_4Aeg_1929136883")]
    [DisplayName("Reject Reason")]
    [IsoXmlTag("RjctRsn")]
    public MandateReason1Choice_? RejectReason { get; init; } 
    
    /// <summary>
    /// Further details on the reject reason.
    /// </summary>
    [IsoId("_RBvu5Np-Ed-ak6NoX_4Aeg_-192674430")]
    [DisplayName("Additional Reject Reason Information")]
    [IsoXmlTag("AddtlRjctRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalRejectReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
