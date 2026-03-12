// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the status of the transaction by means of a code.
/// </summary>
[IsoId("_RbFb-Np-Ed-ak6NoX_4Aeg_1598523783")]
[DisplayName("Transaction Status")]
public partial record TransactionStatus4
{
    #nullable enable
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_RbOl4Np-Ed-ak6NoX_4Aeg_1598523785")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BaselineStatus3Code Status { get; init; } 
    
    
    #nullable disable
    
}
