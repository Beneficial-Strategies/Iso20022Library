// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the highest volume and value of settlement fails with a ranking by financial instrument.
/// </summary>
[IsoId("_BnlYg40bEemUAO64Q252gQ")]
[DisplayName("Settlement Fails Securities Range")]
public record SettlementFailsSecuritiesRange1
{
    /// <summary>
    /// Securities with the highest volume of settlement fails.
    /// </summary>
    [IsoId("_BnlYhY0bEemUAO64Q252gQ")]
    [DisplayName("Highest In Volume")]
    [IsoXmlTag("HghstInVol")]
    public ValueList<SettlementFailsSecurities1> HighestInVolume { get; init; } = [];

    // ID for the above is _BnlYhY0bEemUAO64Q252gQ

    /// <summary>
    /// Securities with the highest value of settlement fails.
    /// </summary>
    [IsoId("_BnlYhI0bEemUAO64Q252gQ")]
    [DisplayName("Highest In Value")]
    [IsoXmlTag("HghstInVal")]
    public ValueList<SettlementFailsSecurities1> HighestInValue { get; init; } = [];
    // ID for the above is _BnlYhI0bEemUAO64Q252gQ
}
