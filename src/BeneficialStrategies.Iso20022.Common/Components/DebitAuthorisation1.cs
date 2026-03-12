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
[IsoId("_t4cl-FkyEeGeoaLUQk__nA_820376924")]
[DisplayName("Debit Authorisation")]
public partial record DebitAuthorisation1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_t4mW8FkyEeGeoaLUQk__nA_-2083539038")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required CancellationReason14Choice_ CancellationReason { get; init; } 
    
    /// <summary>
    /// Amount of money requested for debit authorisation.
    /// </summary>
    [IsoId("_t4mW8VkyEeGeoaLUQk__nA_256189912")]
    [DisplayName("Amount To Debit")]
    [IsoXmlTag("AmtToDbt")]
    public ActiveOrHistoricCurrencyAndAmount? AmountToDebit { get; init; } 
    
    /// <summary>
    /// Value date for debiting the amount.
    /// </summary>
    [IsoId("_t4mW8lkyEeGeoaLUQk__nA_108386986")]
    [DisplayName("Value Date To Debit")]
    [IsoXmlTag("ValDtToDbt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDateToDebit { get; init; } 
    
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_t4mW81kyEeGeoaLUQk__nA_1939310155")]
    [DisplayName("Additional Cancellation Reason Information")]
    [IsoXmlTag("AddtlCxlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalCancellationReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
