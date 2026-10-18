// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IFinancialInstitutionIdentification23"/>
[IsoId("_v2tzSTEyEe6g-ffJsqGiSA")]
[DisplayName("Financial Institution Identification23")]
public partial record FinancialInstitutionIdentification23
{
    /// <inheritdoc cref="IFinancialInstitutionIdentification23.BICFI"/>
    [DisplayName("BICFI")]
    [IsoXmlTag("BICFI")]
    public IsoBICFIDec2014Identifier? BICFI { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification23.ClearingSystemMemberIdentification"/>
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification23.LEI"/>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification23.Name"/>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification23.Other"/>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericFinancialIdentification1? Other { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification23.PostalAddress"/>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress27? PostalAddress { get; init; }
}
