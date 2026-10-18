// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation7"/>
[IsoId("_tdoSMFkyEeGeoaLUQk__nA_-54731938")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation7
{
    /// <inheritdoc cref="IRemittanceInformation7.Unstructured"/>
    [IsoId("_tdoSMVkyEeGeoaLUQk__nA_1927221985")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <inheritdoc cref="IRemittanceInformation7.Structured"/>
    [IsoId("_tdxcIFkyEeGeoaLUQk__nA_1580762287")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation9> Structured { get; init; } = [];
}
