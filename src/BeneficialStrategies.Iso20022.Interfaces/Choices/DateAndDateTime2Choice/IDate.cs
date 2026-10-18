// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice;

/// <summary>
/// Specified date.
/// </summary>
[IsoId("_fPH6gZlhEeeE1Ya-LgRsuQ")]
public interface IDate : IDateAndDateTime2Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.
    /// </summary>
    [IsoXmlTag("Dt")]
    ISODate Value { get; }
}
