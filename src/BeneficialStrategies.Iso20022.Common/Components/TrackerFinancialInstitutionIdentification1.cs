// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identification of a financial institution.
/// </summary>
[IsoId("_XaFUtfWfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Financial Institution Identification")]
public partial record TrackerFinancialInstitutionIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_XaFUt_WfEemtd4wHZYvFUQ")]
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    public required FinancialInstitutionIdentification20 FinancialInstitutionIdentification { get; init; } 
    
    
    #nullable disable
    
}
