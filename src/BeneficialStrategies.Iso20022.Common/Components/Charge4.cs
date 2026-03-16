// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_VIdFmtp-Ed-ak6NoX_4Aeg_-815734755")]
[DisplayName("Charge")]
public record Charge4
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_VIdFm9p-Ed-ak6NoX_4Aeg_-655968594")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeTypeFormat2Choice_ Type { get; init; }

    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_VIdFnNp-Ed-ak6NoX_4Aeg_-656888601")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_VIdFndp-Ed-ak6NoX_4Aeg_1273475922")]
    [DisplayName("Charge Basis")]
    [IsoXmlTag("ChrgBsis")]
    public TaxationBasis2Code? ChargeBasis { get; init; }

    /// <summary>
    /// Specifies the party that will bear the charges associated with a transfer.
    /// </summary>
    [IsoId("_VIm2kNp-Ed-ak6NoX_4Aeg_1273476277")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearer1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    [IsoId("_VIm2kdp-Ed-ak6NoX_4Aeg_1273475982")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification1Choice_? RecipientIdentification { get; init; }
}
