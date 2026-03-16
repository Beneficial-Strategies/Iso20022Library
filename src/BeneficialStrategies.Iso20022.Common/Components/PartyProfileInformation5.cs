// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to support the Know Your Customer (KYC) processes.
/// </summary>
[IsoId("_HEMRASGREeWO8_xZKx-MFg")]
[DisplayName("Party Profile Information")]
public record PartyProfileInformation5
{
    /// <summary>
    /// Indicates whether the certificate type has been obtained and verified.
    /// </summary>
    [IsoId("_HgwRMSGREeWO8_xZKx-MFg")]
    [DisplayName("Certification Indicator")]
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationIndicator { get; init; }

    /// <summary>
    /// Identification of the person who validated the document.
    /// </summary>
    [IsoId("_HgwRMyGREeWO8_xZKx-MFg")]
    [DisplayName("Validating Party")]
    [IsoXmlTag("VldtngPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ValidatingParty { get; init; }

    /// <summary>
    /// Identification of the person who checked the document.
    /// </summary>
    [IsoId("_HgwRNSGREeWO8_xZKx-MFg")]
    [DisplayName("Checking Party")]
    [IsoXmlTag("ChckngPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? CheckingParty { get; init; }

    /// <summary>
    /// Identification of the person who is responsible for the document.
    /// </summary>
    [IsoId("_HgwRNyGREeWO8_xZKx-MFg")]
    [DisplayName("Responsible Party")]
    [IsoXmlTag("RspnsblPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ResponsibleParty { get; init; }

    /// <summary>
    /// Type of certificate.
    /// </summary>
    [IsoId("_HgwROSGREeWO8_xZKx-MFg")]
    [DisplayName("Certificate Type")]
    [IsoXmlTag("CertTp")]
    public CertificationType1Choice_? CertificateType { get; init; }

    /// <summary>
    /// Date at which the certification check has been performed.
    /// </summary>
    [IsoId("_HgwROyGREeWO8_xZKx-MFg")]
    [DisplayName("Checking Date")]
    [IsoXmlTag("ChckngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CheckingDate { get; init; }

    /// <summary>
    /// Specifies how frequently the check is performed.
    /// </summary>
    [IsoId("_HgwRPSGREeWO8_xZKx-MFg")]
    [DisplayName("Checking Frequency")]
    [IsoXmlTag("ChckngFrqcy")]
    public EventFrequency1Code? CheckingFrequency { get; init; }

    /// <summary>
    /// Specifies the date at which the next certification check will be performed.
    /// </summary>
    [IsoId("_HgwRPyGREeWO8_xZKx-MFg")]
    [DisplayName("Next Revision Date")]
    [IsoXmlTag("NxtRvsnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextRevisionDate { get; init; }

    /// <summary>
    /// Limits between which a person&apos;s salary is estimated.
    /// </summary>
    [IsoId("_HgwRQSGREeWO8_xZKx-MFg")]
    [DisplayName("Salary Range")]
    [IsoXmlTag("SlryRg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SalaryRange { get; init; }

    /// <summary>
    /// Indicates the main source of revenue.
    /// </summary>
    [IsoId("_HgwRQyGREeWO8_xZKx-MFg")]
    [DisplayName("Source Of Wealth")]
    [IsoXmlTag("SrcOfWlth")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SourceOfWealth { get; init; }

    /// <summary>
    /// Specifies an assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("_HgwRRSGREeWO8_xZKx-MFg")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; }

    /// <summary>
    /// Specifies the customer’s money laundering risk.
    /// </summary>
    [IsoId("_Hg5bISGREeWO8_xZKx-MFg")]
    [DisplayName("Risk Level")]
    [IsoXmlTag("RskLvl")]
    public RiskLevel2Choice_? RiskLevel { get; init; }

    /// <summary>
    /// Specifies the type of due diligence checks carried out on the investor or account owner. For definitions of ordinary, simple and enhanced know your customer checks, local market regulations should be consulted.
    /// </summary>
    [IsoId("_Hg5bIyGREeWO8_xZKx-MFg")]
    [DisplayName("Know Your Customer Check Type")]
    [IsoXmlTag("KnowYourCstmrChckTp")]
    public KYCCheckType1Choice_? KnowYourCustomerCheckType { get; init; }

    /// <summary>
    /// Specifies whether a customer has been checked in a Know Your Customer (KYC) database.
    /// </summary>
    [IsoId("_Hg5bJSGREeWO8_xZKx-MFg")]
    [DisplayName("Know Your Customer Database Check")]
    [IsoXmlTag("KnowYourCstmrDBChck")]
    public DataBaseCheck1? KnowYourCustomerDatabaseCheck { get; init; }
}
