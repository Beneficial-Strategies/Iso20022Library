// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Body of the Abort Request message.
/// </summary>
[IsoId("_89uIsbZdEfCUZfsQO4rYeA")]
[DisplayName("Abort Data7")]
public record AbortData7
{
    /// <summary>
    /// Message identifier.
    /// </summary>
    [IsoId("_8-outbZdEfCUZfsQO4rYeA")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    public required IsoMax35Text ExchangeIdentification { get; init; }

    /// <summary>
    /// Reason of aborting a transaction.
    /// </summary>
    [IsoId("_8-ouu7ZdEfCUZfsQO4rYeA")]
    [DisplayName("Abort Reason")]
    [IsoXmlTag("AbrtRsn")]
    public required IsoMax140Text AbortReason { get; init; }

    /// <summary>
    /// To display an abort message to the Customer.
    /// </summary>
    [IsoId("_8-ouwbZdEfCUZfsQO4rYeA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage12? DisplayOutput { get; init; }

    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    [IsoId("_8-oux7ZdEfCUZfsQO4rYeA")]
    [DisplayName("Transaction Success")]
    [IsoXmlTag("TxSucss")]
    public IsoTrueFalseIndicator? TransactionSuccess { get; init; }
}
