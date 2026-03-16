// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Programme Mode4.
/// </summary>
[IsoId("__--R4W3bEe6dwbOqHXrHWg")]
[DisplayName("Programme Mode4")]
public record ProgrammeMode4
{
    /// <summary>
    /// Additional Identification.
    /// </summary>
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public ValueList<AdditionalData1> AdditionalIdentification { get; init; } = [];

    /// <summary>
    /// Applied Identification.
    /// </summary>
    [DisplayName("Applied Identification")]
    [IsoXmlTag("ApldId")]
    public IsoMax35Text? AppliedIdentification { get; init; }

    /// <summary>
    /// Identification Selected By.
    /// </summary>
    [DisplayName("Identification Selected By")]
    [IsoXmlTag("IdSelctdBy")]
    public PartyType20Code? IdentificationSelectedBy { get; init; }

    /// <summary>
    /// Proposed Identification.
    /// </summary>
    [DisplayName("Proposed Identification")]
    [IsoXmlTag("PropsdId")]
    public ValueList<IsoMax35Text> ProposedIdentification { get; init; } = [];
}
