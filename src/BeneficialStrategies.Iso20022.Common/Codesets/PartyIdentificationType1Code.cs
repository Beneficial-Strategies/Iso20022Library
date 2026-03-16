// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an alternative identification of a trading party, for example, trader code, trader name, short legal name of firm and so on.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0ZEJEIA2EeSUJZYcWGKkkw")]
[Description(
    @"Specifies an alternative identification of a trading party, for example, trader code, trader name, short legal name of firm and so on."
)]
[DerivedFrom(typeof(PartyIdentificationTypeCode))]
public enum PartyIdentificationType1Code
{
    /// <summary>
    /// Member identification of the FX trading system.
    /// Encoded/decoded by serializers as &quot;FXID&quot;.
    /// </summary>
    [EnumMember(Value = "FXID")]
    [IsoId("_2jqYYYA2EeSUJZYcWGKkkw")]
    [Description(@"Member identification of the FX trading system.")]
    FXMemberID = PartyIdentificationTypeCode.FXMemberID, // same ordinal as derivation source for type conversions

    /// <summary>
    /// English short name of FX system.
    /// Encoded/decoded by serializers as &quot;FXSN&quot;.
    /// </summary>
    [EnumMember(Value = "FXSN")]
    [IsoId("_2oP9cYA2EeSUJZYcWGKkkw")]
    [Description(@"English short name of FX system.")]
    FXSystemEnglishShortName = PartyIdentificationTypeCode.FXSystemEnglishShortName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Name of the firm group.
    /// Encoded/decoded by serializers as &quot;INGN&quot;.
    /// </summary>
    [EnumMember(Value = "INGN")]
    [IsoId("_2su00YA2EeSUJZYcWGKkkw")]
    [Description(@"Name of the firm group.")]
    InstitutionGroupName = PartyIdentificationTypeCode.InstitutionGroupName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Institution identification in com star system.
    /// Encoded/decoded by serializers as &quot;IICS&quot;.
    /// </summary>
    [EnumMember(Value = "IICS")]
    [IsoId("_2xOTQYA2EeSUJZYcWGKkkw")]
    [Description(@"Institution identification in com star system.")]
    InstitutionIdentificationInComStarSystem =
        PartyIdentificationTypeCode.InstitutionIdentificationInComStarSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internal team that traders belong.
    /// Encoded/decoded by serializers as &quot;IGBT&quot;.
    /// </summary>
    [EnumMember(Value = "IGBT")]
    [IsoId("_21sjkYA2EeSUJZYcWGKkkw")]
    [Description(@"Internal team that traders belong.|")]
    InternalGroupTheTraderBelongedTo = PartyIdentificationTypeCode.InternalGroupTheTraderBelongedTo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the maket makers.
    /// Encoded/decoded by serializers as &quot;MAMA&quot;.
    /// </summary>
    [EnumMember(Value = "MAMA")]
    [IsoId("_26Q6gYA2EeSUJZYcWGKkkw")]
    [Description(@"Specifies the maket makers.")]
    MarketMaker = PartyIdentificationTypeCode.MarketMaker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identify members or clients.
    /// Encoded/decoded by serializers as &quot;MEOC&quot;.
    /// </summary>
    [EnumMember(Value = "MEOC")]
    [IsoId("_2-vx4YA2EeSUJZYcWGKkkw")]
    [Description(@"Identify members or clients.")]
    MembersOrClients = PartyIdentificationTypeCode.MembersOrClients, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of the trading members.
    /// Encoded/decoded by serializers as &quot;METY&quot;.
    /// </summary>
    [EnumMember(Value = "METY")]
    [IsoId("_3GA3gYA2EeSUJZYcWGKkkw")]
    [Description(@"Type of the trading members.")]
    MemberType = PartyIdentificationTypeCode.MemberType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the non maket makers.
    /// Encoded/decoded by serializers as &quot;NOMM&quot;.
    /// </summary>
    [EnumMember(Value = "NOMM")]
    [IsoId("_3N1WwYA2EeSUJZYcWGKkkw")]
    [Description(@"Specifies the non maket makers.")]
    NonMarketMaker = PartyIdentificationTypeCode.NonMarketMaker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies other system.
    /// Encoded/decoded by serializers as &quot;OSCO&quot;.
    /// </summary>
    [EnumMember(Value = "OSCO")]
    [IsoId("_3VsSQYA2EeSUJZYcWGKkkw")]
    [Description(@"Specifies other system.")]
    OtherSystemCode = PartyIdentificationTypeCode.OtherSystemCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Password of the trading system.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_3bsMkYA2EeSUJZYcWGKkkw")]
    [Description(@"Password of the trading system.")]
    Password = PartyIdentificationTypeCode.Password, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Phone number of the trading members.
    /// Encoded/decoded by serializers as &quot;PONU&quot;.
    /// </summary>
    [EnumMember(Value = "PONU")]
    [IsoId("_3iIy0YA2EeSUJZYcWGKkkw")]
    [Description(@"Phone number of the trading members.")]
    PhoneNumber = PartyIdentificationTypeCode.PhoneNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address of the trading members.
    /// Encoded/decoded by serializers as &quot;POAD&quot;.
    /// </summary>
    [EnumMember(Value = "POAD")]
    [IsoId("_3nRxgYA2EeSUJZYcWGKkkw")]
    [Description(@"Postal address of the trading members.")]
    PostalAddress = PartyIdentificationTypeCode.PostalAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Member identification of the RMB trading system
    /// Encoded/decoded by serializers as &quot;RMID&quot;.
    /// </summary>
    [EnumMember(Value = "RMID")]
    [IsoId("_3soLkYA2EeSUJZYcWGKkkw")]
    [Description(@"Member identification of the RMB trading system|")]
    RMBMemberIdentification = PartyIdentificationTypeCode.RMBMemberIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal chinese short title of the trading members.
    /// Encoded/decoded by serializers as &quot;SLCN&quot;.
    /// </summary>
    [EnumMember(Value = "SLCN")]
    [IsoId("_3xxKQYA2EeSUJZYcWGKkkw")]
    [Description(@"Legal chinese short title of the trading members.")]
    ShortLegalChineseNameOfFirm = PartyIdentificationTypeCode.ShortLegalChineseNameOfFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal short title of the trading members.
    /// Encoded/decoded by serializers as &quot;SLNF&quot;.
    /// </summary>
    [EnumMember(Value = "SLNF")]
    [IsoId("_32Sd4YA2EeSUJZYcWGKkkw")]
    [Description(@"Legal short title of the trading members.")]
    ShortLegalNameOfFirm = PartyIdentificationTypeCode.ShortLegalNameOfFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Chinese names for the traders.
    /// Encoded/decoded by serializers as &quot;TACN&quot;.
    /// </summary>
    [EnumMember(Value = "TACN")]
    [IsoId("_369igYA2EeSUJZYcWGKkkw")]
    [Description(@"Chinese names for the traders.")]
    TraderChineseName = PartyIdentificationTypeCode.TraderChineseName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the traders.
    /// Encoded/decoded by serializers as &quot;TRCO&quot;.
    /// </summary>
    [EnumMember(Value = "TRCO")]
    [IsoId("_3_tfoYA2EeSUJZYcWGKkkw")]
    [Description(@"Specifies the traders.")]
    TraderCode = PartyIdentificationTypeCode.TraderCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Names for the traders.
    /// Encoded/decoded by serializers as &quot;TANA&quot;.
    /// </summary>
    [EnumMember(Value = "TANA")]
    [IsoId("_4FhzwYA2EeSUJZYcWGKkkw")]
    [Description(@"Names for the traders.")]
    TraderName = PartyIdentificationTypeCode.TraderName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Input the user of trading system.
    /// Encoded/decoded by serializers as &quot;USIT&quot;.
    /// </summary>
    [EnumMember(Value = "USIT")]
    [IsoId("_4QrT0YA2EeSUJZYcWGKkkw")]
    [Description(@"Input the user of trading system.")]
    UserInputTrades = PartyIdentificationTypeCode.UserInputTrades, // same ordinal as derivation source for type conversions

