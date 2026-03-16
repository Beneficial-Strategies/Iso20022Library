// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Creditor Enrolment6.
/// </summary>
[IsoId("_zhDXAzEyEe6g-ffJsqGiSA")]
[DisplayName("Creditor Enrolment6")]
public partial record CreditorEnrolment6
{
    #nullable enable

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required RTPPartyIdentification2 Creditor { get; init; } 

    /// <summary>
    /// Creditor Logo.
    /// </summary>
    [DisplayName("Creditor Logo")]
    [IsoXmlTag("CdtrLogo")]
    public IsoMax10KBinary? CreditorLogo { get; init; } 

    /// <summary>
    /// Creditor Trading Name.
    /// </summary>
    [DisplayName("Creditor Trading Name")]
    [IsoXmlTag("CdtrTradgNm")]
    public IsoMax140Text? CreditorTradingName { get; init; } 

    /// <summary>
    /// Enrolment.
    /// </summary>
    [DisplayName("Enrolment")]
    [IsoXmlTag("Enrlmnt")]
    public CreditorServiceEnrolment1? Enrolment { get; init; } 

    /// <summary>
    /// Merchant Category Code.
    /// </summary>
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public IsoMerchantCategoryCodeIdentifier? MerchantCategoryCode { get; init; } 

    /// <summary>
    /// Ultimate Creditor.
    /// </summary>
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public RTPPartyIdentification2? UltimateCreditor { get; init; } 

    
    #nullable disable
    
}
