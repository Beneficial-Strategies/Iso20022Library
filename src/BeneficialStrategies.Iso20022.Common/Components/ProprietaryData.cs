// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary Data.
/// </summary>
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
[IsoId("_RreBWdp-Ed-ak6NoX_4Aeg_-1704893658")]
[DisplayName("Proprietary Data")]
public partial record ProprietaryData
{
    #nullable enable

    /// <summary>
    /// Any.
    /// </summary>
    [DisplayName("Any")]
    [IsoXmlTag("Any")]
    public SkipProcessing? Any { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IsoMax35Text Type { get; init; } 

    
    #nullable disable
    
}
