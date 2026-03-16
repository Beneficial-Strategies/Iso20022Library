// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements characterising a financial instrument.
/// </summary>
[IsoId("_qZQIYMhiEeadgvwNGwK05w")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes88
{
    /// <summary>
    /// Specifies fixed contract term, or the maximum contract term cleared.
    /// </summary>
    [IsoId("_1U8Z4MhiEeadgvwNGwK05w")]
    [DisplayName("Contract Term")]
    [IsoXmlTag("CtrctTerm")]
    public InterestRateContractTerm1? ContractTerm { get; init; }

    /// <summary>
    /// Indicates whether certain terms of the derivative are defined purely according to exchange specifications or can be user defined.
    /// </summary>
    [IsoId("_4ICzoMhiEeadgvwNGwK05w")]
    [DisplayName("Standardisation")]
    [IsoXmlTag("Stdstn")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<Standardisation1Code> Standardisation { get; init; } = [];

    /// <summary>
    /// Schedule for leg payments.
    /// </summary>
    [IsoId("_aY0VMMhjEeadgvwNGwK05w")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public required Frequency11Code PaymentFrequency { get; init; }
}
