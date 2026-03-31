// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate Related Information16.
/// </summary>
[IsoId("_wJuO0TEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate Related Information16")]
public record MandateRelatedInformation16
{
    /// <summary>
    /// Amendment Indicator.
    /// </summary>
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Amendment Information Details.
    /// </summary>
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails15? AmendmentInformationDetails { get; init; }

    /// <summary>
    /// Date Of Signature.
    /// </summary>
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    public IsoISODate? DateOfSignature { get; init; }

    /// <summary>
    /// Electronic Signature.
    /// </summary>
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <summary>
    /// Final Collection Date.
    /// </summary>
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <summary>
    /// First Collection Date.
    /// </summary>
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <summary>
    /// Frequency.
    /// </summary>
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; }

    /// <summary>
    /// Mandate Identification.
    /// </summary>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Tracking Days.
    /// </summary>
    [DisplayName("Tracking Days")]
    [IsoXmlTag("TrckgDays")]
    public IsoExact2NumericText? TrackingDays { get; init; }
}
