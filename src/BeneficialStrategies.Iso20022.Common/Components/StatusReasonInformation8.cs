// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the status reason of the transaction.
/// </summary>
[IsoId("_TRPsUNp-Ed-ak6NoX_4Aeg_1156620566")]
[DisplayName("Status Reason Information")]
public partial record StatusReasonInformation8
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the status.
    /// </summary>
    [IsoId("_TRPsUdp-Ed-ak6NoX_4Aeg_1156620782")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_TRPsUtp-Ed-ak6NoX_4Aeg_1156620691")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public StatusReason6Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_TRPsU9p-Ed-ak6NoX_4Aeg_1156620597")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
