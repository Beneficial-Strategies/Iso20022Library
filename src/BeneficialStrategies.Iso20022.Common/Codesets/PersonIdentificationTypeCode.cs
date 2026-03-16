// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aG5VhNp-Ed-ak6NoX_4Aeg_1157186363")]
[Description(
    @"Specifies an alternative identification of an individual person, for example, national registration identification number, passport number."
)]
[Derivations(
    typeof(PersonIdentificationType2Code),
    typeof(PersonIdentificationType6Code),
    typeof(PartyIdentificationType7Code),
    typeof(PersonIdentificationType7Code),
    typeof(PersonIdentificationType4Code),
    typeof(PersonIdentificationType1Code),
    typeof(PersonIdentificationType5Code)
)]
public enum PersonIdentificationTypeCode
{
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_aG5Vhdp-Ed-ak6NoX_4Aeg_1218140653")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber,

    /// <summary>
    /// Account issued by the Central Provident Fund Board (Singapore).
    /// Encoded/decoded by serializers as &quot;CPFA&quot;.
    /// </summary>
    [EnumMember(Value = "CPFA")]
    [IsoId("_aG5Vhtp-Ed-ak6NoX_4Aeg_1230147055")]
    [Description(@"Account issued by the Central Provident Fund Board (Singapore).")]
    CPFAccountNumber,

    /// <summary>
    /// Supplementary retirement scheme account number.
    /// Encoded/decoded by serializers as &quot;SRSA&quot;.
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_aG5Vh9p-Ed-ak6NoX_4Aeg_1248616162")]
    [Description(@"Supplementary retirement scheme account number.")]
    SRSAccountNumber,

    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as &quot;NRIN&quot;.
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("_aG5ViNp-Ed-ak6NoX_4Aeg_1273549056")]
    [Description(
        @"National registration identification number. In Singapore this is known as the NRIC."
    )]
    NationalRegistrationIdentificationNumber,

    /// <summary>
    /// Another type of identification type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aHCfcNp-Ed-ak6NoX_4Aeg_1286479435")]
    [Description(@"Another type of identification type.")]
    Other,

    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_aHCfcdp-Ed-ak6NoX_4Aeg_89548299")]
    [Description(@"Number assigned by a license authority to a driver's license.")]
    DriversLicenseNumber,

    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as &quot;SOCS&quot;.
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_aHCfctp-Ed-ak6NoX_4Aeg_89548317")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber,

    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;AREG&quot;.
    /// </summary>
    [EnumMember(Value = "AREG")]
    [IsoId("_aHCfc9p-Ed-ak6NoX_4Aeg_89548334")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber,

    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as &quot;IDCD&quot;.
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_aHCfdNp-Ed-ak6NoX_4Aeg_95089905")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber,

    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as &quot;EMID&quot;.
    /// </summary>
    [EnumMember(Value = "EMID")]
    [IsoId("_aHCfddp-Ed-ak6NoX_4Aeg_95089922")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber,

    /// <summary>
    /// Driver number, assigned by the fleet manager.
    /// Encoded/decoded by serializers as &quot;DRVR&quot;.
    /// </summary>
    [EnumMember(Value = "DRVR")]
    [IsoId("_TZESYAEcEeCQm6a_G2yO_w_883476316")]
    [Description(@"Driver number, assigned by the fleet manager.")]
    DriverNumber,

    /// <summary>
    /// Employee number assigned by the company.
    /// Encoded/decoded by serializers as &quot;EEID&quot;.
    /// </summary>
    [EnumMember(Value = "EEID")]
    [IsoId("_TZESYQEcEeCQm6a_G2yO_w_1815250358")]
    [Description(@"Employee number assigned by the company.")]
    EmployeeNumber,

    /// <summary>
    /// Gun license number as assigned by a gun licensing authority.
    /// Encoded/decoded by serializers as &quot;GUNL&quot;.
    /// </summary>
    [EnumMember(Value = "GUNL")]
    [IsoId("_dhJyUFASEeKdE_ZuDLMHLA_1124149451")]
    [Description(@"Gun license number as assigned by a gun licensing authority.")]
    GunLicenseNumber,

    /// <summary>
    /// Post office card number as assigned by a national post office.
    /// Encoded/decoded by serializers as &quot;POCD&quot;.
    /// </summary>
    [EnumMember(Value = "POCD")]
    [IsoId("_dhTjUFASEeKdE_ZuDLMHLA_-2120692470")]
    [Description(@"Post office card number as assigned by a national post office.")]
    PostOfficeCardNumber,

    /// <summary>
    /// Temporary tax processing number (used in the domestic adoption of a child).
    /// Encoded/decoded by serializers as &quot;ATIN&quot;.
    /// </summary>
    [EnumMember(Value = "ATIN")]
    [IsoId("_xpyHoGXEEeSrv8256XoCZg")]
    [Description(@"Temporary tax processing number (used in the domestic adoption of a child).")]
    AdoptionTaxpayerIdentificationNumber,

    /// <summary>
    /// Tax processing number.
    /// Encoded/decoded by serializers as &quot;ITIN&quot;.
    /// </summary>
    [EnumMember(Value = "ITIN")]
    [IsoId("_x1FYsGXEEeSrv8256XoCZg")]
    [Description(@"Tax processing number.")]
    IndividualTaxpayerIdentificationNumber,

    /// <summary>
    /// Generic tax identification number.
    /// Encoded/decoded by serializers as &quot;GTIN&quot;.
    /// </summary>
    [EnumMember(Value = "GTIN")]
    [IsoId("_x6ljwGXEEeSrv8256XoCZg")]
    [Description(@"Generic tax identification number.")]
    GenericTaxIdentificationNumber,

    /// <summary>
    /// Global intermediary tax identification number.
    /// Encoded/decoded by serializers as &quot;GIIN&quot;.
    /// </summary>
    [EnumMember(Value = "GIIN")]
    [IsoId("_IyzkQCCnEeWJd9HF2tO7BA")]
    [Description(@"Global intermediary tax identification number.")]
    GlobalIntermediaryIdentificationNumber,

    /// <summary>
    /// Number that identifies the type of investor registered at a securities and exchange commission.
    /// Encoded/decoded by serializers as &quot;NINV&quot;.
    /// </summary>
    [EnumMember(Value = "NINV")]
    [IsoId("_a3p-ECDZEeWCLu74WLgP4w")]
    [Description(
        @"Number that identifies the type of investor registered at a securities and exchange commission."
    )]
    NonResidentInvestor,

    /// <summary>
    /// Number, typically assigned by a government to describe ownership, administrative and authoritative relations.
    /// Encoded/decoded by serializers as &quot;INCL&quot;.
    /// </summary>
    [EnumMember(Value = "INCL")]
    [IsoId("_kfymsCMuEeWw25nezi_B1g")]
    [Description(
        @"Number, typically assigned by a government to describe ownership, administrative and authoritative relations."
    )]
    IndustryClassification,
}
