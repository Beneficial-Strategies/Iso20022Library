// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceLocation7"/>
[IsoId("_-BcUm24-EeiU9cctagi5ow")]
[DisplayName("Remittance Location")]
public partial record RemittanceLocation7
{
    /// <inheritdoc cref="IRemittanceLocation7.RemittanceIdentification"/>
    [IsoId("_-LRmA24-EeiU9cctagi5ow")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <inheritdoc cref="IRemittanceLocation7.RemittanceLocationDetails"/>
    [IsoId("_-LRmBW4-EeiU9cctagi5ow")]
    [DisplayName("Remittance Location Details")]
    [IsoXmlTag("RmtLctnDtls")]
    public ValueList<RemittanceLocationData1> RemittanceLocationDetails { get; init; } = [];
}
