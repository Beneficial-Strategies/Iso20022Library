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
[IsoId("_Exl5dDkPEem897H7zB2RJg")]
[DisplayName("Penalty Identification1")]
public record PenaltyIdentification1
{
    /// <summary>
    /// Identification as assigned by the market infrastructure to the penalty and that is common for both the failing and the non-failing participant.
    /// </summary>
    [IsoId("_Exl5dTkPEem897H7zB2RJg")]
    [DisplayName("Market Infrastructure Identification")]
    [IsoXmlTag("MktInfrstrctrId")]
    public required IsoMax35Text MarketInfrastructureIdentification { get; init; }

    /// <summary>
    /// Identification as assigned by the market infrastructure to the penalty, individual to the relevant account owner.
    /// </summary>
    [IsoId("_Exl5ejkPEem897H7zB2RJg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Identification as assigned to the penalty by the market infrastructure following a reallocation.
    /// </summary>
    [IsoId("_jTz-0TmmEemla4muNfgRrg")]
    [DisplayName("Reallocation Identification")]
    [IsoXmlTag("RallcnId")]
    public PenaltyIdentification2? ReallocationIdentification { get; init; }
}
