// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IFinancialInstitutionIdentification8"/>
[IsoId("_TE4ETNp-Ed-ak6NoX_4Aeg_1904039525")]
[DisplayName("Financial Institution Identification")]
public partial record FinancialInstitutionIdentification8
{
    /// <inheritdoc cref="IFinancialInstitutionIdentification8.BICFI"/>
    [IsoId("_TE4ETdp-Ed-ak6NoX_4Aeg_-1044219164")]
    [DisplayName("BICFI")]
    [IsoXmlTag("BICFI")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    public IsoBICFIIdentifier? BICFI { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification8.ClearingSystemMemberIdentification"/>
    [IsoId("_TE4ETtp-Ed-ak6NoX_4Aeg_42141218")]
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification8.Name"/>
    [IsoId("_TE4ET9p-Ed-ak6NoX_4Aeg_1330079303")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification8.PostalAddress"/>
    [IsoId("_TE4EUNp-Ed-ak6NoX_4Aeg_-1638666214")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification8.Other"/>
    [IsoId("_TFB1QNp-Ed-ak6NoX_4Aeg_-280855258")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericFinancialIdentification1? Other { get; init; }
}
