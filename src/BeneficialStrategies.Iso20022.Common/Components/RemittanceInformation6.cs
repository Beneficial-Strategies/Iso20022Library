// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation6"/>
[IsoId("_QFQRedp-Ed-ak6NoX_4Aeg_902671001")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation6
{
    /// <inheritdoc cref="IRemittanceInformation6.Unstructured"/>
    [IsoId("_QFZbYNp-Ed-ak6NoX_4Aeg_599614486")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <inheritdoc cref="IRemittanceInformation6.Structured"/>
    [IsoId("_QFZbYdp-Ed-ak6NoX_4Aeg_-1102572482")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation8> Structured { get; init; } = [];
}
