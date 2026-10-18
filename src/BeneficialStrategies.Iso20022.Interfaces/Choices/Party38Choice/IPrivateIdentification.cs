// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Party38Choice;

/// <summary>
/// Unique and unambiguous identification of a person, for example a passport.
/// </summary>
[IsoId("_6VWvRW48EeiU9cctagi5ow")]
public interface IPrivateIdentification : IParty38Choice, IIsoChoiceVariant
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
    IEnumerable<IGenericPersonIdentification1> Other { get; }
}
