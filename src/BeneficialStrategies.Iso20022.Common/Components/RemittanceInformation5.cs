// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation5"/>
[IsoId("_QF2HWNp-Ed-ak6NoX_4Aeg_414888716")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation5
{
    /// <inheritdoc cref="IRemittanceInformation5.Unstructured"/>
    [IsoId("_QF2HWdp-Ed-ak6NoX_4Aeg_414888747")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <inheritdoc cref="IRemittanceInformation5.Structured"/>
    [IsoId("_QF_4UNp-Ed-ak6NoX_4Aeg_414888840")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation7> Structured { get; init; } = [];
}
