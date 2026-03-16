// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an alternative identification of a trading party, for example, trader code, trader name, short legal name of firm and so on.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yG5lsEU8EeSGWeX3z5zSZQ")]
[Description(
    @"Specifies an alternative identification of a trading party, for example, trader code, trader name, short legal name of firm and so on."
)]
[Derivations(typeof(PartyIdentificationType1Code))]
public enum PartyIdentificationTypeCode
{
    /// <summary>
    /// Specifies the traders.
    /// Encoded/decoded by serializers as &quot;TRCO&quot;.
    /// </summary>
    [EnumMember(Value = "TRCO")]
    [IsoId("_c_-Z0EU9EeSGWeX3z5zSZQ")]
    [Description(@"Specifies the traders.")]
    TraderCode,

    /// <summary>
    /// Legal full title of the trading members.
    /// Encoded/decoded by serializers as &quot;FLNF&quot;.
    /// </summary>
    [EnumMember(Value = "FLNF")]
    [IsoId("_R2Fe0EU-EeSGWeX3z5zSZQ")]
    [Description(@"Legal full title of the trading members.")]
    FullLegalNameOfFirm,

    /// <summary>
    /// Postal address of the trading members.
    /// Encoded/decoded by serializers as &quot;POAD&quot;.
    /// </summary>
    [EnumMember(Value = "POAD")]
    [IsoId("_6tzfMEU-EeSGWeX3z5zSZQ")]
    [Description(@"Postal address of the trading members.")]
    PostalAddress,

    /// <summary>
    /// Phone number of the trading members.
    /// Encoded/decoded by serializers as &quot;PONU&quot;.
    /// </summary>
    [EnumMember(Value = "PONU")]
    [IsoId("_-ho9MEU-EeSGWeX3z5zSZQ")]
    [Description(@"Phone number of the trading members.")]
    PhoneNumber,

    /// <summary>
    /// Contact name of the trading members.
    /// Encoded/decoded by serializers as &quot;CONU&quot;.
    /// </summary>
    [EnumMember(Value = "CONU")]
    [IsoId("_C3RgsEU_EeSGWeX3z5zSZQ")]
    [Description(@"Contact name of the trading members.")]
    ContactName,

    /// <summary>
    /// Department of the trading members.
    /// Encoded/decoded by serializers as &quot;DEPA&quot;.
    /// </summary>
    [EnumMember(Value = "DEPA")]
    [IsoId("_G7gLIEU_EeSGWeX3z5zSZQ")]
    [Description(@"Department of the trading members.")]
    Department,

    /// <summary>
    /// Specifies the maket makers.
    /// Encoded/decoded by serializers as &quot;MAMA&quot;.
    /// </summary>
    [EnumMember(Value = "MAMA")]
    [IsoId("_yh28AEU_EeSGWeX3z5zSZQ")]
    [Description(@"Specifies the maket makers.")]
    MarketMaker,

    /// <summary>
    /// Names for the traders.
    /// Encoded/decoded by serializers as &quot;TANA&quot;.
    /// </summary>
    [EnumMember(Value = "TANA")]
    [IsoId("_BYLQAEVAEeSGWeX3z5zSZQ")]
    [Description(@"Names for the traders.")]
    TraderName,

    /// <summary>
    /// Legal short title of the trading members.
    /// Encoded/decoded by serializers as &quot;SLNF&quot;.
    /// </summary>
    [EnumMember(Value = "SLNF")]
    [IsoId("_LTis8EVAEeSGWeX3z5zSZQ")]
    [Description(@"Legal short title of the trading members.")]
    ShortLegalNameOfFirm,

    /// <summary>
    /// Contact method of the traders.
    /// Encoded/decoded by serializers as &quot;CMOT&quot;.
    /// </summary>
    [EnumMember(Value = "CMOT")]
    [IsoId("_ZGam8EVAEeSGWeX3z5zSZQ")]
    [Description(@"Contact method of the traders.")]
    ContactMethodOfTrader,

    /// <summary>
    /// Identify members or clients.
    /// Encoded/decoded by serializers as &quot;MEOC&quot;.
    /// </summary>
    [EnumMember(Value = "MEOC")]
    [IsoId("_iAZfYEVAEeSGWeX3z5zSZQ")]
    [Description(@"Identify members or clients.")]
    MembersOrClients,

    /// <summary>
    /// Specifies the non maket makers.
    /// Encoded/decoded by serializers as &quot;NOMM&quot;.
    /// </summary>
    [EnumMember(Value = "NOMM")]
    [IsoId("_rzw24EVAEeSGWeX3z5zSZQ")]
    [Description(@"Specifies the non maket makers.")]
    NonMarketMaker,

