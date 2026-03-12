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
[IsoId("_t32wFFkyEeGeoaLUQk__nA_-1574954871")]
[DisplayName("Payment Return Reason")]
public partial record PaymentReturnReason2
{
    #nullable enable
    
    /// <summary>
    /// Bank transaction code included in the original entry for the transaction.
    /// </summary>
    [IsoId("_t4AhEFkyEeGeoaLUQk__nA_762304370")]
    [DisplayName("Original Bank Transaction Code")]
    [IsoXmlTag("OrgnlBkTxCd")]
    public BankTransactionCodeStructure4? OriginalBankTransactionCode { get; init; } 
    
    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [IsoId("_t4AhEVkyEeGeoaLUQk__nA_-1543709317")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification43? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_t4AhElkyEeGeoaLUQk__nA_-1218591810")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_t4AhE1kyEeGeoaLUQk__nA_818217187")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
