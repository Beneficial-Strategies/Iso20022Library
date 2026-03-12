// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity of the financial instrument subscribed.
/// </summary>
[IsoId("_SF2QOtp-Ed-ak6NoX_4Aeg_-1972881267")]
[DisplayName("Financial Instrument Quantity")]
public partial record FinancialInstrumentQuantity3
{
    #nullable enable
    
    /// <summary>
    /// Quantity of investment fund units redeemed.
    /// </summary>
    [IsoId("_SF2QO9p-Ed-ak6NoX_4Aeg_-1972881242")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    
    /// <summary>
    /// Amount of money to be invested.
    /// </summary>
    [IsoId("_SF2QPNp-Ed-ak6NoX_4Aeg_-1972881182")]
    [DisplayName("Ordered Amount")]
    [IsoXmlTag("OrdrdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OrderedAmount { get; init; } 
    
    /// <summary>
    /// Amount of money as a result of the redemption after deduction of charges, commissions and taxes.
    /// </summary>
    [IsoId("_SF2QPdp-Ed-ak6NoX_4Aeg_-1972881130")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    
    /// <summary>
    /// Amount of money as a result of the redemption before deduction of charges, commissions and taxes.
    /// </summary>
    [IsoId("_SF2QPtp-Ed-ak6NoX_4Aeg_-1972881051")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    
    /// <summary>
    /// Amount of money as a result of the redemption.
    /// </summary>
    [IsoId("_SGABMNp-Ed-ak6NoX_4Aeg_-1972880732")]
    [DisplayName("Executed Amount")]
    [IsoXmlTag("ExctdAmt")]
    public ActiveCurrencyAndAmount? ExecutedAmount { get; init; } 
    
    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_SGABMdp-Ed-ak6NoX_4Aeg_-490894286")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_SGABMtp-Ed-ak6NoX_4Aeg_-1972880991")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    
    
    #nullable disable
    
}
