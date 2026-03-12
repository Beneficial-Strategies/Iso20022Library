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
[IsoId("_RKFyk9p-Ed-ak6NoX_4Aeg_-489445133")]
[DisplayName("Transaction Status")]
public partial record TransactionStatus3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_RKFylNp-Ed-ak6NoX_4Aeg_-460815143")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BaselineStatus2Code Status { get; init; } 
    
    
    #nullable disable
    
}
