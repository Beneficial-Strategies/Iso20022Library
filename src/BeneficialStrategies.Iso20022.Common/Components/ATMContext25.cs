// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Context25.
/// </summary>
[IsoId("_NaoWsaByEe-mUP79iiSLcw")]
[DisplayName("ATM Context25")]
public record ATMContext25
{
    /// <summary>
    /// Service.
    /// </summary>
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public required ATMService27 Service { get; init; }

    /// <summary>
    /// Session Reference.
    /// </summary>
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    public IsoMax35Text? SessionReference { get; init; }
}
