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
[IsoId("_Utx7xtp-Ed-ak6NoX_4Aeg_-799578291")]
[DisplayName("Transaction Status")]
public partial record TransactionStatus1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_Utx7x9p-Ed-ak6NoX_4Aeg_-770025996")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BaselineStatus1Code Status { get; init; } 
    
    
    #nullable disable
    
}
