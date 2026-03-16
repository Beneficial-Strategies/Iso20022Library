// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Option Multiple Barrier Levels1.
/// </summary>
[IsoId("_ttTVodyaEe6BHYBNhkieQQ")]
[DisplayName("Option Multiple Barrier Levels1")]
public partial record OptionMultipleBarrierLevels1
{
    #nullable enable

    /// <summary>
    /// Lower Level.
    /// </summary>
    [DisplayName("Lower Level")]
    [IsoXmlTag("LwrLvl")]
    public required SecuritiesTransactionPrice23Choice_ LowerLevel { get; init; } 

    /// <summary>
    /// Upper Level.
    /// </summary>
    [DisplayName("Upper Level")]
    [IsoXmlTag("UpperLvl")]
    public required SecuritiesTransactionPrice23Choice_ UpperLevel { get; init; } 

    
    #nullable disable
    
}
