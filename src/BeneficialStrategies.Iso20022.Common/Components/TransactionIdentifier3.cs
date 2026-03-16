// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Identifier3.
/// </summary>
[IsoId("_AV-gMZ9XEe-nbM0aSPcoiQ")]
[DisplayName("Transaction Identifier3")]
public record TransactionIdentifier3
{
    /// <summary>
    /// Host Transaction Date Time.
    /// </summary>
    [DisplayName("Host Transaction Date Time")]
    [IsoXmlTag("HstTxDtTm")]
    public IsoISODateTime? HostTransactionDateTime { get; init; }

    /// <summary>
    /// Transaction Date Time.
    /// </summary>
    [DisplayName("Transaction Date Time")]
    [IsoXmlTag("TxDtTm")]
    public required IsoISODateTime TransactionDateTime { get; init; }

    /// <summary>
    /// Transaction Reference.
    /// </summary>
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    public required IsoMax35Text TransactionReference { get; init; }
}
