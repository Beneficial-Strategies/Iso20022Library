// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IBranchData2"/>
[IsoId("_TFLmQNp-Ed-ak6NoX_4Aeg_-1953949955")]
[DisplayName("Branch Data")]
public partial record BranchData2
{
    /// <inheritdoc cref="IBranchData2.Identification"/>
    [IsoId("_TFLmQdp-Ed-ak6NoX_4Aeg_-1953949945")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <inheritdoc cref="IBranchData2.Name"/>
    [IsoId("_TFLmQtp-Ed-ak6NoX_4Aeg_-1953949925")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IBranchData2.PostalAddress"/>
    [IsoId("_TFLmQ9p-Ed-ak6NoX_4Aeg_-1953949848")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }
}
