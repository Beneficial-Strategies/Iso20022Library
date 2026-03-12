// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the return of the transaction.
/// </summary>
[IsoId("_nBkHYbTREeeyuKckOGlwuA")]
[DisplayName("Payment Return Reason")]
public partial record PaymentReturnReason3
{
    #nullable enable
    
    /// <summary>
    /// Bank transaction code included in the original entry for the transaction.
    /// </summary>
    [IsoId("_nKYFJbTREeeyuKckOGlwuA")]
    [DisplayName("Original Bank Transaction Code")]
    [IsoXmlTag("OrgnlBkTxCd")]
    public BankTransactionCodeStructure4? OriginalBankTransactionCode { get; init; } 
    
    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [IsoId("_nKYFJ7TREeeyuKckOGlwuA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification125? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_nKYFKbTREeeyuKckOGlwuA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_nKYFK7TREeeyuKckOGlwuA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
