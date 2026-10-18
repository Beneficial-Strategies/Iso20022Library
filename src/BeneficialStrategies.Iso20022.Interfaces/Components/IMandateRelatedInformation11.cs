// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_seR6NWk2Eeanu6HLe77Rkg")]
public interface IMandateRelatedInformation11 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_sm5qt2k2Eeanu6HLe77Rkg")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    IsoMax35Text? MandateIdentification { get; }

    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_sm5quWk2Eeanu6HLe77Rkg")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    IsoISODate? DateOfSignature { get; }

    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [IsoId("_sm5qu2k2Eeanu6HLe77Rkg")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    IsoTrueFalseIndicator? AmendmentIndicator { get; }

    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    [IsoId("_sm5qvWk2Eeanu6HLe77Rkg")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    IAmendmentInformationDetails11? AmendmentInformationDetails { get; }

    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [IsoId("_sm5qv2k2Eeanu6HLe77Rkg")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    IsoMax1025Text? ElectronicSignature { get; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_sm5qwWk2Eeanu6HLe77Rkg")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    IsoISODate? FirstCollectionDate { get; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_sm5qw2k2Eeanu6HLe77Rkg")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    IsoISODate? FinalCollectionDate { get; }

    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [IsoId("_sm5qxWk2Eeanu6HLe77Rkg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    IFrequency36Choice? Frequency { get; }

    /// <summary>
    /// Reason for the direct debit mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_sm5qx2k2Eeanu6HLe77Rkg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateSetupReason1Choice? Reason { get; }

    /// <summary>
    /// Specifies the number of days the direct debit instruction must be tracked.
    /// </summary>
    [IsoId("_Uf2kYWn1EearR-CA7eRZXQ")]
    [DisplayName("Tracking Days")]
    [IsoXmlTag("TrckgDays")]
    IsoExact2NumericText? TrackingDays { get; }
}
