// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details to identify a financial institution.
/// </summary>
[IsoId("_uZGyd9-2Ee-Ned3-G07x_A")]
[DisplayName("Financial Institution Identification28")]
public record FinancialInstitutionIdentification28
{
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362.
    /// </summary>
    [IsoId("_uZGyfd-2Ee-Ned3-G07x_A")]
    [DisplayName("BICFI")]
    [IsoXmlTag("BICFI")]
    public IsoBICFIDec2014Identifier? BICFI { get; init; }

    /// <summary>
    /// Legal entity identifier of the financial institution.
    /// </summary>
    [IsoId("_uZGye9-2Ee-Ned3-G07x_A")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_uZGyfN-2Ee-Ned3-G07x_A")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericFinancialIdentification1? Other { get; init; }
}
