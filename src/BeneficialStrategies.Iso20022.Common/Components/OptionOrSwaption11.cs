// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Option Or Swaption11.
/// </summary>
[IsoId("_BpQX8I-SEe6Ojt1b3tfu9Q")]
[DisplayName("Option Or Swaption11")]
public record OptionOrSwaption11
{
    /// <summary>
    /// Barrier Levels.
    /// </summary>
    [DisplayName("Barrier Levels")]
    [IsoXmlTag("BrrrLvls")]
    public OptionBarrierLevel1Choice_? BarrierLevels { get; init; }

    /// <summary>
    /// Call Amount.
    /// </summary>
    [DisplayName("Call Amount")]
    [IsoXmlTag("CallAmt")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? CallAmount { get; init; }

    /// <summary>
    /// Embedded Type.
    /// </summary>
    [DisplayName("Embedded Type")]
    [IsoXmlTag("MbddTp")]
    public EmbeddedType1Code? EmbeddedType { get; init; }

    /// <summary>
    /// Exercise Date.
    /// </summary>
    [DisplayName("Exercise Date")]
    [IsoXmlTag("ExrcDt")]
    public ExerciseDate1Choice_? ExerciseDate { get; init; }

    /// <summary>
    /// Exercise Style.
    /// </summary>
    [DisplayName("Exercise Style")]
    [IsoXmlTag("ExrcStyle")]
    public ValueList<OptionStyle6Code> ExerciseStyle { get; init; } = [];

    /// <summary>
    /// Maturity Date Of Underlying.
    /// </summary>
    [DisplayName("Maturity Date Of Underlying")]
    [IsoXmlTag("MtrtyDtOfUndrlyg")]
    public IsoISODate? MaturityDateOfUnderlying { get; init; }

    /// <summary>
    /// Premium Amount.
    /// </summary>
    [DisplayName("Premium Amount")]
    [IsoXmlTag("PrmAmt")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PremiumAmount { get; init; }

    /// <summary>
    /// Premium Payment Date.
    /// </summary>
    [DisplayName("Premium Payment Date")]
    [IsoXmlTag("PrmPmtDt")]
    public IsoISODate? PremiumPaymentDate { get; init; }

    /// <summary>
    /// Put Amount.
    /// </summary>
    [DisplayName("Put Amount")]
    [IsoXmlTag("PutAmt")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PutAmount { get; init; }

    /// <summary>
    /// Strike Price.
    /// </summary>
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public SecuritiesTransactionPrice17Choice_? StrikePrice { get; init; }

    /// <summary>
    /// Strike Price Schedule.
    /// </summary>
    [DisplayName("Strike Price Schedule")]
    [IsoXmlTag("StrkPricSchdl")]
    public ValueList<Schedule4> StrikePriceSchedule { get; init; } = [];

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public OptionType2Code? Type { get; init; }
}
