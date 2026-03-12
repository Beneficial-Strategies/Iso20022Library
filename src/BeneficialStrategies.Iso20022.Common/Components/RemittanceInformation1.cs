// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system.
/// </summary>
[IsoId("_QFsWV9p-Ed-ak6NoX_4Aeg_-92384845")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation1
{
    #nullable enable
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system in an unstructured form.
    /// </summary>
    [IsoId("_QFsWWNp-Ed-ak6NoX_4Aeg_-92384592")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Unstructured { get; init; } 
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system in a structured form.
    /// </summary>
    [IsoId("_QF2HUNp-Ed-ak6NoX_4Aeg_-92384550")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public StructuredRemittanceInformation6? Structured { get; init; } 
    
    
    #nullable disable
    
}
