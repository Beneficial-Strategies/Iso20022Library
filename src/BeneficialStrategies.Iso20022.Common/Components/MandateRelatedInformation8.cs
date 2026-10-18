// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateRelatedInformation8"/>
[IsoId("_tfHf8FkyEeGeoaLUQk__nA_-2093972838")]
[DisplayName("Mandate Related Information")]
public partial record MandateRelatedInformation8
{
    /// <inheritdoc cref="IMandateRelatedInformation8.MandateIdentification"/>
    [IsoId("_tfRQ8FkyEeGeoaLUQk__nA_1591260059")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation8.DateOfSignature"/>
    [IsoId("_tfRQ8VkyEeGeoaLUQk__nA_-185859615")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation8.AmendmentIndicator"/>
    [IsoId("_tfRQ8lkyEeGeoaLUQk__nA_-196958392")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation8.AmendmentInformationDetails"/>
    [IsoId("_tfRQ81kyEeGeoaLUQk__nA_1807193085")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails8? AmendmentInformationDetails { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation8.ElectronicSignature"/>
    [IsoId("_tfRQ9FkyEeGeoaLUQk__nA_1481271487")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation8.FirstCollectionDate"/>
    [IsoId("_tfaa4FkyEeGeoaLUQk__nA_-1891532499")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation8.FinalCollectionDate"/>
    [IsoId("_tfaa4VkyEeGeoaLUQk__nA_1648684923")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation8.Frequency"/>
    [IsoId("_tfaa4lkyEeGeoaLUQk__nA_1013653077")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency6Code? Frequency { get; init; }
}
