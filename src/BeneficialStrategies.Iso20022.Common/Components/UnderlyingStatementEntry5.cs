// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Underlying Statement Entry5.
/// </summary>
[IsoId("_-kS_ARZ4Ee6d6Ip1Ob2kaQ")]
[DisplayName("Underlying Statement Entry5")]
public record UnderlyingStatementEntry5
{
    /// <summary>
    /// Original Account.
    /// </summary>
    [DisplayName("Original Account")]
    [IsoXmlTag("OrgnlAcct")]
    public CashAccount40? OriginalAccount { get; init; }

    /// <summary>
    /// Original Entry Amount.
    /// </summary>
    [DisplayName("Original Entry Amount")]
    [IsoXmlTag("OrgnlNtryAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalEntryAmount { get; init; }

    /// <summary>
    /// Original Entry Reference.
    /// </summary>
    [DisplayName("Original Entry Reference")]
    [IsoXmlTag("OrgnlNtryRef")]
    public IsoMax35Text? OriginalEntryReference { get; init; }

    /// <summary>
    /// Original Entry Value Date.
    /// </summary>
    [DisplayName("Original Entry Value Date")]
    [IsoXmlTag("OrgnlNtryValDt")]
    public DateAndDateTime2Choice_? OriginalEntryValueDate { get; init; }

    /// <summary>
    /// Original Group Information.
    /// </summary>
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Original Statement Identification.
    /// </summary>
    [DisplayName("Original Statement Identification")]
    [IsoXmlTag("OrgnlStmtId")]
    public IsoMax35Text? OriginalStatementIdentification { get; init; }

    /// <summary>
    /// Original UETR.
    /// </summary>
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }
}
