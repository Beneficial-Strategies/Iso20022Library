// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a high frequency trading profile.
/// </summary>
[IsoId("_O87qwCDUEeWCLu74WLgP4w")]
[DisplayName("High Frequency Trading Profile")]
public record HighFrequencyTradingProfile1
{
    /// <summary>
    /// Date on which the investor starts high frequency trading.
    /// </summary>
    [IsoId("_dfZOoCDUEeWCLu74WLgP4w")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Frequency of settlement.
    /// </summary>
    [IsoId("_gilS0CDUEeWCLu74WLgP4w")]
    [DisplayName("Settlement Frequency")]
    [IsoXmlTag("SttlmFrqcy")]
    public SettlementFrequency1Choice_? SettlementFrequency { get; init; }

    /// <summary>
    /// Specifies whether consolidation is done generally or at the level of segregated account.
    /// </summary>
    [IsoId("_KtmHECDVEeWCLu74WLgP4w")]
    [DisplayName("Consolidation Type")]
    [IsoXmlTag("CnsldtnTp")]
    public ConsolidationType1Choice_? ConsolidationType { get; init; }
}
