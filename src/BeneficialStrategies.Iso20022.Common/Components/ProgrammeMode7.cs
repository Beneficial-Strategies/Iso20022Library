// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proposed or applied programme, network, or brand processes the transaction.
/// </summary>
[IsoId("_JwPJwSHxEfCkq6-p7S3J1Q")]
[DisplayName("Programme Mode7")]
public record ProgrammeMode7
{
    /// <summary>
    /// Identification of Programme, network, or brand proposed for the transaction.
    /// </summary>
    [IsoId("_Jy0jsSHxEfCkq6-p7S3J1Q")]
    [DisplayName("Proposed Identification")]
    [IsoXmlTag("PropsdId")]
    public SimpleValueList<IsoMax35Text> ProposedIdentification { get; init; } = [];

    /// <summary>
    /// Identification of Programme, network, or brand actually applied to the transaction.
    /// </summary>
    [IsoId("_Jy0jsyHxEfCkq6-p7S3J1Q")]
    [DisplayName("Applied Identification")]
    [IsoXmlTag("ApldId")]
    public IsoMax35Text? AppliedIdentification { get; init; }

    /// <summary>
    /// Identification of the programme, network, or brand.
    /// </summary>
    [IsoId("_Jy0jtyHxEfCkq6-p7S3J1Q")]
    [DisplayName("Identification Selected By")]
    [IsoXmlTag("IdSelctdBy")]
    public PartyType20Code? IdentificationSelectedBy { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_Ty4sMkVYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_Ty4sM0VYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
