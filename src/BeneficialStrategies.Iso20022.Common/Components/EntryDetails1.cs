// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the underlying transaction(s) and/or batched entries.
/// </summary>
[IsoId("_T8wuitp-Ed-ak6NoX_4Aeg_-120854203")]
[DisplayName("Entry Details")]
public record EntryDetails1
{
    /// <summary>
    /// Set of elements used to provide details on batched transactions.
    /// </summary>
    [IsoId("_T854cNp-Ed-ak6NoX_4Aeg_-250805702")]
    [DisplayName("Batch")]
    [IsoXmlTag("Btch")]
    public BatchInformation2? Batch { get; init; }

    /// <summary>
    /// Set of elements used to provide information on the underlying transaction(s).
    /// </summary>
    [IsoId("_T854cdp-Ed-ak6NoX_4Aeg_-250805756")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ValueList<EntryTransaction2> TransactionDetails { get; init; } = [];
}
