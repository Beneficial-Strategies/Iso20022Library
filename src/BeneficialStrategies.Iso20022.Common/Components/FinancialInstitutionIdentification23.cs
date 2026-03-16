// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial Institution Identification23.
/// </summary>
[IsoId("_v2tzSTEyEe6g-ffJsqGiSA")]
[DisplayName("Financial Institution Identification23")]
public record FinancialInstitutionIdentification23
{
    /// <summary>
    /// BICFI.
    /// </summary>
    [DisplayName("BICFI")]
    [IsoXmlTag("BICFI")]
    public IsoBICFIDec2014Identifier? BICFI { get; init; }

    /// <summary>
    /// Clearing System Member Identification.
    /// </summary>
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; }

    /// <summary>
    /// LEI.
    /// </summary>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericFinancialIdentification1? Other { get; init; }

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress27? PostalAddress { get; init; }
}