    /// <summary>
    /// Legal chinese full title of the trading members.
    /// Encoded/decoded by serializers as &quot;FLCN&quot;.
    /// </summary>
    [EnumMember(Value = "FLCN")]
    [IsoId("_xyrFUEVAEeSGWeX3z5zSZQ")]
    [Description(@"Legal chinese full title of the trading members.")]
    FullLegalChineseNameOfFirm,

    /// <summary>
    /// Legal chinese short title of the trading members.
    /// Encoded/decoded by serializers as &quot;SLCN&quot;.
    /// </summary>
    [EnumMember(Value = "SLCN")]
    [IsoId("_MoWHQEVBEeSGWeX3z5zSZQ")]
    [Description(@"Legal chinese short title of the trading members.")]
    ShortLegalChineseNameOfFirm,

    /// <summary>
    /// Chinese names for the traders.
    /// Encoded/decoded by serializers as &quot;TACN&quot;.
    /// </summary>
    [EnumMember(Value = "TACN")]
    [IsoId("_enAFMEVBEeSGWeX3z5zSZQ")]
    [Description(@"Chinese names for the traders.")]
    TraderChineseName,

    /// <summary>
    /// Zip code of the trading members.
    /// Encoded/decoded by serializers as &quot;ZICO&quot;.
    /// </summary>
    [EnumMember(Value = "ZICO")]
    [IsoId("_ndzGwEVBEeSGWeX3z5zSZQ")]
    [Description(@"Zip code of the trading members.")]
    ZipCode,

    /// <summary>
    /// Specifies the firm.
    /// Encoded/decoded by serializers as &quot;FICO&quot;.
    /// </summary>
    [EnumMember(Value = "FICO")]
    [IsoId("_sGkosEVBEeSGWeX3z5zSZQ")]
    [Description(@"Specifies the firm.")]
    FirmCode,

    /// <summary>
    /// Identification of the collateral management institution.
    /// Encoded/decoded by serializers as &quot;CMID&quot;.
    /// </summary>
    [EnumMember(Value = "CMID")]
    [IsoId("_fGoLAEVCEeSGWeX3z5zSZQ")]
    [Description(@"Identification of the collateral management institution.")]
    CollateralManagementInstitution,

    /// <summary>
    /// Name of the collateral management institution.
    /// Encoded/decoded by serializers as &quot;COIN&quot;.
    /// </summary>
    [EnumMember(Value = "COIN")]
    [IsoId("_tZxggEVCEeSGWeX3z5zSZQ")]
    [Description(@"Name of the collateral management institution.")]
    CollateralManagementInstitutionName,

    /// <summary>
    /// Name of the firm group.
    /// Encoded/decoded by serializers as &quot;INGN&quot;.
    /// </summary>
    [EnumMember(Value = "INGN")]
    [IsoId("_0KHy8EVCEeSGWeX3z5zSZQ")]
    [Description(@"Name of the firm group.")]
    InstitutionGroupName,

    /// <summary>
    /// Identification of the firm.
    /// Encoded/decoded by serializers as &quot;FIID&quot;.
    /// </summary>
    [EnumMember(Value = "FIID")]
    [IsoId("_E1s_cEVDEeSGWeX3z5zSZQ")]
    [Description(@"Identification of the firm.")]
    FirmIdentification,

    /// <summary>
    /// Specifies clearing institution.
    /// Encoded/decoded by serializers as &quot;CLIN&quot;.
    /// </summary>
    [EnumMember(Value = "CLIN")]
    [IsoId("_N1aFYEVDEeSGWeX3z5zSZQ")]
    [Description(@"Specifies clearing institution.")]
    ClearingInstitution,

    /// <summary>
    /// Internal team that traders belong.
    /// Encoded/decoded by serializers as &quot;IGBT&quot;.
    /// </summary>
    [EnumMember(Value = "IGBT")]
    [IsoId("_qPaA0EVDEeSGWeX3z5zSZQ")]
    [Description(@"Internal team that traders belong.|")]
    InternalGroupTheTraderBelongedTo,

    /// <summary>
    /// Trade confimation person name.
    /// Encoded/decoded by serializers as &quot;DECN&quot;.
    /// </summary>
    [EnumMember(Value = "DECN")]
    [IsoId("_2ylYEEVEEeSGWeX3z5zSZQ")]
    [Description(@"Trade confimation person name.")]
    DealConfirmContactName,

