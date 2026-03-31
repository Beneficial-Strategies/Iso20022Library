// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to support the Know Your Customer processes.
/// </summary>
[IsoId("_TUhp1dp-Ed-ak6NoX_4Aeg_-300374569")]
[DisplayName("Party Profile Information")]
public record PartyProfileInformation1
{
    /// <summary>
    /// Indicates whether the certificate type has been obtained and verified.
    /// </summary>
    [IsoId("_TUhp1tp-Ed-ak6NoX_4Aeg_903696093")]
    [DisplayName("Certification Indicator")]
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CertificationIndicator { get; init; }

    /// <summary>
    /// Identification of the person who validated the document.
    /// </summary>
    [IsoId("_TUhp19p-Ed-ak6NoX_4Aeg_497583653")]
    [DisplayName("Validating Party")]
    [IsoXmlTag("VldtngPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ValidatingParty { get; init; }

    /// <summary>
    /// Identification of the person who checked the document.
    /// </summary>
    [IsoId("_TUhp2Np-Ed-ak6NoX_4Aeg_-461332733")]
    [DisplayName("Checking Party")]
    [IsoXmlTag("ChckngPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? CheckingParty { get; init; }

    /// <summary>
    /// Identification of the person who is responsible for the document.
    /// </summary>
    [IsoId("_TUhp2dp-Ed-ak6NoX_4Aeg_368913503")]
    [DisplayName("Responsible Party")]
    [IsoXmlTag("RspnsblPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ResponsibleParty { get; init; }

    /// <summary>
    /// Identifies the type of certificate.
    /// </summary>
    [IsoId("_TUhp2tp-Ed-ak6NoX_4Aeg_301560457")]
    [DisplayName("Certificate Type")]
    [IsoXmlTag("CertTp")]
    public required CertificateType1Code CertificateType { get; init; }

    /// <summary>
    /// Identifies the type of certificate.
    /// </summary>
    [IsoId("_TUra0Np-Ed-ak6NoX_4Aeg_536135706")]
    [DisplayName("Extended Certificate Type")]
    [IsoXmlTag("XtndedCertTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedCertificateType { get; init; }

    /// <summary>
    /// Date at which the certification check has been performed.
    /// </summary>
    [IsoId("_TUra0dp-Ed-ak6NoX_4Aeg_-459485436")]
    [DisplayName("Checking Date")]
    [IsoXmlTag("ChckngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CheckingDate { get; init; }

    /// <summary>
    /// Specifies how frequently the check is performed.
    /// </summary>
    [IsoId("_TUra0tp-Ed-ak6NoX_4Aeg_-458560305")]
    [DisplayName("Checking Frequency")]
    [IsoXmlTag("ChckngFrqcy")]
    public EventFrequency1Code? CheckingFrequency { get; init; }

    /// <summary>
    /// Specifies the date at which the next certification check will be performed.
    /// </summary>
    [IsoId("_TUra09p-Ed-ak6NoX_4Aeg_-456714285")]
    [DisplayName("Next Revision Date")]
    [IsoXmlTag("NxtRvsnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextRevisionDate { get; init; }

    /// <summary>
    /// Limits between which a person&apos;s salary is estimated.
    /// </summary>
    [IsoId("_TUra1Np-Ed-ak6NoX_4Aeg_-444706221")]
    [DisplayName("Salary Range")]
    [IsoXmlTag("SlryRg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SalaryRange { get; init; }

    /// <summary>
    /// Indicates the main source of revenue.
    /// </summary>
    [IsoId("_TUra1dp-Ed-ak6NoX_4Aeg_-206438748")]
    [DisplayName("Source Of Wealth")]
    [IsoXmlTag("SrcOfWlth")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SourceOfWealth { get; init; }
}
