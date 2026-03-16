// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_TElJV9p-Ed-ak6NoX_4Aeg_1685621299")]
[DisplayName("Mandate Related Information")]
public record MandateRelatedInformation6
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_TElJWNp-Ed-ak6NoX_4Aeg_1685621330")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_TEu6UNp-Ed-ak6NoX_4Aeg_1685621361")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [IsoId("_TEu6Udp-Ed-ak6NoX_4Aeg_1685621639")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    [IsoId("_TEu6Utp-Ed-ak6NoX_4Aeg_1685622103")]
    [DisplayName("Amendment Information Details")]
    [IsoXmlTag("AmdmntInfDtls")]
    public AmendmentInformationDetails6? AmendmentInformationDetails { get; init; }

    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [IsoId("_TEu6U9p-Ed-ak6NoX_4Aeg_1685621700")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ElectronicSignature { get; init; }

    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_TEu6VNp-Ed-ak6NoX_4Aeg_1685621731")]
    [DisplayName("First Collection Date")]
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstCollectionDate { get; init; }

    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_TEu6Vdp-Ed-ak6NoX_4Aeg_1685622040")]
    [DisplayName("Final Collection Date")]
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalCollectionDate { get; init; }

    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [IsoId("_TEu6Vtp-Ed-ak6NoX_4Aeg_1685622041")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency1Code? Frequency { get; init; }
}
