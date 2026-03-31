// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of the business message envelope.
/// </summary>
[IsoId("_QhajIK9aEeyk7opzt6Qlaw")]
[DisplayName("Reference")]
public record Reference22
{
    /// <summary>
    /// Name of the reference.
    /// </summary>
    [IsoId("_ft3fMK9aEeyk7opzt6Qlaw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    [IsoId("_nS5W4K9aEeyk7opzt6Qlaw")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification135 Issuer { get; init; }

    /// <summary>
    /// Value of the reference.
    /// </summary>
    [IsoId("_1H4JsK9aEeyk7opzt6Qlaw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required ReferenceValue1Choice_ Value { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_SQnacK9bEeyk7opzt6Qlaw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
