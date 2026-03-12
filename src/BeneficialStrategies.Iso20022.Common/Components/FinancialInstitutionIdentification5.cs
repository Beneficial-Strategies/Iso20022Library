// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
/// </summary>
[IsoId("_WHL-vtp-Ed-ak6NoX_4Aeg_-1284722592")]
[DisplayName("Financial Institution Identification")]
public partial record FinancialInstitutionIdentification5
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_WHL-v9p-Ed-ak6NoX_4Aeg_-1284722163")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public required RestrictedIdentification1 ProprietaryIdentification { get; init; } 
    
    
    #nullable disable
    
}
