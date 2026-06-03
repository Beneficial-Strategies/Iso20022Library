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
    [IsoId("_sxpGoCq7EfCD0_iZ8tw-zA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ExternalTransactorType1Code Type { get; init; }

    [IsoId("_PvJdQSq6EfCD0_iZ8tw-zA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax11NumericText Identification { get; init; }

    [IsoId("_PvJdSSq6EfCD0_iZ8tw-zA")]
    [DisplayName("Business Identification")]
    [IsoXmlTag("BizId")]
    public IsoMax15AlphaNumericText? BusinessIdentification { get; init; }

    [IsoId("_PvJdTSq6EfCD0_iZ8tw-zA")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    [IsoId("_PvJdTyq6EfCD0_iZ8tw-zA")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    [IsoId("_PvJdUSq6EfCD0_iZ8tw-zA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    [IsoId("__ZD_YlwsEfCoP_h9uwd39Q")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("__ZD_Y1wsEfCoP_h9uwd39Q")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    [IsoId("_PvJdYSq6EfCD0_iZ8tw-zA")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData20> LocalData { get; init; } = [];

    [IsoId("_pYOzUa2rEfCKbLfqFyM0kg")]
    [DisplayName("Sub Merchant")]
    [IsoXmlTag("SubMrchnt")]
    public ValueList<SubMerchant1> SubMerchant { get; init; } = [];
}
