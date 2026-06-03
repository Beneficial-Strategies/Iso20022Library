// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the financial instrument subject to penalties.
/// </summary>
[IsoId("_5-_1MDkVEem897H7zB2RJg")]
[DisplayName("Penalty Financial Instrument Identification1")]
public record PenaltyFinancialInstrumentIdentification1
{
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_LKQnUDkWEem897H7zB2RJg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification19 Identification { get; init; }

    /// <summary>
    /// Indicates if the financial instrument is subject to penalties on this business day.
    /// </summary>
    [IsoId("_WK8GgDkWEem897H7zB2RJg")]
    [DisplayName("Subject To Penalties")]
    [IsoXmlTag("SbjtToPnlties")]
    public IsoTrueFalseIndicator? SubjectToPenalties { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification.
    /// </summary>
    [IsoId("_lOFVkDkWEem897H7zB2RJg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType1Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Specifies whether the security is liquid or illiquid.
    /// </summary>
    [IsoId("__zV88DkWEem897H7zB2RJg")]
    [DisplayName("Liquidity")]
    [IsoXmlTag("Lqdty")]
    public IsoTrueFalseIndicator? Liquidity { get; init; }

    /// <summary>
    /// Further details on the price of the financial instrument.
    /// </summary>
    [IsoId("_Z9NBwDkXEem897H7zB2RJg")]
    [DisplayName("Price Data")]
    [IsoXmlTag("PricData")]
    public PriceInformation25? PriceData { get; init; }

    /// <summary>
    /// Further details on the foreign exchange rate.
    /// </summary>
    [IsoId("_fHHFYDkYEem897H7zB2RJg")]
    [DisplayName("Foreign Exchange Data")]
    [IsoXmlTag("FXData")]
    public ValueList<ForeignExchangeRate3> ForeignExchangeData { get; init; } = [];

    /// <summary>
    /// Penalty rate data provided if the securities is subject to penalties and the calculation method code is securities or both.
    /// </summary>
    [IsoId("_m1tTUDkZEem897H7zB2RJg")]
    [DisplayName("Securities Penalty Rate Data")]
    [IsoXmlTag("SctiesPnltyRateData")]
    public PenaltyRate1? SecuritiesPenaltyRateData { get; init; }
}
