// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the split details.
/// </summary>
[IsoId("989c79b0-c096-45d8-b73c-e0001d518247")]
[DisplayName("Split Obligation Attributes1")]
public record SplitObligationAttributes1
{
    /// <summary>
    /// Reference for the split obligation.
    /// </summary>
    [IsoId("858010ab-86bb-42db-94fe-61f38a0df1fa")]
    [DisplayName("Obligation Identification")]
    [IsoXmlTag("OblgtnId")]
    public required IsoMax35Text ObligationIdentification { get; init; }

    /// <summary>
    /// Sequence number for the split.
    /// </summary>
    [IsoId("8b850219-f6d1-4b1e-945e-a6582608ea4f")]
    [DisplayName("Split Sequence Number")]
    [IsoXmlTag("SpltSeqNb")]
    public required IsoMax15NumericText SplitSequenceNumber { get; init; }

    /// <summary>
    /// Amount of money for the split.
    /// </summary>
    [IsoId("93cf70ca-50ae-4ede-8b20-b2608da8e4a8")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
