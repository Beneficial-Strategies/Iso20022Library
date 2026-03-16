// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification309.
/// </summary>
[IsoId("_0qWpIX_yEe-5A_neRtHpSQ")]
[DisplayName("Party Identification309")]
public record PartyIdentification309
{
    /// <summary>
    /// Any BIC.
    /// </summary>
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; }

    /// <summary>
    /// Clearing System Member Identification.
    /// </summary>
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    public ClearingSystemMemberIdentification2Choice_? ClearingSystemMemberIdentification { get; init; }

    /// <summary>
    /// LEI.
    /// </summary>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Name And Address.
    /// </summary>
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress5? NameAndAddress { get; init; }

    /// <summary>
    /// Proprietary Identification.
    /// </summary>
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification1? ProprietaryIdentification { get; init; }
}
