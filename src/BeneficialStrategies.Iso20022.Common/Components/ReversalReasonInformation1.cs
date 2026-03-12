// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information on the reversal reason of the transaction.
/// </summary>
[IsoId("_TPKBodp-Ed-ak6NoX_4Aeg_157540470")]
[DisplayName("Reversal Reason Information")]
public partial record ReversalReasonInformation1
{
    #nullable enable
    
    /// <summary>
    /// Party issuing the reversal.
    /// </summary>
    [IsoId("_TPKBotp-Ed-ak6NoX_4Aeg_157540608")]
    [DisplayName("Reversal Originator")]
    [IsoXmlTag("RvslOrgtr")]
    public PartyIdentification8? ReversalOriginator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_TPKBo9p-Ed-ak6NoX_4Aeg_157540556")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public ReversalReason1Choice_? ReversalReason { get; init; } 
    
    /// <summary>
    /// Further details on the reversal reason.
    /// </summary>
    [IsoId("_TPKBpNp-Ed-ak6NoX_4Aeg_157540512")]
    [DisplayName("Additional Reversal Reason Information")]
    [IsoXmlTag("AddtlRvslRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalReversalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
