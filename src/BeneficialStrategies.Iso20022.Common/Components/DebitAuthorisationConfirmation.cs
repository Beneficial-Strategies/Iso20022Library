// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates if the debit authorisation is granted or not.
/// </summary>
[IsoId("_T9WkaNp-Ed-ak6NoX_4Aeg_2085142381")]
[DisplayName("Debit Authorisation Confirmation")]
public partial record DebitAuthorisationConfirmation
{
    #nullable enable
    
    /// <summary>
    /// Code expressing the decision taken by the account owner relative to the request for debit authorization.
    /// </summary>
    [IsoId("_T9Wkadp-Ed-ak6NoX_4Aeg_2126703723")]
    [DisplayName("Debit Authorisation")]
    [IsoXmlTag("DbtAuthstn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator DebitAuthorisation { get; init; } 
    
    /// <summary>
    /// Amount authorised for debit. The party providing the debit authority may want to authorise the amount less charges and they may only be prepared to approve the debit for value today rather than the original value date.
    /// </summary>
    [IsoId("_T9Wkatp-Ed-ak6NoX_4Aeg_884935578")]
    [DisplayName("Amount To Debit")]
    [IsoXmlTag("AmtToDbt")]
    public CurrencyAndAmount? AmountToDebit { get; init; } 
    
    /// <summary>
    /// Value date for debiting the amount.
    /// </summary>
    [IsoId("_T9Wka9p-Ed-ak6NoX_4Aeg_884935673")]
    [DisplayName("Value Date To Debit")]
    [IsoXmlTag("ValDtToDbt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDateToDebit { get; init; } 
    
    /// <summary>
    /// Justification of the (partial) debit authorisation.
    /// </summary>
    [IsoId("_T9WkbNp-Ed-ak6NoX_4Aeg_-1553869979")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Reason { get; init; } 
    
    
    #nullable disable
    
}
