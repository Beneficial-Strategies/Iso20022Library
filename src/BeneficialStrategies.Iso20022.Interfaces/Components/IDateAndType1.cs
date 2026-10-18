// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date And Type1.
/// </summary>
[IsoId("_wbqsoDHxEe6BxvG014AZzQ")]
public interface IDateAndType1 : IIsoComponent
{
    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IDateType2Choice Type { get; }

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    ISODate Date { get; }
}
