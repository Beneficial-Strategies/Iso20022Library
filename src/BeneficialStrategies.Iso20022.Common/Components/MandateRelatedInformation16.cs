// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_wJuO0TEyEe6g-ffJsqGiSA")]
[Description(@"Provides further details related to a direct debit mandate signed between the creditor and the debtor.")]
[DisplayName("Mandate Related Information16")]
public record MandateRelatedInformation16
{
    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails15? AmendmentInformationDetails { get; init; }

    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    public IsoISODate? DateOfSignature { get; init; }

    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <summary>
    /// Reason for the direct debit mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Specifies the number of days the direct debit instruction must be tracked.
    /// </summary>
    [DisplayName("Tracking Days")]
    [IsoXmlTag("TrckgDays")]
    public IsoExact2NumericText? TrackingDays { get; init; }
}
