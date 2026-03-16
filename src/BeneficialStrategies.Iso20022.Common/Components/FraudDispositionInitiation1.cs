// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the  fraud disposition initiation message.
/// </summary>
[IsoId("_3eE4YXdgEeeKH6vrEwvLHA")]
[DisplayName("Fraud Disposition Initiation")]
public record FraudDispositionInitiation1
{
    /// <summary>
    /// Environment of the transaction
    /// </summary>
    [IsoId("_3prrcXdgEeeKH6vrEwvLHA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment10 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_aNdP0WdwEemXfKijhrqa-Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_3prrc3dgEeeKH6vrEwvLHA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction80 Transaction { get; init; }

    /// <summary>
    /// Contains the disposition of the previously submitted fraud reporting message.
    /// </summary>
    [IsoId("_fSkhMHdhEeeKH6vrEwvLHA")]
    [DisplayName("Fraud Disposition Status")]
    [IsoXmlTag("FrdDspstnSts")]
    public required FraudDispositionStatus1 FraudDispositionStatus { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_GhJh8Zi-EeefZKJHxQTztg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
