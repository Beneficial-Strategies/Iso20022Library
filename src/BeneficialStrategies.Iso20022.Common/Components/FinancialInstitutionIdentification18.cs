// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IFinancialInstitutionIdentification18"/>
[IsoId("_8xXCNW49EeiU9cctagi5ow")]
[DisplayName("Financial Institution Identification")]
public partial record FinancialInstitutionIdentification18
{
    /// <inheritdoc cref="IFinancialInstitutionIdentification18.BICFI"/>
    [IsoId("_87o_kW49EeiU9cctagi5ow")]
    [DisplayName("BICFI")]
    [IsoXmlTag("BICFI")]
    [IsoSimpleType(IsoSimpleType.BICFIDec2014Identifier)]
    public IsoBICFIDec2014Identifier? BICFI { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification18.ClearingSystemMemberIdentification"/>
    [IsoId("_87o_k249EeiU9cctagi5ow")]
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification18.LEI"/>
    [IsoId("_b1ZcUXRwEeiH1ZOt2UD8vQ")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification18.Name"/>
    [IsoId("_87o_lW49EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification18.PostalAddress"/>
    [IsoId("_87o_l249EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress24? PostalAddress { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification18.Other"/>
    [IsoId("_87o_mW49EeiU9cctagi5ow")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericFinancialIdentification1? Other { get; init; }
}
