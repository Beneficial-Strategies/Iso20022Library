// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the reason for requesting a debit authorisation as well as the amount of the requested debit.
/// </summary>
[IsoId("_T9pfUNp-Ed-ak6NoX_4Aeg_-1625876802")]
[DisplayName("Debit Authorisation Details")]
public partial record DebitAuthorisationDetails3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_T9pfUdp-Ed-ak6NoX_4Aeg_787900949")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required CancellationReason2Choice_ CancellationReason { get; init; } 
    
    /// <summary>
    /// Amount of money requested for debit authorisation.
    /// </summary>
    [IsoId("_T9pfUtp-Ed-ak6NoX_4Aeg_-1625876493")]
    [DisplayName("Amount To Debit")]
    [IsoXmlTag("AmtToDbt")]
    public ActiveOrHistoricCurrencyAndAmount? AmountToDebit { get; init; } 
    
    /// <summary>
    /// Value date for debiting the amount.
    /// </summary>
    [IsoId("_T9pfU9p-Ed-ak6NoX_4Aeg_-1625876462")]
    [DisplayName("Value Date To Debit")]
    [IsoXmlTag("ValDtToDbt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDateToDebit { get; init; } 
    
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_T9pfVNp-Ed-ak6NoX_4Aeg_-444152130")]
    [DisplayName("Additional Cancellation Reason Information")]
    [IsoXmlTag("AddtlCxlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalCancellationReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
