// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indication of the type of assets subject of the transaction.
/// </summary>
[IsoId("_dXdmwbQwEemI67HK7aviyg")]
[DisplayName("Security Commodity")]
public record SecurityCommodity8
{
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    [IsoId("_dbVaAbQwEemI67HK7aviyg")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public Security15? Security { get; init; }

    /// <summary>
    /// Data specific to commodities being subject to the transaction.
    /// </summary>
    [IsoId("_dbVaA7QwEemI67HK7aviyg")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public Commodity20? Commodity { get; init; }
}
