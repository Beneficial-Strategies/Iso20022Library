// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Party34Choice;

/// <summary>
/// Unique and unambiguous identification of a person, for example a passport.
/// </summary>
[IsoId("_j9Shha9UEeeJJK1oRb-jTw")]
public interface IPrivateIdentification : IParty34Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    [IsoId("_jU7hA69UEeeJJK1oRb-jTw")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    IDateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; }

    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_jU7hBa9UEeeJJK1oRb-jTw")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IGenericPersonIdentification1? Other { get; }
}
