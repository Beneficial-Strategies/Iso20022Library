// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_wJuO0TEyEe6g-ffJsqGiSA")]
public interface IMandateRelatedInformation16 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    Max35Text? MandateIdentification { get; }

    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    ISODate? DateOfSignature { get; }

    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    TrueFalseIndicator? AmendmentIndicator { get; }

    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    IAmendmentInformationDetails15? AmendmentInformationDetails { get; }

    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    Max1025Text? ElectronicSignature { get; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    ISODate? FirstCollectionDate { get; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    ISODate? FinalCollectionDate { get; }

    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    IFrequency36Choice? Frequency { get; }

    /// <summary>
    /// Reason for the direct debit mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateSetupReason1Choice? Reason { get; }

    /// <summary>
    /// Specifies the number of days the direct debit instruction must be tracked.
    /// </summary>
    [DisplayName("Tracking Days")]
    [IsoXmlTag("TrckgDays")]
    Exact2NumericText? TrackingDays { get; }
}
