// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateRelatedInformation6"/>
[IsoId("_TElJV9p-Ed-ak6NoX_4Aeg_1685621299")]
[DisplayName("Mandate Related Information")]
public partial record MandateRelatedInformation6
{
    /// <inheritdoc cref="IMandateRelatedInformation6.MandateIdentification"/>
    [IsoId("_TElJWNp-Ed-ak6NoX_4Aeg_1685621330")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation6.DateOfSignature"/>
    [IsoId("_TEu6UNp-Ed-ak6NoX_4Aeg_1685621361")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation6.AmendmentIndicator"/>
    [IsoId("_TEu6Udp-Ed-ak6NoX_4Aeg_1685621639")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation6.AmendmentInformationDetails"/>
    [IsoId("_TEu6Utp-Ed-ak6NoX_4Aeg_1685622103")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails6? AmendmentInformationDetails { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation6.ElectronicSignature"/>
    [IsoId("_TEu6U9p-Ed-ak6NoX_4Aeg_1685621700")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation6.FirstCollectionDate"/>
    [IsoId("_TEu6VNp-Ed-ak6NoX_4Aeg_1685621731")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation6.FinalCollectionDate"/>
    [IsoId("_TEu6Vdp-Ed-ak6NoX_4Aeg_1685622040")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation6.Frequency"/>
    [IsoId("_TEu6Vtp-Ed-ak6NoX_4Aeg_1685622041")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency1Code? Frequency { get; init; }
}
