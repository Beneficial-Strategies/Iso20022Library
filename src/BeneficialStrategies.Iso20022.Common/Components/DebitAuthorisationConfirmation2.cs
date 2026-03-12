// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether or not the debit authorisation is granted.
/// </summary>
[IsoId("_T9pfVdp-Ed-ak6NoX_4Aeg_-1701633190")]
[DisplayName("Debit Authorisation Confirmation")]
public partial record DebitAuthorisationConfirmation2
{
    #nullable enable
    
    /// <summary>
    /// Code expressing the decision taken by the account owner relative to the request for debit authorization.
    /// </summary>
    [IsoId("_T9pfVtp-Ed-ak6NoX_4Aeg_-1701633188")]
    [DisplayName("Debit Authorisation")]
    [IsoXmlTag("DbtAuthstn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator DebitAuthorisation { get; init; } 
    
    /// <summary>
    /// Amount of money authorised for debit. |Usage: The party approving the debit may want to authorise the amount less charges and may only be prepared to approve the debit for value today rather than the original value date.
    /// </summary>
    [IsoId("_T9zQUNp-Ed-ak6NoX_4Aeg_-1701633129")]
    [DisplayName("Amount To Debit")]
    [IsoXmlTag("AmtToDbt")]
    public ActiveCurrencyAndAmount? AmountToDebit { get; init; } 
    
    /// <summary>
    /// Value date for debiting the amount.
    /// </summary>
    [IsoId("_T9zQUdp-Ed-ak6NoX_4Aeg_-1701632850")]
    [DisplayName("Value Date To Debit")]
    [IsoXmlTag("ValDtToDbt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDateToDebit { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the debit authorisation request.
    /// </summary>
    [IsoId("_T9zQUtp-Ed-ak6NoX_4Aeg_-1701632820")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Reason { get; init; } 
    
    
    #nullable disable
    
}
