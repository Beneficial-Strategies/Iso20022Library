// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aHCfdtp-Ed-ak6NoX_4Aeg_-1069011326")]
[Description(@"Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.")]
[Derivations(typeof(PersonIdentificationType3Code))]
public enum PersonIdentificationTypeV2Code
{
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as &quot;CCPT&quot;.
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_aHCfd9p-Ed-ak6NoX_4Aeg_-1026529330")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber,
    
    /// <summary>
    /// Account issued by the Central Provident Fund Board (Singapore).
    /// Encoded/decoded by serializers as &quot;CPFA&quot;.
    /// </summary>
    [EnumMember(Value = "CPFA")]
    [IsoId("_aHCfeNp-Ed-ak6NoX_4Aeg_-1026529329")]
    [Description(@"Account issued by the Central Provident Fund Board (Singapore).")]
    CPFAccountNumber,
    
    /// <summary>
    /// Supplementary retirement scheme account number.
    /// Encoded/decoded by serializers as &quot;SRSA&quot;.
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_aHCfedp-Ed-ak6NoX_4Aeg_-1026529299")]
    [Description(@"Supplementary retirement scheme account number.")]
    SRSAccountNumber,
    
    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as &quot;NRIN&quot;.
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("_aHMQcNp-Ed-ak6NoX_4Aeg_-1026529268")]
    [Description(@"National registration identification number. In Singapore this is known as the NRIC.")]
    NationalRegistrationIdentificationNumber,
    
    /// <summary>
    /// Another type of identification type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aHMQcdp-Ed-ak6NoX_4Aeg_-1026529267")]
    [Description(@"Another type of identification type.")]
    Other,
    
    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_aHMQctp-Ed-ak6NoX_4Aeg_-1026529238")]
    [Description(@"Number assigned by a license authority to a driver's license.")]
    DriversLicenseNumber,
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as &quot;SOCS&quot;.
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_aHMQc9p-Ed-ak6NoX_4Aeg_-1026529207")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber,
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_aHMQdNp-Ed-ak6NoX_4Aeg_-1026528929")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber,
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as &quot;IDCD&quot;.
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_aHMQddp-Ed-ak6NoX_4Aeg_-1026528898")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber,
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as &quot;EMID&quot;.
    /// </summary>
    [EnumMember(Value = "EMID")]
    [IsoId("_aHMQdtp-Ed-ak6NoX_4Aeg_-1026528867")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber,
    
    /// <summary>
    /// Number assigned to a foreign investor (other than the alien number).
    /// Encoded/decoded by serializers as &quot;FINN&quot;.
    /// </summary>
    [EnumMember(Value = "FINN")]
    [IsoId("_aHMQd9p-Ed-ak6NoX_4Aeg_-998823061")]
    [Description(@"Number assigned to a foreign investor (other than the alien number).")]
    ForeignInvestmentIdentityNumber,
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_aHMQeNp-Ed-ak6NoX_4Aeg_-998823000")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber,
    
    /// <summary>
    /// Number assigned to a corporate entity.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_aHWBcNp-Ed-ak6NoX_4Aeg_177812978")]
    [Description(@"Number assigned to a corporate entity.")]
    CorporateIdentification,
    
}
