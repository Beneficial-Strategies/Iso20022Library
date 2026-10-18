// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_tfkL4VkyEeGeoaLUQk__nA_2034090441")]
public interface IMandateRelatedInformation9 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_tfkL4lkyEeGeoaLUQk__nA_2067250210")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    IsoMax35Text? MandateIdentification { get; }

    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_tfkL41kyEeGeoaLUQk__nA_692325198")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    IsoISODate? DateOfSignature { get; }

    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [IsoId("_tft84FkyEeGeoaLUQk__nA_1146412467")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    IsoTrueFalseIndicator? AmendmentIndicator { get; }

    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    [IsoId("_tft84VkyEeGeoaLUQk__nA_1910478165")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    IAmendmentInformationDetails9? AmendmentInformationDetails { get; }

    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [IsoId("_tft84lkyEeGeoaLUQk__nA_-1487209636")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    IsoMax1025Text? ElectronicSignature { get; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_tft841kyEeGeoaLUQk__nA_-2128519285")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    IsoISODate? FirstCollectionDate { get; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_tf3G0FkyEeGeoaLUQk__nA_-1367754132")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    IsoISODate? FinalCollectionDate { get; }

    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [IsoId("_tf3G0VkyEeGeoaLUQk__nA_928355083")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    Frequency6Code? Frequency { get; }
}
