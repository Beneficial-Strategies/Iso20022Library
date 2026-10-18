// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation1"/>
[IsoId("_QFsWV9p-Ed-ak6NoX_4Aeg_-92384845")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation1
{
    /// <inheritdoc cref="IRemittanceInformation1.Unstructured"/>
    [IsoId("_QFsWWNp-Ed-ak6NoX_4Aeg_-92384592")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <inheritdoc cref="IRemittanceInformation1.Structured"/>
    [IsoId("_QF2HUNp-Ed-ak6NoX_4Aeg_-92384550")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation6> Structured { get; init; } = [];
}
