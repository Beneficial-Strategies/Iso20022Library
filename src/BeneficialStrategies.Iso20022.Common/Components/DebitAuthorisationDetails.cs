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
[IsoId("_T9Wkbdp-Ed-ak6NoX_4Aeg_1878930583")]
[DisplayName("Debit Authorisation Details")]
public partial record DebitAuthorisationDetails
{
    #nullable enable
    
    /// <summary>
    /// Indicates the reason for cancellation.
    /// </summary>
    [IsoId("_T9Wkbtp-Ed-ak6NoX_4Aeg_-3725158")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required CancellationReason1Code CancellationReason { get; init; } 
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_T9gVYNp-Ed-ak6NoX_4Aeg_1362682200")]
    [DisplayName("Amount To Debit")]
    [IsoXmlTag("AmtToDbt")]
    public CurrencyAndAmount? AmountToDebit { get; init; } 
    
    /// <summary>
    /// Value date for debiting the amount.
    /// </summary>
    [IsoId("_T9gVYdp-Ed-ak6NoX_4Aeg_-19191221")]
    [DisplayName("Value Date To Debit")]
    [IsoXmlTag("ValDtToDbt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDateToDebit { get; init; } 
    
    
    #nullable disable
    
}
