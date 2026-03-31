// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Debit Authorisation Confirmation3.
/// </summary>
[IsoId("_1TU1Ua6uEe2PjM01bHafYg")]
[DisplayName("Debit Authorisation Confirmation3")]
public record DebitAuthorisationConfirmation3
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Amount To Debit.
    /// </summary>
    [DisplayName("Amount To Debit")]
    [IsoXmlTag("AmtToDbt")]
    public ActiveCurrencyAndAmount? AmountToDebit { get; init; }

    /// <summary>
    /// Common Transaction Identification.
    /// </summary>
    [DisplayName("Common Transaction Identification")]
    [IsoXmlTag("CmonTxId")]
    public IsoMax52Text? CommonTransactionIdentification { get; init; }

    /// <summary>
    /// Debit Authorisation.
    /// </summary>
    [DisplayName("Debit Authorisation")]
    [IsoXmlTag("DbtAuthstn")]
    public required IsoTrueFalseIndicator DebitAuthorisation { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public IsoMax140Text? Reason { get; init; }

    /// <summary>
    /// Value Date To Debit.
    /// </summary>
    [DisplayName("Value Date To Debit")]
    [IsoXmlTag("ValDtToDbt")]
    public IsoISODate? ValueDateToDebit { get; init; }
}
