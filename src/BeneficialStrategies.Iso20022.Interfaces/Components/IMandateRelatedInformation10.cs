// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_m-35kR72EeSxevWRRWxNAg")]
public interface IMandateRelatedInformation10 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_nP8bdx72EeSxevWRRWxNAg")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    Max35Text? MandateIdentification { get; }

    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_nP8beR72EeSxevWRRWxNAg")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    ISODate? DateOfSignature { get; }

    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [IsoId("_nP8bex72EeSxevWRRWxNAg")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    TrueFalseIndicator? AmendmentIndicator { get; }

    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    [IsoId("_nP8bfR72EeSxevWRRWxNAg")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    IAmendmentInformationDetails10? AmendmentInformationDetails { get; }

    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [IsoId("_nP8bfx72EeSxevWRRWxNAg")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    Max1025Text? ElectronicSignature { get; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_nP8bgR72EeSxevWRRWxNAg")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    ISODate? FirstCollectionDate { get; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_nP8bgx72EeSxevWRRWxNAg")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    ISODate? FinalCollectionDate { get; }

    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [IsoId("_nP8bhR72EeSxevWRRWxNAg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    IFrequency21Choice? Frequency { get; }

    /// <summary>
    /// Reason for the direct debit mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_j8KhEB73EeSxevWRRWxNAg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateSetupReason1Choice? Reason { get; }
}
