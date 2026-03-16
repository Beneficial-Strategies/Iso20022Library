// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tangible items of value to a business.
/// </summary>
[IsoId("_MQz4EZJOEeuAlLVx8pyt3w")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument97
{
    /// <summary>
    /// Financial instrument which represents a title of ownership in a company, ie, the shareholder is entitled to a part of the company&apos;s profit - usually by payment of a dividend - and to voting rights, if any. Each company issues generally different classes of shares, eg, ordinary or common shares, which have no guaranteed amount of dividend but carry voting rights, or preferred shares, which receive dividends before ordinary shares but have no voting right.
    /// </summary>
    [IsoId("_MS6w4ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Equity")]
    [IsoXmlTag("Eqty")]
    public Equity3? Equity { get; init; }

    /// <summary>
    /// Financial instrument that gives the holder the right to purchase shares or bonds at a given price within a specified time.
    /// </summary>
    [IsoId("_MS6w45JOEeuAlLVx8pyt3w")]
    [DisplayName("Warrant")]
    [IsoXmlTag("Warrt")]
    public Warrant4? Warrant { get; init; }

    /// <summary>
    /// Financial instruments evidencing moneys owed by the issuer to the holder on terms as specified.
    /// </summary>
    [IsoId("_MS6w5ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Debt")]
    [IsoXmlTag("Debt")]
    public Debt5? Debt { get; init; }

    /// <summary>
    /// Choice between type of derivatives.
    /// </summary>
    [IsoId("_MS6w55JOEeuAlLVx8pyt3w")]
    [DisplayName("Derivative")]
    [IsoXmlTag("Deriv")]
    public Derivative4? Derivative { get; init; }
}
