// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Person Identification18.
/// </summary>
[IsoId("_-9oltTFLEe651u5xu3f5iw")]
public interface IPersonIdentification18 : IIsoComponent
{
    /// <summary>
    /// Date And Place Of Birth.
    /// </summary>
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    IDateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; }

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IEnumerable<IGenericPersonIdentification2> Other { get; }
}
