// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IFinancialInstitutionIdentification7"/>
[IsoId("_TFLmRNp-Ed-ak6NoX_4Aeg_-434069114")]
[DisplayName("Financial Institution Identification")]
public partial record FinancialInstitutionIdentification7
{
    /// <inheritdoc cref="IFinancialInstitutionIdentification7.BIC"/>
    [IsoId("_TFLmRdp-Ed-ak6NoX_4Aeg_-434069112")]
    [DisplayName("BIC")]
    [IsoXmlTag("BIC")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public IsoBICIdentifier? BIC { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification7.ClearingSystemMemberIdentification"/>
    [IsoId("_TFLmRtp-Ed-ak6NoX_4Aeg_494072236")]
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification7.Name"/>
    [IsoId("_TFLmR9p-Ed-ak6NoX_4Aeg_-434068774")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification7.PostalAddress"/>
    [IsoId("_TFLmSNp-Ed-ak6NoX_4Aeg_-434068379")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionIdentification7.Other"/>
    [IsoId("_TFUwMNp-Ed-ak6NoX_4Aeg_-434068709")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericFinancialIdentification1? Other { get; init; }
}
