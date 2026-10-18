// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateRelatedInformation1"/>
[IsoId("_TESOYNp-Ed-ak6NoX_4Aeg_-72185926")]
[DisplayName("Mandate Related Information")]
public partial record MandateRelatedInformation1
{
    /// <inheritdoc cref="IMandateRelatedInformation1.MandateIdentification"/>
    [IsoId("_TESOYdp-Ed-ak6NoX_4Aeg_-72184917")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation1.DateOfSignature"/>
    [IsoId("_TESOYtp-Ed-ak6NoX_4Aeg_-72184359")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation1.AmendmentIndicator"/>
    [IsoId("_TESOY9p-Ed-ak6NoX_4Aeg_-71262715")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation1.AmendmentInformationDetails"/>
    [IsoId("_TESOZNp-Ed-ak6NoX_4Aeg_-62948389")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails1? AmendmentInformationDetails { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation1.ElectronicSignature"/>
    [IsoId("_TESOZdp-Ed-ak6NoX_4Aeg_-62951025")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation1.FirstCollectionDate"/>
    [IsoId("_TESOZtp-Ed-ak6NoX_4Aeg_-62950250")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation1.FinalCollectionDate"/>
    [IsoId("_TESOZ9p-Ed-ak6NoX_4Aeg_-62949704")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation1.Frequency"/>
    [IsoId("_TESOaNp-Ed-ak6NoX_4Aeg_-62949241")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency1Code? Frequency { get; init; }
}