    /// <summary>
    /// User name of the trading system.
    /// Encoded/decoded by serializers as &quot;USNA&quot;.
    /// </summary>
    [EnumMember(Value = "USNA")]
    [IsoId("_4W8T4YA2EeSUJZYcWGKkkw")]
    [Description(@"User name of the trading system.")]
    UserName = PartyIdentificationTypeCode.UserName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent input the user of the trading system.
    /// Encoded/decoded by serializers as &quot;AUIT&quot;.
    /// </summary>
    [EnumMember(Value = "AUIT")]
    [IsoId("_5GMmkYA2EeSUJZYcWGKkkw")]
    [Description(@"Agent input the user of the trading system.")]
    AgentUserInputTrades = PartyIdentificationTypeCode.AgentUserInputTrades, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the branch.
    /// Encoded/decoded by serializers as &quot;BRID&quot;.
    /// </summary>
    [EnumMember(Value = "BRID")]
    [IsoId("_5K12AYA2EeSUJZYcWGKkkw")]
    [Description(@"Identification of the branch.")]
    BranchIdentification = PartyIdentificationTypeCode.BranchIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies clearing institution.
    /// Encoded/decoded by serializers as &quot;CLIN&quot;.
    /// </summary>
    [EnumMember(Value = "CLIN")]
    [IsoId("_5m5f4YA2EeSUJZYcWGKkkw")]
    [Description(@"Specifies clearing institution.")]
    ClearingInstitution = PartyIdentificationTypeCode.ClearingInstitution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the collateral management institution.
    /// Encoded/decoded by serializers as &quot;CMID&quot;.
    /// </summary>
    [EnumMember(Value = "CMID")]
    [IsoId("_5rjWYYA2EeSUJZYcWGKkkw")]
    [Description(@"Identification of the collateral management institution.")]
    CollateralManagementInstitution = PartyIdentificationTypeCode.CollateralManagementInstitution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Name of the collateral management institution.
    /// Encoded/decoded by serializers as &quot;COIN&quot;.
    /// </summary>
    [EnumMember(Value = "COIN")]
    [IsoId("_5wEqAYA2EeSUJZYcWGKkkw")]
    [Description(@"Name of the collateral management institution.")]
    CollateralManagementInstitutionName =
        PartyIdentificationTypeCode.CollateralManagementInstitutionName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contact method of the traders.
    /// Encoded/decoded by serializers as &quot;CMOT&quot;.
    /// </summary>
    [EnumMember(Value = "CMOT")]
    [IsoId("_50mksYA2EeSUJZYcWGKkkw")]
    [Description(@"Contact method of the traders.")]
    ContactMethodOfTrader = PartyIdentificationTypeCode.ContactMethodOfTrader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contact name of the trading members.
    /// Encoded/decoded by serializers as &quot;CONU&quot;.
    /// </summary>
    [EnumMember(Value = "CONU")]
    [IsoId("_55K7oYA2EeSUJZYcWGKkkw")]
    [Description(@"Contact name of the trading members.")]
    ContactName = PartyIdentificationTypeCode.ContactName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Institution of custody management.
    /// Encoded/decoded by serializers as &quot;CMIN&quot;.
    /// </summary>
    [EnumMember(Value = "CMIN")]
    [IsoId("_59rBIYA2EeSUJZYcWGKkkw")]
    [Description(@"Institution of custody management.")]
    CustodyManagementInstitution = PartyIdentificationTypeCode.CustodyManagementInstitution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade confimation person name.
    /// Encoded/decoded by serializers as &quot;DECN&quot;.
    /// </summary>
    [EnumMember(Value = "DECN")]
    [IsoId("_6CLGoYA2EeSUJZYcWGKkkw")]
    [Description(@"Trade confimation person name.")]
    DealConfirmContactName = PartyIdentificationTypeCode.DealConfirmContactName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Department of the trading members.
    /// Encoded/decoded by serializers as &quot;DEPA&quot;.
    /// </summary>
    [EnumMember(Value = "DEPA")]
    [IsoId("_6GsaQYA2EeSUJZYcWGKkkw")]
    [Description(@"Department of the trading members.")]
    Department = PartyIdentificationTypeCode.Department, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies eligible of counterparty.
    /// Encoded/decoded by serializers as &quot;ELCO&quot;.
    /// </summary>
    [EnumMember(Value = "ELCO")]
    [IsoId("_6LMfwYA2EeSUJZYcWGKkkw")]
    [Description(@"Specifies eligible of counterparty.")]
    EligibleCounterparty = PartyIdentificationTypeCode.EligibleCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of execution.
    /// Encoded/decoded by serializers as &quot;EXVE&quot;.
    /// </summary>
    [EnumMember(Value = "EXVE")]
    [IsoId("_6PuacYA2EeSUJZYcWGKkkw")]
    [Description(@"Place of execution.")]
    ExecutionVenue = PartyIdentificationTypeCode.ExecutionVenue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the firm.
    /// Encoded/decoded by serializers as &quot;FICO&quot;.
    /// </summary>
    [EnumMember(Value = "FICO")]
    [IsoId("_6VKUEYA2EeSUJZYcWGKkkw")]
    [Description(@"Specifies the firm.")]
    FirmCode = PartyIdentificationTypeCode.FirmCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the firm.
    /// Encoded/decoded by serializers as &quot;FIID&quot;.
    /// </summary>
    [EnumMember(Value = "FIID")]
    [IsoId("_6bflkYA2EeSUJZYcWGKkkw")]
    [Description(@"Identification of the firm.")]
    FirmIdentification = PartyIdentificationTypeCode.FirmIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal chinese full title of the trading members.
    /// Encoded/decoded by serializers as &quot;FLCN&quot;.
    /// </summary>
    [EnumMember(Value = "FLCN")]
    [IsoId("_6gFxsYA2EeSUJZYcWGKkkw")]
    [Description(@"Legal chinese full title of the trading members.")]
    FullLegalChineseNameOfFirm = PartyIdentificationTypeCode.FullLegalChineseNameOfFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal full title of the trading members.
    /// Encoded/decoded by serializers as &quot;FLNF&quot;.
    /// </summary>
    [EnumMember(Value = "FLNF")]
    [IsoId("_6knsYYA2EeSUJZYcWGKkkw")]
    [Description(@"Legal full title of the trading members.")]
    FullLegalNameOfFirm = PartyIdentificationTypeCode.FullLegalNameOfFirm, // same ordinal as derivation source for type conversions
}
