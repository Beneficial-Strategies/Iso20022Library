// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify each underlying allocation.
/// </summary>
[IsoId("_eH5OcbpXEfCPZvweyV2nEg")]
public interface ITransactionAllocation2 : IIsoComponent
{
    /// <summary>
    /// Amount of money in the allocation.
    /// </summary>
    [IsoId("_eP7wI7pXEfCPZvweyV2nEg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount Amount { get; }

    /// <summary>
    /// Specifies whether the allocation is a debit or credit.
    /// </summary>
    [IsoId("_eP7wJbpXEfCPZvweyV2nEg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    CreditDebitCode CreditDebitIndicator { get; }

    /// <summary>
    /// Unambiguous identification of the account to which the allocation is due or from.
    /// </summary>
    [IsoId("_eP7wJ7pXEfCPZvweyV2nEg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    ICashAccount40 Account { get; }

    /// <summary>
    /// Underlying reason for the allocation.
    /// </summary>
    [IsoId("_eP7wKbpXEfCPZvweyV2nEg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    IPurpose2Choice Purpose { get; }

    /// <summary>
    /// Reference for the allocation.
    /// </summary>
    [IsoId("_eP7wK7pXEfCPZvweyV2nEg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    Max35Text Reference { get; }

    /// <summary>
    /// Reference relating to the allocation which is meaningful to both parties (for example the original Securities Settlement Transaction Identification).
    /// </summary>
    [IsoId("_eP7wLbpXEfCPZvweyV2nEg")]
    [DisplayName("Related References")]
    [IsoXmlTag("RltdRefs")]
    IEnumerable<IReferences80Choice> RelatedReferences { get; }
}
