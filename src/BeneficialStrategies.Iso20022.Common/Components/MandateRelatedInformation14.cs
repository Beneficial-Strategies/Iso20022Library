// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateRelatedInformation14"/>
[IsoId("_ATlBXW49EeiU9cctagi5ow")]
[DisplayName("Mandate Related Information")]
public partial record MandateRelatedInformation14
{
    /// <inheritdoc cref="IMandateRelatedInformation14.MandateIdentification"/>
    [IsoId("_Acqrx249EeiU9cctagi5ow")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation14.DateOfSignature"/>
    [IsoId("_AcqryW49EeiU9cctagi5ow")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation14.AmendmentIndicator"/>
    [IsoId("_Acqry249EeiU9cctagi5ow")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation14.AmendmentInformationDetails"/>
    [IsoId("_AcqrzW49EeiU9cctagi5ow")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails13? AmendmentInformationDetails { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation14.ElectronicSignature"/>
    [IsoId("_Acqrz249EeiU9cctagi5ow")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation14.FirstCollectionDate"/>
    [IsoId("_Acqr0W49EeiU9cctagi5ow")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation14.FinalCollectionDate"/>
    [IsoId("_Acqr0249EeiU9cctagi5ow")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation14.Frequency"/>
    [IsoId("_Acqr1W49EeiU9cctagi5ow")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation14.Reason"/>
    [IsoId("_Acqr1249EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation14.TrackingDays"/>
    [IsoId("_Acqr2W49EeiU9cctagi5ow")]
    [DisplayName("Tracking Days")]
    [IsoXmlTag("TrckgDays")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? TrackingDays { get; init; }
}
