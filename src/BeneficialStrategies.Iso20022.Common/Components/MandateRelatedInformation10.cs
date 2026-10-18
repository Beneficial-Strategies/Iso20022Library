// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateRelatedInformation10"/>
[IsoId("_m-35kR72EeSxevWRRWxNAg")]
[DisplayName("Mandate Related Information")]
public partial record MandateRelatedInformation10
{
    /// <inheritdoc cref="IMandateRelatedInformation10.MandateIdentification"/>
    [IsoId("_nP8bdx72EeSxevWRRWxNAg")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation10.DateOfSignature"/>
    [IsoId("_nP8beR72EeSxevWRRWxNAg")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation10.AmendmentIndicator"/>
    [IsoId("_nP8bex72EeSxevWRRWxNAg")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation10.AmendmentInformationDetails"/>
    [IsoId("_nP8bfR72EeSxevWRRWxNAg")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails10? AmendmentInformationDetails { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation10.ElectronicSignature"/>
    [IsoId("_nP8bfx72EeSxevWRRWxNAg")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation10.FirstCollectionDate"/>
    [IsoId("_nP8bgR72EeSxevWRRWxNAg")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation10.FinalCollectionDate"/>
    [IsoId("_nP8bgx72EeSxevWRRWxNAg")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation10.Frequency"/>
    [IsoId("_nP8bhR72EeSxevWRRWxNAg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency21Choice_? Frequency { get; init; }

    /// <inheritdoc cref="IMandateRelatedInformation10.Reason"/>
    [IsoId("_j8KhEB73EeSxevWRRWxNAg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }
}
