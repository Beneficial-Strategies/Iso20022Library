// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a financial institution required by business or regulation.
/// </summary>
[IsoId("_foaBQXSCEfC68Y4jZPNEug")]
[DisplayName("Financial Institution Data1")]
public record FinancialInstitutionData1
{
    /// <summary>
    /// Identification of the financial institution.
    /// </summary>
    [IsoId("_fq2RQXSCEfC68Y4jZPNEug")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Business or client identification for financial institution.
    /// </summary>
    [IsoId("_we_j7HSCEfC68Y4jZPNEug")]
    [DisplayName("Business Identification")]
    [IsoXmlTag("BizId")]
    public IsoMax15AlphaNumericText? BusinessIdentification { get; init; }

    /// <summary>
    /// Country of the financial institution.
    /// </summary>
    [IsoId("_fq2RRXSCEfC68Y4jZPNEug")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Business name of the financial institution.
    /// </summary>
    [IsoId("_we_j7XSCEfC68Y4jZPNEug")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the financial institution.
    /// </summary>
    [IsoId("_fq2RSXSCEfC68Y4jZPNEug")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Account number from which the funds get debited or credited.
    /// </summary>
    [IsoId("_fq2RTXSCEfC68Y4jZPNEug")]
    [DisplayName("Account Number")]
    [IsoXmlTag("AcctNb")]
    public IsoMax35Text? AccountNumber { get; init; }

    /// <summary>
    /// Address of the settlement institution.
    /// </summary>
    [IsoId("_we_j7nSCEfC68Y4jZPNEug")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_we_j73SCEfC68Y4jZPNEug")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_we_j8HSCEfC68Y4jZPNEug")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_we_j8XSCEfC68Y4jZPNEug")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData20> LocalData { get; init; } = [];
}
