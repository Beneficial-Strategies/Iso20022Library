// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance Information23.
/// </summary>
[IsoId("_9FAoQTEsEe6GxLzpkVnWYg")]
[DisplayName("Remittance Information23")]
public partial record RemittanceInformation23
{
    #nullable enable

    /// <summary>
    /// Original Payment Information.
    /// </summary>
    [DisplayName("Original Payment Information")]
    [IsoXmlTag("OrgnlPmtInf")]
    public required OriginalPaymentInformation10 OriginalPaymentInformation { get; init; } 

    /// <summary>
    /// Remittance Identification.
    /// </summary>
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    public IsoMax35Text? RemittanceIdentification { get; init; } 

    /// <summary>
    /// Structured.
    /// </summary>
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation18> Structured { get; init; } = [];

    /// <summary>
    /// Unstructured.
    /// </summary>
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public ValueList<IsoMax140Text> Unstructured { get; init; } = [];

    
    #nullable disable
    
}
