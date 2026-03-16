// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Claim Non Receipt3.
/// </summary>
[IsoId("_2xf0FTEyEe6g-ffJsqGiSA")]
[DisplayName("Claim Non Receipt3")]
public partial record ClaimNonReceipt3
{
    #nullable enable

    /// <summary>
    /// Date Processed.
    /// </summary>
    [DisplayName("Date Processed")]
    [IsoXmlTag("DtPrcd")]
    public required IsoISODate DateProcessed { get; init; } 

    /// <summary>
    /// Original Next Agent.
    /// </summary>
    [DisplayName("Original Next Agent")]
    [IsoXmlTag("OrgnlNxtAgt")]
    public BranchAndFinancialInstitutionIdentification8? OriginalNextAgent { get; init; } 

    
    #nullable disable
    
}
