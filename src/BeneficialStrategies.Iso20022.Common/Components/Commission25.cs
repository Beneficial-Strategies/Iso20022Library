// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_6apuIwauEe2phaVG0lYKTw")]
[DisplayName("Commission")]
public record Commission25
{
    /// <summary>
    /// Specification of the commission type.
    /// </summary>
    [IsoId("_6sPMmQauEe2phaVG0lYKTw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CommissionType6Choice_ Type { get; init; }

    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_6sPMoQauEe2phaVG0lYKTw")]
    [DisplayName("Commission")]
    [IsoXmlTag("Comssn")]
    public required AmountOrRate2Choice_ Commission { get; init; }

    /// <summary>
    /// Information related to an identification, eg, party identification or account identification.
    /// </summary>
    [IsoId("_6sPMrwauEe2phaVG0lYKTw")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification267? RecipientIdentification { get; init; }

    /// <summary>
    /// Date at which an operation is triggered to calculate, for instance, a commission, fee, asset values, etc.
    /// </summary>
    [IsoId("_6sPMtwauEe2phaVG0lYKTw")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CalculationDate { get; init; }

    /// <summary>
    /// Total value of the commissions for a specific trade.
    /// </summary>
    [IsoId("_6sPMuQauEe2phaVG0lYKTw")]
    [DisplayName("Total Commission")]
    [IsoXmlTag("TtlComssn")]
    public AmountAndDirection29? TotalCommission { get; init; }

    /// <summary>
    /// Amount that results of the calculation of VAT on net fees, according to the transaction current tariffs.
    /// </summary>
    [IsoId("_6sPMuwauEe2phaVG0lYKTw")]
    [DisplayName("Total VAT Amount")]
    [IsoXmlTag("TtlVATAmt")]
    public ActiveCurrencyAndAmount? TotalVATAmount { get; init; }

    /// <summary>
    /// Specifies the VAT rate.
    /// </summary>
    [IsoId("_6sPMvQauEe2phaVG0lYKTw")]
    [DisplayName("VAT Rate")]
    [IsoXmlTag("VATRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? VATRate { get; init; }
}
