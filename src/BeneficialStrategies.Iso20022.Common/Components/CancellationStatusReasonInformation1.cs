// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the status of the cancellation request.
/// </summary>
[IsoId("_TPwek9p-Ed-ak6NoX_4Aeg_1694475325")]
[DisplayName("Cancellation Status Reason Information")]
public partial record CancellationStatusReasonInformation1
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation status.
    /// </summary>
    [IsoId("_TPwelNp-Ed-ak6NoX_4Aeg_1694475696")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_TPweldp-Ed-ak6NoX_4Aeg_1694475418")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public CancellationStatusReason1Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Further details on the cancellation status reason.
    /// </summary>
    [IsoId("_TPweltp-Ed-ak6NoX_4Aeg_1694475355")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
