// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateRelatedInformation16"/>
[IsoId("_wJuO0TEyEe6g-ffJsqGiSA")]
[Description(@"Provides further details related to a direct debit mandate signed between the creditor and the debtor.")]
[DisplayName("Mandate Related Information16")]
public partial record MandateRelatedInformation16
{
    /// <inheritdoc cref="IMandateRelatedInformation16.AmendmentIndicator"/>
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation16.AmendmentInformationDetails"/>
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails15? AmendmentInformationDetails { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation16.DateOfSignature"/>
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation16.ElectronicSignature"/>
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation16.FinalCollectionDate"/>
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation16.FirstCollectionDate"/>
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation16.Frequency"/>
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation16.MandateIdentification"/>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation16.Reason"/>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation16.TrackingDays"/>
    [DisplayName("Tracking Days")]
    [IsoXmlTag("TrckgDays")]
    public IsoExact2NumericText? TrackingDays { get; init; }
}
