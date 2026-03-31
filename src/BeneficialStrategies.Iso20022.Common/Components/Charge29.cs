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
[IsoId("_YSR7ESSBEeWWV-wpfEW00A")]
[DisplayName("Charge")]
public record Charge29
{
    /// <summary>
    /// Type of charge.
    /// </summary>
    [IsoId("_Yu_sIySBEeWWV-wpfEW00A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType4Choice_ Type { get; init; }

    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_Yu_sJSSBEeWWV-wpfEW00A")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Method used to calculate the charge.
    /// </summary>
    [IsoId("_Yu_sJySBEeWWV-wpfEW00A")]
    [DisplayName("Charge Basis")]
    [IsoXmlTag("ChrgBsis")]
    public ChargeBasisType1Choice_? ChargeBasis { get; init; }

    /// <summary>
    /// Specifies the party that will bear the charges associated with a transfer.
    /// </summary>
    [IsoId("_Yu_sKSSBEeWWV-wpfEW00A")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearer1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    [IsoId("_Yu_sKySBEeWWV-wpfEW00A")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification70Choice_? RecipientIdentification { get; init; }
}
