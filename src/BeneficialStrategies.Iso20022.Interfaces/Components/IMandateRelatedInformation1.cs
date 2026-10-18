// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_TESOYNp-Ed-ak6NoX_4Aeg_-72185926")]
public interface IMandateRelatedInformation1 : IIsoComponent
{
    /// <summary>
    /// Reference of the direct debit mandate that has been signed between by the debtor and the creditor.
    /// </summary>
    [IsoId("_TESOYdp-Ed-ak6NoX_4Aeg_-72184917")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    IsoMax35Text? MandateIdentification { get; }

    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_TESOYtp-Ed-ak6NoX_4Aeg_-72184359")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    IsoISODate? DateOfSignature { get; }

    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [IsoId("_TESOY9p-Ed-ak6NoX_4Aeg_-71262715")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    IsoTrueFalseIndicator? AmendmentIndicator { get; }

    /// <summary>
    /// List of direct debit mandate elements that have been modified.
    /// </summary>
    [IsoId("_TESOZNp-Ed-ak6NoX_4Aeg_-62948389")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    IAmendmentInformationDetails1? AmendmentInformationDetails { get; }

    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [IsoId("_TESOZdp-Ed-ak6NoX_4Aeg_-62951025")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    IsoMax1025Text? ElectronicSignature { get; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_TESOZtp-Ed-ak6NoX_4Aeg_-62950250")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    IsoISODate? FirstCollectionDate { get; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_TESOZ9p-Ed-ak6NoX_4Aeg_-62949704")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    IsoISODate? FinalCollectionDate { get; }

    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [IsoId("_TESOaNp-Ed-ak6NoX_4Aeg_-62949241")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    Frequency1Code? Frequency { get; }
}
