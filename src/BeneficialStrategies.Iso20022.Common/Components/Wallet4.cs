// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Container for tenders used by the customer to perform the payment transaction.
/// </summary>
[IsoId("_OPJEURQXEfC1ZfCQz0xB3g")]
[DisplayName("Wallet4")]
public record Wallet4
{
    [IsoId("_SO-dpkhyEfCMZJtj4J7UGQ")]
    [DisplayName("Provider Name")]
    [IsoXmlTag("PrvdrNm")]
    public IsoMax70Text? ProviderName { get; init; }

    [IsoId("_SO-dqEhyEfCMZJtj4J7UGQ")]
    [DisplayName("Provider Business Name")]
    [IsoXmlTag("PrvdrBizNm")]
    public IsoMax35Text? ProviderBusinessName { get; init; }

    [IsoId("_SO-dp0hyEfCMZJtj4J7UGQ")]
    [DisplayName("Provider Identification")]
    [IsoXmlTag("PrvdrId")]
    public IsoMax35Text? ProviderIdentification { get; init; }

    [IsoId("_SO-dqUhyEfCMZJtj4J7UGQ")]
    [DisplayName("Provider Legal Corporate Name")]
    [IsoXmlTag("PrvdrLglCorpNm")]
    public IsoMax99Text? ProviderLegalCorporateName { get; init; }

    [IsoId("_SO-dq0hyEfCMZJtj4J7UGQ")]
    [DisplayName("Provider Address")]
    [IsoXmlTag("PrvdrAdr")]
    public Address4? ProviderAddress { get; init; }

    [IsoId("_SO-dqkhyEfCMZJtj4J7UGQ")]
    [DisplayName("Provider Local Data")]
    [IsoXmlTag("PrvdrLclData")]
    public ValueList<LocalData20> ProviderLocalData { get; init; } = [];

    [IsoId("_OWOjwxQXEfC1ZfCQz0xB3g")]
    [DisplayName("PAN Age")]
    [IsoXmlTag("PANAge")]
    public IsoMax5PositiveNumber? PANAge { get; init; }

    [IsoId("_OWOjxRQXEfC1ZfCQz0xB3g")]
    [DisplayName("User Account Age")]
    [IsoXmlTag("UsrAcctAge")]
    public IsoMax5PositiveNumber? UserAccountAge { get; init; }

    [IsoId("_OWOjxxQXEfC1ZfCQz0xB3g")]
    [DisplayName("Account Age")]
    [IsoXmlTag("AcctAge")]
    public IsoMax5PositiveNumber? AccountAge { get; init; }

    [IsoId("_OWOjyRQXEfC1ZfCQz0xB3g")]
    [DisplayName("Days Since Last Activity")]
    [IsoXmlTag("DaysSncLastActvty")]
    public IsoMax5PositiveNumber? DaysSinceLastActivity { get; init; }

    [IsoId("_OWOjyxQXEfC1ZfCQz0xB3g")]
    [DisplayName("Activity")]
    [IsoXmlTag("Actvty")]
    public IsoMax10PositiveNumber? Activity { get; init; }

    [IsoId("_OWOjzRQXEfC1ZfCQz0xB3g")]
    [DisplayName("Activity Interval")]
    [IsoXmlTag("ActvtyIntrvl")]
    public Frequency12Code? ActivityInterval { get; init; }

    [IsoId("_OWOjzxQXEfC1ZfCQz0xB3g")]
    [DisplayName("Last Wallet Change")]
    [IsoXmlTag("LastWlltChng")]
    public IsoMax5PositiveNumber? LastWalletChange { get; init; }

    [IsoId("_OWOj0RQXEfC1ZfCQz0xB3g")]
    [DisplayName("Suspended Cards")]
    [IsoXmlTag("SspdCrds")]
    public IsoMax5PositiveNumber? SuspendedCards { get; init; }

    [IsoId("_OWOj0xQXEfC1ZfCQz0xB3g")]
    [DisplayName("Account Country")]
    [IsoXmlTag("AcctCtry")]
    public ISOMax3ACountryCode? AccountCountry { get; init; }

    [IsoId("_OWOj1RQXEfC1ZfCQz0xB3g")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading12Code? CardDataEntryMode { get; init; }

    [IsoId("_OWOj2RQXEfC1ZfCQz0xB3g")]
    [DisplayName("Account Email Age")]
    [IsoXmlTag("AcctEmailAge")]
    public IsoMax5PositiveNumber? AccountEmailAge { get; init; }

    [IsoId("_OWOj2xQXEfC1ZfCQz0xB3g")]
    [DisplayName("Provider Risk Assessment")]
    [IsoXmlTag("PrvdrRskAssmnt")]
    public RiskAssessment1Code? ProviderRiskAssessment { get; init; }

    [IsoId("_OWOj3RQXEfC1ZfCQz0xB3g")]
    [DisplayName("Provider Risk Assessment Model Version")]
    [IsoXmlTag("PrvdrRskAssmntMdlVrsn")]
    public IsoMax35Text? ProviderRiskAssessmentModelVersion { get; init; }

    [IsoId("_OWOj3xQXEfC1ZfCQz0xB3g")]
    [DisplayName("Provider Phone Score")]
    [IsoXmlTag("PrvdrPhneScore")]
    public IsoMax5PositiveNumber? ProviderPhoneScore { get; init; }

    [IsoId("_OWOj4RQXEfC1ZfCQz0xB3g")]
    [DisplayName("Provider Device Score")]
    [IsoXmlTag("PrvdrDvcScore")]
    public IsoMax5PositiveNumber? ProviderDeviceScore { get; init; }

    [IsoId("_OWOj4xQXEfC1ZfCQz0xB3g")]
    [DisplayName("Provider Account Score")]
    [IsoXmlTag("PrvdrAcctScore")]
    public IsoMax5PositiveNumber? ProviderAccountScore { get; init; }

    [IsoId("_OpSQ4K8eEfCnL-2fAG0ssA")]
    [DisplayName("Provider Reason Code")]
    [IsoXmlTag("PrvdrRsnCd")]
    public IsoMax35Text? ProviderReasonCode { get; init; }

    [IsoId("_VFnC4kVZEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_VFnC40VZEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
