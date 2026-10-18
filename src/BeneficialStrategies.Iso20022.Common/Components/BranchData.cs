// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IBranchData"/>
[IsoId("_TFUwMdp-Ed-ak6NoX_4Aeg_-275983969")]
[DisplayName("Branch Data")]
public partial record BranchData
{
    /// <inheritdoc cref="IBranchData.Identification"/>
    [IsoId("_TFUwMtp-Ed-ak6NoX_4Aeg_-242735819")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <inheritdoc cref="IBranchData.Name"/>
    [IsoId("_TFUwM9p-Ed-ak6NoX_4Aeg_14002178")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <inheritdoc cref="IBranchData.PostalAddress"/>
    [IsoId("_TFUwNNp-Ed-ak6NoX_4Aeg_-1619654726")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress1? PostalAddress { get; init; }
}
