// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Applied programme, network, or brand processes the transaction.
/// </summary>
[IsoId("_DuuKsRWlEfC_aaedwHHlmw")]
[DisplayName("Programme Mode6")]
public record ProgrammeMode6
{
    /// <summary>
    /// Identification of Programme, network, or brand proposed for the transaction.
    /// </summary>
    [IsoId("_GJ2wYRWlEfC_aaedwHHlmw")]
    [DisplayName("Proposed Identification")]
    [IsoXmlTag("PropsdId")]
    public SimpleValueList<IsoMax35Text> ProposedIdentification { get; init; } = [];

    /// <summary>
    /// Identification of the programme, network, or brand applied to the transaction.
    /// </summary>
    [IsoId("_D2p-sRWlEfC_aaedwHHlmw")]
    [DisplayName("Applied Identification")]
    [IsoXmlTag("ApldId")]
    public required IsoMax35Text AppliedIdentification { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_PWRewml6EfCyxsm1jzUNug")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_PWRew2l6EfCyxsm1jzUNug")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
