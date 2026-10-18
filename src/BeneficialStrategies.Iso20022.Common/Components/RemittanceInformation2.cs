// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation2"/>
[IsoId("_QFsWVdp-Ed-ak6NoX_4Aeg_-1040515995")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation2
{
    /// <inheritdoc cref="IRemittanceInformation2.Unstructured"/>
    [IsoId("_QFsWVtp-Ed-ak6NoX_4Aeg_-1039592586")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];
}
