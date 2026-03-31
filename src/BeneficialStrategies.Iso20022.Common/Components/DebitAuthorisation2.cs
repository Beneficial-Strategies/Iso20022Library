// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the reason for requesting a debit authorisation as well as the amount of the requested debit.
/// </summary>
[IsoId("_xUfkRUgtEeaGKYpLDboHPQ")]
[DisplayName("Debit Authorisation")]
public record DebitAuthorisation2
{
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_xeOH00gtEeaGKYpLDboHPQ")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required CancellationReason33Choice_ CancellationReason { get; init; }

    /// <summary>
    /// Amount of money requested for debit authorisation.
    /// </summary>
    [IsoId("_xeOH1UgtEeaGKYpLDboHPQ")]
    [DisplayName("Amount To Debit")]
    [IsoXmlTag("AmtToDbt")]
    public ActiveOrHistoricCurrencyAndAmount? AmountToDebit { get; init; }

    /// <summary>
    /// Value date for debiting the amount.
    /// </summary>
    [IsoId("_xeOH10gtEeaGKYpLDboHPQ")]
    [DisplayName("Value Date To Debit")]
    [IsoXmlTag("ValDtToDbt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDateToDebit { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_xeOH2UgtEeaGKYpLDboHPQ")]
    [DisplayName("Additional Cancellation Reason Information")]
    [IsoXmlTag("AddtlCxlRsnInf")]
    public SimpleValueList<IsoMax105Text> AdditionalCancellationReasonInformation { get; init; } =
        [];
}
