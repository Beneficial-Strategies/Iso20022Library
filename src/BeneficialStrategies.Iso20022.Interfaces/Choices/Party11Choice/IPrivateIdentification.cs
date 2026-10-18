// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Party11Choice;

/// <summary>
/// Unique and unambiguous identification of a person, for example a passport.
/// </summary>
[IsoId("_PWnCxNp-Ed-ak6NoX_4Aeg_-6562753")]
public interface IPrivateIdentification : IParty11Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    [IsoId("_QENIl9p-Ed-ak6NoX_4Aeg_1634415117")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    IDateAndPlaceOfBirth? DateAndPlaceOfBirth { get; }

    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_QENImNp-Ed-ak6NoX_4Aeg_1634415136")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IGenericPersonIdentification1? Other { get; }
}
