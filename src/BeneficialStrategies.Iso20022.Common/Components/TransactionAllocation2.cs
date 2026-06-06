// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify each underlying allocation.
/// </summary>
[IsoId("_eH5OcbpXEfCPZvweyV2nEg")]
[DisplayName("Transaction Allocation2")]
public record TransactionAllocation2
{
    /// <summary>
    /// Amount of money in the allocation.
    /// </summary>
    [IsoId("_eP7wI7pXEfCPZvweyV2nEg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Specifies whether the allocation is a debit or credit.
    /// </summary>
    [IsoId("_eP7wJbpXEfCPZvweyV2nEg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which the allocation is due or from.
    /// </summary>
    [IsoId("_eP7wJ7pXEfCPZvweyV2nEg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount40 Account { get; init; }

    /// <summary>
    /// Underlying reason for the allocation.
    /// </summary>
    [IsoId("_eP7wKbpXEfCPZvweyV2nEg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public required Purpose2Choice_ Purpose { get; init; }

    /// <summary>
    /// Reference for the allocation.
    /// </summary>
    [IsoId("_eP7wK7pXEfCPZvweyV2nEg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Reference relating to the allocation which is meaningful to both parties (for example the original Securities Settlement Transaction Identification).
    /// </summary>
    [IsoId("_eP7wLbpXEfCPZvweyV2nEg")]
    [DisplayName("Related References")]
    [IsoXmlTag("RltdRefs")]
    public ValueList<References80Choice_> RelatedReferences { get; init; } = [];
}
