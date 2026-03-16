// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement of the securities in a securities transaction, that is, the instruction to deliver or receive securities, involving the payment of an amount of money or not.
/// </summary>
[IsoId("_dqcAheLxEeWOD7aAy2fAcA")]
[DisplayName("Settlement Information")]
public record SettlementInformation17
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [IsoId("_dzhEAeLxEeWOD7aAy2fAcA")]
    [DisplayName("Securities Quantity Type")]
    [IsoXmlTag("SctiesQtyTp")]
    public SettlementUnitType3Choice_? SecuritiesQuantityType { get; init; }

    /// <summary>
    /// Specifies when the contract (i.e. MBS/TBA) will settle.
    /// </summary>
    [IsoId("_dzhEA-LxEeWOD7aAy2fAcA")]
    [DisplayName("Contract Settlement Month")]
    [IsoXmlTag("CtrctSttlmMnth")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? ContractSettlementMonth { get; init; }

    /// <summary>
    /// Indicates the minimum quantity (unit or nominal) of a security.
    /// </summary>
    [IsoId("_dzhEC-LxEeWOD7aAy2fAcA")]
    [DisplayName("Minimum Denomination")]
    [IsoXmlTag("MinDnmtn")]
    public FinancialInstrumentQuantity1Choice_? MinimumDenomination { get; init; }

    /// <summary>
    /// Minimum multiple quantity (unit or nominal) of securities.
    /// </summary>
    [IsoId("_dzhEDeLxEeWOD7aAy2fAcA")]
    [DisplayName("Minimum Multiple Quantity")]
    [IsoXmlTag("MinMltplQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumMultipleQuantity { get; init; }

    /// <summary>
    /// Minimum quantity of securities that can be purchased without incurring a larger fee. For example, if the round lot size is 100 and the trade is for 125 shares, then 100 will be processed without a fee and the remaining 25 will incur a service fee for being an odd lot size.
    /// </summary>
    [IsoId("_dzhED-LxEeWOD7aAy2fAcA")]
    [DisplayName("Deviating Settlement Unit")]
    [IsoXmlTag("DevtgSttlmUnit")]
    public ValueList<FinancialInstrumentQuantity1Choice_> DeviatingSettlementUnit { get; init; } =
        [];
}
