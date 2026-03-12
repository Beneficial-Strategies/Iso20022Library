// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the reason of the return of the transaction.
/// </summary>
[IsoId("_TQDZg9p-Ed-ak6NoX_4Aeg_-415808124")]
[DisplayName("Return Reason Information")]
public partial record ReturnReasonInformation9
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [IsoId("_TQDZhNp-Ed-ak6NoX_4Aeg_-415807751")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_TQDZhdp-Ed-ak6NoX_4Aeg_-415807661")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_TQDZhtp-Ed-ak6NoX_4Aeg_-415808122")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
