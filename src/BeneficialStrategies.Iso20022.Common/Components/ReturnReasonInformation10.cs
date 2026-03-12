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
[IsoId("_TP6PlNp-Ed-ak6NoX_4Aeg_1913342073")]
[DisplayName("Return Reason Information")]
public partial record ReturnReasonInformation10
{
    #nullable enable
    
    /// <summary>
    /// Bank transaction code included in the original entry for the transaction.
    /// </summary>
    [IsoId("_TP6Pldp-Ed-ak6NoX_4Aeg_1913342289")]
    [DisplayName("Original Bank Transaction Code")]
    [IsoXmlTag("OrgnlBkTxCd")]
    public BankTransactionCodeStructure4? OriginalBankTransactionCode { get; init; } 
    
    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [IsoId("_TP6Pltp-Ed-ak6NoX_4Aeg_1913342598")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_TP6Pl9p-Ed-ak6NoX_4Aeg_1913342227")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_TP6PmNp-Ed-ak6NoX_4Aeg_1913342104")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
