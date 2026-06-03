// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identification of a penalty.
/// </summary>
[IsoId("_ZPfaOjmmEemla4muNfgRrg")]
[DisplayName("Penalty Identification2")]
public record PenaltyIdentification2
{
    /// <summary>
    /// Identification as assigned by the market infrastructure to the penalty and that is common for both the failing and the non-failing participant.
    /// </summary>
    [IsoId("_ZPfaOzmmEemla4muNfgRrg")]
    [DisplayName("Market Infrastructure Identification")]
    [IsoXmlTag("MktInfrstrctrId")]
    public required IsoMax35Text MarketInfrastructureIdentification { get; init; }

    /// <summary>
    /// Identification as assigned by the market infrastructure to the penalty, individual to the relevant account owner.
    /// </summary>
    [IsoId("_ZPfaPDmmEemla4muNfgRrg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }
}
