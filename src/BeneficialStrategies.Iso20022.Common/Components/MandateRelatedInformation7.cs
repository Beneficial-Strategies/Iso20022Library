// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateRelatedInformation7"/>
[IsoId("_TD1icdp-Ed-ak6NoX_4Aeg_621431627")]
[DisplayName("Mandate Related Information")]
public partial record MandateRelatedInformation7
{
    /// <inheritdoc cref="IMandateRelatedInformation7.MandateIdentification"/>
    [IsoId("_TD1ictp-Ed-ak6NoX_4Aeg_-385375482")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation7.DateOfSignature"/>
    [IsoId("_TD1ic9p-Ed-ak6NoX_4Aeg_2065722825")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation7.AmendmentIndicator"/>
    [IsoId("_TD1idNp-Ed-ak6NoX_4Aeg_-1786255979")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation7.AmendmentInformationDetails"/>
    [IsoId("_TD1iddp-Ed-ak6NoX_4Aeg_994649792")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails7? AmendmentInformationDetails { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation7.ElectronicSignature"/>
    [IsoId("_TD1idtp-Ed-ak6NoX_4Aeg_1270618389")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation7.FirstCollectionDate"/>
    [IsoId("_TD1id9p-Ed-ak6NoX_4Aeg_1856565415")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation7.FinalCollectionDate"/>
    [IsoId("_TD1ieNp-Ed-ak6NoX_4Aeg_-2113284374")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation7.Frequency"/>
    [IsoId("_TD_TcNp-Ed-ak6NoX_4Aeg_466783695")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency1Code? Frequency { get; init; }
}
