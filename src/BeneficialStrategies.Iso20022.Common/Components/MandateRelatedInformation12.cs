// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateRelatedInformation12"/>
[IsoId("_nkzXUbTREeeyuKckOGlwuA")]
[DisplayName("Mandate Related Information")]
public partial record MandateRelatedInformation12
{
    /// <inheritdoc cref="IMandateRelatedInformation12.MandateIdentification"/>
    [IsoId("_nuAWp7TREeeyuKckOGlwuA")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation12.DateOfSignature"/>
    [IsoId("_nuAWqbTREeeyuKckOGlwuA")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation12.AmendmentIndicator"/>
    [IsoId("_nuAWq7TREeeyuKckOGlwuA")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation12.AmendmentInformationDetails"/>
    [IsoId("_nuAWrbTREeeyuKckOGlwuA")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails12? AmendmentInformationDetails { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation12.ElectronicSignature"/>
    [IsoId("_nuAWr7TREeeyuKckOGlwuA")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation12.FirstCollectionDate"/>
    [IsoId("_nuAWsbTREeeyuKckOGlwuA")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation12.FinalCollectionDate"/>
    [IsoId("_nuAWs7TREeeyuKckOGlwuA")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation12.Frequency"/>
    [IsoId("_nuAWtbTREeeyuKckOGlwuA")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation12.Reason"/>
    [IsoId("_nuAWt7TREeeyuKckOGlwuA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation12.TrackingDays"/>
    [IsoId("_nuAWubTREeeyuKckOGlwuA")]
    [DisplayName("Tracking Days")]
    [IsoXmlTag("TrckgDays")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? TrackingDays { get; init; }
}
