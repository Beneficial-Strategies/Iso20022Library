// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Debit Authorisation3.
/// </summary>
[IsoId("_2wXxsRZiEe6d6Ip1Ob2kaQ")]
[DisplayName("Debit Authorisation3")]
public partial record DebitAuthorisation3
{
    #nullable enable

    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; } 

    /// <summary>
    /// Additional Cancellation Reason Information.
    /// </summary>
    [DisplayName("Additional Cancellation Reason Information")]
    [IsoXmlTag("AddtlCxlRsnInf")]
    public ValueList<IsoMax140Text> AdditionalCancellationReasonInformation { get; init; } = [];

    /// <summary>
    /// Amount To Debit.
    /// </summary>
    [DisplayName("Amount To Debit")]
    [IsoXmlTag("AmtToDbt")]
    public ActiveOrHistoricCurrencyAndAmount? AmountToDebit { get; init; } 

    /// <summary>
    /// Cancellation Reason.
    /// </summary>
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required CancellationReason33Choice_ CancellationReason { get; init; } 

    /// <summary>
    /// Value Date To Debit.
    /// </summary>
    [DisplayName("Value Date To Debit")]
    [IsoXmlTag("ValDtToDbt")]
    public IsoISODate? ValueDateToDebit { get; init; } 

    
    #nullable disable
    
}
