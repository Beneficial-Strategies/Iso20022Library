// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateRelatedInformation9"/>
[IsoId("_tfkL4VkyEeGeoaLUQk__nA_2034090441")]
[DisplayName("Mandate Related Information")]
public partial record MandateRelatedInformation9
{
    /// <inheritdoc cref="IMandateRelatedInformation9.MandateIdentification"/>
    [IsoId("_tfkL4lkyEeGeoaLUQk__nA_2067250210")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation9.DateOfSignature"/>
    [IsoId("_tfkL41kyEeGeoaLUQk__nA_692325198")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation9.AmendmentIndicator"/>
    [IsoId("_tft84FkyEeGeoaLUQk__nA_1146412467")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation9.AmendmentInformationDetails"/>
    [IsoId("_tft84VkyEeGeoaLUQk__nA_1910478165")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails9? AmendmentInformationDetails { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation9.ElectronicSignature"/>
    [IsoId("_tft84lkyEeGeoaLUQk__nA_-1487209636")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation9.FirstCollectionDate"/>
    [IsoId("_tft841kyEeGeoaLUQk__nA_-2128519285")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation9.FinalCollectionDate"/>
    [IsoId("_tf3G0FkyEeGeoaLUQk__nA_-1367754132")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation9.Frequency"/>
    [IsoId("_tf3G0VkyEeGeoaLUQk__nA_928355083")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency6Code? Frequency { get; init; }
}
