// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_TD1icdp-Ed-ak6NoX_4Aeg_621431627")]
public interface IMandateRelatedInformation7 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_TD1ictp-Ed-ak6NoX_4Aeg_-385375482")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    IsoMax35Text? MandateIdentification { get; }

    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_TD1ic9p-Ed-ak6NoX_4Aeg_2065722825")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    IsoISODate? DateOfSignature { get; }

    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [IsoId("_TD1idNp-Ed-ak6NoX_4Aeg_-1786255979")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    IsoTrueFalseIndicator? AmendmentIndicator { get; }

    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    [IsoId("_TD1iddp-Ed-ak6NoX_4Aeg_994649792")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    IAmendmentInformationDetails7? AmendmentInformationDetails { get; }

    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [IsoId("_TD1idtp-Ed-ak6NoX_4Aeg_1270618389")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    IsoMax1025Text? ElectronicSignature { get; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_TD1id9p-Ed-ak6NoX_4Aeg_1856565415")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    IsoISODate? FirstCollectionDate { get; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_TD1ieNp-Ed-ak6NoX_4Aeg_-2113284374")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    IsoISODate? FinalCollectionDate { get; }

    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [IsoId("_TD_TcNp-Ed-ak6NoX_4Aeg_466783695")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    Frequency1Code? Frequency { get; }
}
