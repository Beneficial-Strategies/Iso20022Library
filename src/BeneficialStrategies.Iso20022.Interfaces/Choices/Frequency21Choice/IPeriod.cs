// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Frequency21Choice;

/// <summary>
/// Frequency expressed as a proprietary code.
/// </summary>
[IsoId("_6GkgCR7yEeSxevWRRWxNAg")]
public interface IPeriod : IFrequency21Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Period for which the number of instructions are to be created and processed.
    /// </summary>
    [IsoId("_1bz5sB71EeSxevWRRWxNAg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    Frequency6Code Type { get; }

    /// <summary>
    /// Number of instructions to be created and processed during the specified period.
    /// </summary>
    [IsoId("_OPlVUB72EeSxevWRRWxNAg")]
    [DisplayName("Count Per Period")]
    [IsoXmlTag("CntPerPrd")]
    IsoDecimalNumber CountPerPeriod { get; }
}
