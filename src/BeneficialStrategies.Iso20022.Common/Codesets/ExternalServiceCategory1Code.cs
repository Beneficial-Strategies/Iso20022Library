// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the service category, as published in an external status reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-3PZgJunEey__7eNd9lW5Q")]
[Description(
    @"Specifies the service category, as published in an external status reason code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalServiceCategoryCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalServiceCategory1Code>))]
public enum ExternalServiceCategory1Code
{
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed expressed as a code.
    /// This category encompasses the reporting of fees related to account management services including, inter alia, membership fees and minimum fees (i.e. fees added to small invoices in order to reach the minimum fees agreed for each participant).
    /// Encoded/decoded by serializers as &quot;ACMS&quot;.
    /// </summary>
    [EnumMember(Value = "ACMS")]
    [IsoId("_B9buYZuoEey__7eNd9lW5Q")]
    [Description(@"Agreement under which or rules under which the transaction should be processed expressed as a code.|This category encompasses the reporting of fees related to account management services including, inter alia, membership fees and minimum fees (i.e. fees added to small invoices in order to reach the minimum fees agreed for each participant).")]
    AccountManagementServices = ExternalServiceCategoryCode.AccountManagementServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all fees related to the management of collateral subject to bilateral agreements (covering central bank financing for marketable and non-marketable assets, non-cleared OTC derivatives and securities financing).
    /// Encoded/decoded by serializers as &quot;BICM&quot;.
    /// </summary>
    [EnumMember(Value = "BICM")]
    [IsoId("_CFVGIZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the management of collateral subject to bilateral agreements (covering central bank financing for marketable and non-marketable assets, non-cleared OTC derivatives and securities financing).")]
    BilateralCollateralManagement = ExternalServiceCategoryCode.BilateralCollateralManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all fees related to cash and liquidity management services.
    /// Encoded/decoded by serializers as &quot;CALM&quot;.
    /// </summary>
    [EnumMember(Value = "CALM")]
    [IsoId("_CKQCYZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to cash and liquidity management services.")]
    CashAndLiquidityManagementServices = ExternalServiceCategoryCode.CashAndLiquidityManagementServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of fees related to the provision of clearing services.
    /// Encoded/decoded by serializers as &quot;CLEA&quot;.
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_CPw0gZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to the provision of clearing services.")]
    ClearingServices = ExternalServiceCategoryCode.ClearingServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all fees that are charged per operation such as election instructions. The category is also used to report fees on tax services related to assets under custody together with the processing of corporate actions and meetings events.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_CXz9QZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees that are charged per operation such as election instructions. The category is also used to report fees on tax services related to assets under custody together with the processing of corporate actions and meetings events.")]
    CustodyServices = ExternalServiceCategoryCode.CustodyServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all fees related to the provision of information through any kind of means and to the provision of connectivity tools. This includes ISO messaging (inbound or outbound), graphical user interface (GUI) access, connectivity, recharge of security tokens, report subscriptions and the provision of data by any other means (e.g. paper based formats).
    /// Encoded/decoded by serializers as &quot;INSV&quot;.
    /// </summary>
    [EnumMember(Value = "INSV")]
    [IsoId("_Cay_0ZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the provision of information through any kind of means and to the provision of connectivity tools. This includes ISO messaging (inbound or outbound), graphical user interface (GUI) access, connectivity, recharge of security tokens, report subscriptions and the provision of data by any other means (e.g. paper based formats).")]
    InformationServices = ExternalServiceCategoryCode.InformationServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all related to specific services provided for investment funds, such as order routing or holder reporting. The safekeeping and settlement of investment funds and exchange-traded funds should be reported under the Safekeeping Services and Settlement Services categories respectively.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_Cgms4ZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all related to specific services provided for investment funds, such as order routing or holder reporting. The safekeeping and settlement of investment funds and exchange-traded funds should be reported under the Safekeeping Services and Settlement Services categories respectively.")]
    InvestmentFundServices = ExternalServiceCategoryCode.InvestmentFundServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of fees related to the provision of issuer services by a CSD. This includes fees such as issuance and redemptions of securities and management of corporate actions.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_CoNJsZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to the provision of issuer services by a CSD. This includes fees such as issuance and redemptions of securities and management of corporate actions.")]
    IssuerServices = ExternalServiceCategoryCode.IssuerServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of fees related to other services provided which might not be set in a general tariff applicable to all clients, but bilaterally agreed with clients individually. This includes the provision of customised service requests and other support provided to clients such as training and testing access as well as out-of-pocket expenses.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Cr7MEZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to other services provided which might not be set in a general tariff applicable to all clients, but bilaterally agreed with clients individually. This includes the provision of customised service requests and other support provided to clients such as training and testing access as well as out-of-pocket expenses.")]
    OtherServices = ExternalServiceCategoryCode.OtherServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all fees related to the cost recovery of settlement penalties applied by non-EU settlement systems (outside the scope of CSDR settlement discipline).
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_DBYesZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the cost recovery of settlement penalties applied by non-EU settlement systems (outside the scope of CSDR settlement discipline).")]
    SettlementPenalties = ExternalServiceCategoryCode.SettlementPenalties, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of fees related to the recovery of costs associated with the development and maintenance of the penalty mechanism. Note: this category should not be used for the reporting of the penalty itself.
    /// Encoded/decoded by serializers as &quot;PENM&quot;.
    /// </summary>
    [EnumMember(Value = "PENM")]
    [IsoId("_Cv8wcZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to the recovery of costs associated with the development and maintenance of the penalty mechanism. Note: this category should not be used for the reporting of the penalty itself.")]
    PenaltyMechanism = ExternalServiceCategoryCode.PenaltyMechanism, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all fees related to the registration of securities.
    /// Encoded/decoded by serializers as &quot;REGI&quot;.
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_C0IF0ZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the registration of securities.")]
    RegistrationServices = ExternalServiceCategoryCode.RegistrationServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all fees that are calculated as basis points applied to the assets under custody. This includes notary, central maintenance and asset servicing fees.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_C5fG8ZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees that are calculated as basis points applied to the assets under custody. This includes notary, central maintenance and asset servicing fees.")]
    SafekeepingServices = ExternalServiceCategoryCode.SafekeepingServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all fees related to securities lending services.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_C9zmQZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to securities lending services.")]
    SecuritiesLendingServices = ExternalServiceCategoryCode.SecuritiesLendingServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all fees related to the settlement of securities and/or cash. This includes fees related to the settlement of market claims and transformations. Taxes applied on settled transactions (such as financial transaction taxes) and ancillary settlement services are also reported under this category.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_DF2vAZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the settlement of securities and/or cash. This includes fees related to the settlement of market claims and transformations. Taxes applied on settled transactions (such as financial transaction taxes) and ancillary settlement services are also reported under this category.")]
    SettlementServices = ExternalServiceCategoryCode.SettlementServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of fees related to the provision of services allowing intermediaries to send shareholders' data to issuers. This includes costs related to the provision of service for the calculation and settlement of fees applied by intermediaries to issuers for the notification of shareholders' data.
    /// Encoded/decoded by serializers as &quot;SHDT&quot;.
    /// </summary>
    [EnumMember(Value = "SHDT")]
    [IsoId("_DKeJQZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to the provision of services allowing intermediaries to send shareholders' data to issuers. This includes costs related to the provision of service for the calculation and settlement of fees applied by intermediaries to issuers for the notification of shareholders' data.")]
    ShareholdersDataTransmissionServices = ExternalServiceCategoryCode.ShareholdersDataTransmissionServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of fees related to the provision of stock exchange services. This includes transaction fees.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_DN53wZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to the provision of stock exchange services. This includes transaction fees.")]
    StockExchangeServices = ExternalServiceCategoryCode.StockExchangeServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This category encompasses the reporting of all fees related to the provision of services to collateral giver and/or collateral takers involved in a triparty collateral management transaction.
    /// Encoded/decoded by serializers as &quot;TPCM&quot;.
    /// </summary>
    [EnumMember(Value = "TPCM")]
    [IsoId("_DTHu8ZuoEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the provision of services to collateral giver and/or collateral takers involved in a triparty collateral management transaction.")]
    TripartyCollateralManagementServices = ExternalServiceCategoryCode.TripartyCollateralManagementServices, // same ordinal as derivation source for type conversions
}
