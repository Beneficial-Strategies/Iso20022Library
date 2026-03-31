// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the components of a settlement rate source for a non delvierable trade.
/// </summary>
[IsoId("_CldIUJULEeak6e8_Fc5fQg")]
[DisplayName("Settlement Rate Source")]
public record SettlementRateSource1
{
    /// <summary>
    /// Specifies the rate source for the non deliverable trade.
    /// </summary>
    [IsoId("_6mn-oJUMEeak6e8_Fc5fQg")]
    [DisplayName("Rate Source")]
    [IsoXmlTag("RateSrc")]
    [IsoSimpleType(IsoSimpleType.RateSourceText)]
    public required IsoRateSourceText RateSource { get; init; }

    /// <summary>
    /// Specifies the time &quot;HHMM&quot; associated with the rate source.
    /// </summary>
    [IsoId("_UdWPkJUOEeak6e8_Fc5fQg")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? Time { get; init; }

    /// <summary>
    /// Specifies the country code for the quoted rate source.
    /// </summary>
    [IsoId("_ISDz4JUNEeak6e8_Fc5fQg")]
    [DisplayName("Country Code")]
    [IsoXmlTag("CtryCd")]
    public CountryCode? CountryCode { get; init; }

    /// <summary>
    /// The location expressed as a 2 character code.
    /// </summary>
    [IsoId("_1wrG4JUNEeak6e8_Fc5fQg")]
    [DisplayName("Location Code")]
    [IsoXmlTag("LctnCd")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public IsoExact2AlphaNumericText? LocationCode { get; init; }
}
