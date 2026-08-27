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
[IsoId("_7i1OAJudEey__7eNd9lW5Q")]
[Description(
    @"Specifies the service category, as published in an external status reason code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalServiceCategory1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalServiceCategoryCode>))]
public enum ExternalServiceCategoryCode
{
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed expressed as a code.
    /// This category encompasses the reporting of fees related to account management services including, inter alia, membership fees and minimum fees (i.e. fees added to small invoices in order to reach the minimum fees agreed for each participant).
    /// Encoded/decoded by serializers as &quot;ACMS&quot;.
    /// </summary>
    [EnumMember(Value = "ACMS")]
    [IsoId("_laiScJujEey__7eNd9lW5Q")]
    [Description(@"Agreement under which or rules under which the transaction should be processed expressed as a code.|This category encompasses the reporting of fees related to account management services including, inter alia, membership fees and minimum fees (i.e. fees added to small invoices in order to reach the minimum fees agreed for each participant).")]
    AccountManagementServices,

    /// <summary>
    /// This category encompasses the reporting of all fees related to the management of collateral subject to bilateral agreements (covering central bank financing for marketable and non-marketable assets, non-cleared OTC derivatives and securities financing).
    /// Encoded/decoded by serializers as &quot;BICM&quot;.
    /// </summary>
    [EnumMember(Value = "BICM")]
    [IsoId("_r9aJkJujEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the management of collateral subject to bilateral agreements (covering central bank financing for marketable and non-marketable assets, non-cleared OTC derivatives and securities financing).")]
    BilateralCollateralManagement,

    /// <summary>
    /// This category encompasses the reporting of all fees related to cash and liquidity management services.
    /// Encoded/decoded by serializers as &quot;CALM&quot;.
    /// </summary>
    [EnumMember(Value = "CALM")]
    [IsoId("_wlyp8JujEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to cash and liquidity management services.")]
    CashAndLiquidityManagementServices,

    /// <summary>
    /// This category encompasses the reporting of fees related to the provision of clearing services.
    /// Encoded/decoded by serializers as &quot;CLEA&quot;.
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_2aBSYJujEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to the provision of clearing services.")]
    ClearingServices,

    /// <summary>
    /// This category encompasses the reporting of all fees that are charged per operation such as election instructions. The category is also used to report fees on tax services related to assets under custody together with the processing of corporate actions and meetings events.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_k2EeAJukEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees that are charged per operation such as election instructions. The category is also used to report fees on tax services related to assets under custody together with the processing of corporate actions and meetings events.")]
    CustodyServices,

    /// <summary>
    /// This category encompasses the reporting of all fees related to the provision of information through any kind of means and to the provision of connectivity tools. This includes ISO messaging (inbound or outbound), graphical user interface (GUI) access, connectivity, recharge of security tokens, report subscriptions and the provision of data by any other means (e.g. paper based formats).
    /// Encoded/decoded by serializers as &quot;INSV&quot;.
    /// </summary>
    [EnumMember(Value = "INSV")]
    [IsoId("_n9JjsJukEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the provision of information through any kind of means and to the provision of connectivity tools. This includes ISO messaging (inbound or outbound), graphical user interface (GUI) access, connectivity, recharge of security tokens, report subscriptions and the provision of data by any other means (e.g. paper based formats).")]
    InformationServices,

    /// <summary>
    /// This category encompasses the reporting of all related to specific services provided for investment funds, such as order routing or holder reporting. The safekeeping and settlement of investment funds and exchange-traded funds should be reported under the Safekeeping Services and Settlement Services categories respectively.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_tANN4JukEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all related to specific services provided for investment funds, such as order routing or holder reporting. The safekeeping and settlement of investment funds and exchange-traded funds should be reported under the Safekeeping Services and Settlement Services categories respectively.")]
    InvestmentFundServices,

    /// <summary>
    /// This category encompasses the reporting of fees related to the provision of issuer services by a CSD. This includes fees such as issuance and redemptions of securities and management of corporate actions.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_zcq7AJukEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to the provision of issuer services by a CSD. This includes fees such as issuance and redemptions of securities and management of corporate actions.")]
    IssuerServices,

    /// <summary>
    /// This category encompasses the reporting of fees related to other services provided which might not be set in a general tariff applicable to all clients, but bilaterally agreed with clients individually. This includes the provision of customised service requests and other support provided to clients such as training and testing access as well as out-of-pocket expenses.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_462a8JukEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to other services provided which might not be set in a general tariff applicable to all clients, but bilaterally agreed with clients individually. This includes the provision of customised service requests and other support provided to clients such as training and testing access as well as out-of-pocket expenses.")]
    OtherServices,

    /// <summary>
    /// This category encompasses the reporting of all fees related to the cost recovery of settlement penalties applied by non-EU settlement systems (outside the scope of CSDR settlement discipline).
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_QFOP0JulEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the cost recovery of settlement penalties applied by non-EU settlement systems (outside the scope of CSDR settlement discipline).")]
    SettlementPenalties,

    /// <summary>
    /// This category encompasses the reporting of fees related to the recovery of costs associated with the development and maintenance of the penalty mechanism. Note: this category should not be used for the reporting of the penalty itself.
    /// Encoded/decoded by serializers as &quot;PENM&quot;.
    /// </summary>
    [EnumMember(Value = "PENM")]
    [IsoId("_-kp8EJukEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to the recovery of costs associated with the development and maintenance of the penalty mechanism. Note: this category should not be used for the reporting of the penalty itself.")]
    PenaltyMechanism,

    /// <summary>
    /// This category encompasses the reporting of all fees related to the registration of securities.
    /// Encoded/decoded by serializers as &quot;REGI&quot;.
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_DwgV4JulEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the registration of securities.")]
    RegistrationServices,

    /// <summary>
    /// This category encompasses the reporting of all fees that are calculated as basis points applied to the assets under custody. This includes notary, central maintenance and asset servicing fees.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_JRD0YJulEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees that are calculated as basis points applied to the assets under custody. This includes notary, central maintenance and asset servicing fees.")]
    SafekeepingServices,

    /// <summary>
    /// This category encompasses the reporting of all fees related to securities lending services.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_NwXRQJulEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to securities lending services.")]
    SecuritiesLendingServices,

    /// <summary>
    /// This category encompasses the reporting of all fees related to the settlement of securities and/or cash. This includes fees related to the settlement of market claims and transformations. Taxes applied on settled transactions (such as financial transaction taxes) and ancillary settlement services are also reported under this category.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_T1SBEJulEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the settlement of securities and/or cash. This includes fees related to the settlement of market claims and transformations. Taxes applied on settled transactions (such as financial transaction taxes) and ancillary settlement services are also reported under this category.")]
    SettlementServices,

    /// <summary>
    /// This category encompasses the reporting of fees related to the provision of services allowing intermediaries to send shareholders' data to issuers. This includes costs related to the provision of service for the calculation and settlement of fees applied by intermediaries to issuers for the notification of shareholders' data.
    /// Encoded/decoded by serializers as &quot;SHDT&quot;.
    /// </summary>
    [EnumMember(Value = "SHDT")]
    [IsoId("_kVLiAJulEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to the provision of services allowing intermediaries to send shareholders' data to issuers. This includes costs related to the provision of service for the calculation and settlement of fees applied by intermediaries to issuers for the notification of shareholders' data.")]
    ShareholdersDataTransmissionServices,

    /// <summary>
    /// This category encompasses the reporting of fees related to the provision of stock exchange services. This includes transaction fees.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_oEDAcJulEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of fees related to the provision of stock exchange services. This includes transaction fees.")]
    StockExchangeServices,

    /// <summary>
    /// This category encompasses the reporting of all fees related to the provision of services to collateral giver and/or collateral takers involved in a triparty collateral management transaction.
    /// Encoded/decoded by serializers as &quot;TPCM&quot;.
    /// </summary>
    [EnumMember(Value = "TPCM")]
    [IsoId("_uggtkJulEey__7eNd9lW5Q")]
    [Description(@"This category encompasses the reporting of all fees related to the provision of services to collateral giver and/or collateral takers involved in a triparty collateral management transaction.")]
    TripartyCollateralManagementServices,
}