    /// <summary>
    /// Member identification of the RMB trading system
    /// Encoded/decoded by serializers as &quot;RMID&quot;.
    /// </summary>
    [EnumMember(Value = "RMID")]
    [IsoId("_hsAKcEVFEeSGWeX3z5zSZQ")]
    [Description(@"Member identification of the RMB trading system|")]
    RMBMemberIdentification,

    /// <summary>
    /// Member identification of the FX trading system.
    /// Encoded/decoded by serializers as &quot;FXID&quot;.
    /// </summary>
    [EnumMember(Value = "FXID")]
    [IsoId("_zHB24EVFEeSGWeX3z5zSZQ")]
    [Description(@"Member identification of the FX trading system.")]
    FXMemberID,

    /// <summary>
    /// English short name of FX system.
    /// Encoded/decoded by serializers as &quot;FXSN&quot;.
    /// </summary>
    [EnumMember(Value = "FXSN")]
    [IsoId("_8KBhYEVFEeSGWeX3z5zSZQ")]
    [Description(@"English short name of FX system.")]
    FXSystemEnglishShortName,

    /// <summary>
    /// Specifies other system.
    /// Encoded/decoded by serializers as &quot;OSCO&quot;.
    /// </summary>
    [EnumMember(Value = "OSCO")]
    [IsoId("_VZYFwEVGEeSGWeX3z5zSZQ")]
    [Description(@"Specifies other system.")]
    OtherSystemCode,

    /// <summary>
    /// Institution of custody management.
    /// Encoded/decoded by serializers as &quot;CMIN&quot;.
    /// </summary>
    [EnumMember(Value = "CMIN")]
    [IsoId("_bTCAwEVGEeSGWeX3z5zSZQ")]
    [Description(@"Institution of custody management.")]
    CustodyManagementInstitution,

    /// <summary>
    /// Institution identification in com star system.
    /// Encoded/decoded by serializers as &quot;IICS&quot;.
    /// </summary>
    [EnumMember(Value = "IICS")]
    [IsoId("_m9omsEVGEeSGWeX3z5zSZQ")]
    [Description(@"Institution identification in com star system.")]
    InstitutionIdentificationInComStarSystem,

    /// <summary>
    /// User name of the trading system.
    /// Encoded/decoded by serializers as &quot;USNA&quot;.
    /// </summary>
    [EnumMember(Value = "USNA")]
    [IsoId("_1Du-sEVGEeSGWeX3z5zSZQ")]
    [Description(@"User name of the trading system.")]
    UserName,

    /// <summary>
    /// Password of the trading system.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_68UisEVGEeSGWeX3z5zSZQ")]
    [Description(@"Password of the trading system.")]
    Password,

    /// <summary>
    /// Type of the trading members.
    /// Encoded/decoded by serializers as &quot;METY&quot;.
    /// </summary>
    [EnumMember(Value = "METY")]
    [IsoId("_CQJ8sEVHEeSGWeX3z5zSZQ")]
    [Description(@"Type of the trading members.")]
    MemberType,

    /// <summary>
    /// Input the user of trading system.
    /// Encoded/decoded by serializers as &quot;USIT&quot;.
    /// </summary>
    [EnumMember(Value = "USIT")]
    [IsoId("_ISujIEVHEeSGWeX3z5zSZQ")]
    [Description(@"Input the user of trading system.")]
    UserInputTrades,

    /// <summary>
    /// Agent input the user of the trading system.
    /// Encoded/decoded by serializers as &quot;AUIT&quot;.
    /// </summary>
    [EnumMember(Value = "AUIT")]
    [IsoId("_aT-iEEVHEeSGWeX3z5zSZQ")]
    [Description(@"Agent input the user of the trading system.")]
    AgentUserInputTrades,

    /// <summary>
    /// Place of execution.
    /// Encoded/decoded by serializers as &quot;EXVE&quot;.
    /// </summary>
    [EnumMember(Value = "EXVE")]
    [IsoId("_ocgjAEVHEeSGWeX3z5zSZQ")]
    [Description(@"Place of execution.")]
    ExecutionVenue,

    /// <summary>
    /// Specifies eligible of counterparty.
    /// Encoded/decoded by serializers as &quot;ELCO&quot;.
    /// </summary>
    [EnumMember(Value = "ELCO")]
    [IsoId("_xeDcAEVHEeSGWeX3z5zSZQ")]
    [Description(@"Specifies eligible of counterparty.")]
    EligibleCounterparty,

    /// <summary>
    /// Identification of the branch.
    /// Encoded/decoded by serializers as &quot;BRID&quot;.
    /// </summary>
    [EnumMember(Value = "BRID")]
    [IsoId("_nF528Ea8EeSm2psHh_KSCw")]
    [Description(@"Identification of the branch.")]
    BranchIdentification,
}
