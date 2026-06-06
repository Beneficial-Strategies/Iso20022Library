// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the transactor who provides technical payment solutions for acceptor and originator to conduct transactions.
/// </summary>
[IsoId("_PssmMSq6EfCD0_iZ8tw-zA")]
[DisplayName("Transactor Data1")]
public record TransactorData1
{
    /// <summary>
    /// Type of the transactor.
    /// </summary>
    [IsoId("_sxpGoCq7EfCD0_iZ8tw-zA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ExternalTransactorType1Code Type { get; init; }

    /// <summary>
    /// Identification of the issuer.
    /// </summary>
    [IsoId("_PvJdQSq6EfCD0_iZ8tw-zA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax11NumericText Identification { get; init; }

    /// <summary>
    /// Business or client identification for the issuer.
    /// </summary>
    [IsoId("_PvJdSSq6EfCD0_iZ8tw-zA")]
    [DisplayName("Business Identification")]
    [IsoXmlTag("BizId")]
    public IsoMax15AlphaNumericText? BusinessIdentification { get; init; }

    /// <summary>
    /// Business name of the issuer.
    /// </summary>
    [IsoId("_PvJdTSq6EfCD0_iZ8tw-zA")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the issuer.
    /// </summary>
    [IsoId("_PvJdTyq6EfCD0_iZ8tw-zA")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Address of the issuer.
    /// </summary>
    [IsoId("_PvJdUSq6EfCD0_iZ8tw-zA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("__ZD_YlwsEfCoP_h9uwd39Q")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("__ZD_Y1wsEfCoP_h9uwd39Q")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_PvJdYSq6EfCD0_iZ8tw-zA")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData20> LocalData { get; init; } = [];

    /// <summary>
    /// Submerchant is a merchant that uses the transactor to complete the transaction.
    /// </summary>
    [IsoId("_pYOzUa2rEfCKbLfqFyM0kg")]
    [DisplayName("Sub Merchant")]
    [IsoXmlTag("SubMrchnt")]
    public ValueList<SubMerchant1> SubMerchant { get; init; } = [];
}
