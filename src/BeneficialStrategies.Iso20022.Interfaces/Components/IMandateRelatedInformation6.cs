// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_TElJV9p-Ed-ak6NoX_4Aeg_1685621299")]
public interface IMandateRelatedInformation6 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_TElJWNp-Ed-ak6NoX_4Aeg_1685621330")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    Max35Text? MandateIdentification { get; }

    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_TEu6UNp-Ed-ak6NoX_4Aeg_1685621361")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    ISODate? DateOfSignature { get; }

    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [IsoId("_TEu6Udp-Ed-ak6NoX_4Aeg_1685621639")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    TrueFalseIndicator? AmendmentIndicator { get; }

    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    [IsoId("_TEu6Utp-Ed-ak6NoX_4Aeg_1685622103")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    IAmendmentInformationDetails6? AmendmentInformationDetails { get; }

    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [IsoId("_TEu6U9p-Ed-ak6NoX_4Aeg_1685621700")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    Max1025Text? ElectronicSignature { get; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_TEu6VNp-Ed-ak6NoX_4Aeg_1685621731")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    ISODate? FirstCollectionDate { get; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_TEu6Vdp-Ed-ak6NoX_4Aeg_1685622040")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    ISODate? FinalCollectionDate { get; }

    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [IsoId("_TEu6Vtp-Ed-ak6NoX_4Aeg_1685622041")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    Frequency1Code? Frequency { get; }
}
