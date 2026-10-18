// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateRelatedInformation15"/>
[IsoId("_a4TwFdcZEeqRFcf2R4bPBw")]
[DisplayName("Mandate Related Information")]
public partial record MandateRelatedInformation15
{
    /// <inheritdoc cref="IMandateRelatedInformation15.MandateIdentification"/>
    [IsoId("_a5rCBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation15.DateOfSignature"/>
    [IsoId("_a5rCB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation15.AmendmentIndicator"/>
    [IsoId("_a5rCCdcZEeqRFcf2R4bPBw")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation15.AmendmentInformationDetails"/>
    [IsoId("_a5rCC9cZEeqRFcf2R4bPBw")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails14? AmendmentInformationDetails { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation15.ElectronicSignature"/>
    [IsoId("_a5rCDdcZEeqRFcf2R4bPBw")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation15.FirstCollectionDate"/>
    [IsoId("_a5rpEdcZEeqRFcf2R4bPBw")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation15.FinalCollectionDate"/>
    [IsoId("_a5rpE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation15.Frequency"/>
    [IsoId("_a5rpFdcZEeqRFcf2R4bPBw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation15.Reason"/>
    [IsoId("_a5rpF9cZEeqRFcf2R4bPBw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation15.TrackingDays"/>
    [IsoId("_a5rpGdcZEeqRFcf2R4bPBw")]
    [DisplayName("Tracking Days")]
    [IsoXmlTag("TrckgDays")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? TrackingDays { get; init; }
}
