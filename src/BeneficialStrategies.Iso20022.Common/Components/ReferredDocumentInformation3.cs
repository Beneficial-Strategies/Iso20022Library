// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IReferredDocumentInformation3"/>
[IsoId("_ThMM2tp-Ed-ak6NoX_4Aeg_-882800583")]
[DisplayName("Referred Document Information")]
public partial record ReferredDocumentInformation3
{
    /// <inheritdoc cref="IReferredDocumentInformation3.Type"/>
    [IsoId("_ThV90Np-Ed-ak6NoX_4Aeg_-882800242")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ReferredDocumentType2? Type { get; init; }

    /// <inheritdoc cref="IReferredDocumentInformation3.Number"/>
    [IsoId("_ThV90dp-Ed-ak6NoX_4Aeg_-882800304")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; }

    /// <inheritdoc cref="IReferredDocumentInformation3.RelatedDate"/>
    [IsoId("_ThV90tp-Ed-ak6NoX_4Aeg_1205279992")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; }
}
