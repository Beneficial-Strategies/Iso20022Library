// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwxQFdp-Ed-ak6NoX_4Aeg_905354341")]
[Description(@"Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.")]
[Derivations(typeof(TypeOfIdentification1Code),typeof(TypeOfIdentification2Code),typeof(TypeOfIdentification4Code))]
public enum TypeOfIdentificationCode
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_YwxQFtp-Ed-ak6NoX_4Aeg_905354351")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber,
    
    /// <summary>
    /// Number assigned by a passport authority.
    /// Encoded/decoded by serializers as &quot;CCPT&quot;.
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_YwxQF9p-Ed-ak6NoX_4Aeg_905354359")]
    [Description(@"Number assigned by a passport authority.")]
    PassportNumber,
    
    /// <summary>
    /// Number assigned to a tax exempt entity.
    /// Encoded/decoded by serializers as &quot;CHTY&quot;.
    /// </summary>
    [EnumMember(Value = "CHTY")]
    [IsoId("_YwxQGNp-Ed-ak6NoX_4Aeg_905354360")]
    [Description(@"Number assigned to a tax exempt entity.")]
    TaxExemptIdentificationNumber,
    
    /// <summary>
    /// Number assigned to a corporate entity.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_Yw6aANp-Ed-ak6NoX_4Aeg_905354601")]
    [Description(@"Number assigned to a corporate entity.")]
    CorporateIdentification,
    
    /// <summary>
    /// Number assigned to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_Yw6aAdp-Ed-ak6NoX_4Aeg_905354602")]
    [Description(@"Number assigned to a driver's license.")]
    DriverLicenseNumber,
    
    /// <summary>
    /// Number assigned to a foreign investor (other than the alien number).
    /// Encoded/decoded by serializers as &quot;FIIN&quot;.
    /// </summary>
    [EnumMember(Value = "FIIN")]
    [IsoId("_Yw6aAtp-Ed-ak6NoX_4Aeg_905354618")]
    [Description(@"Number assigned to a foreign investor (other than the alien number).")]
    ForeignInvestmentIdentityNumber,
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_Yw6aA9p-Ed-ak6NoX_4Aeg_905354619")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber,
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as &quot;SOCS&quot;.
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_fo6owId2EemJ1cSJJmVYRQ")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber,
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as &quot;IDCD&quot;.
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_sexg4Id2EemJ1cSJJmVYRQ")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber,
    
    /// <summary>
    /// Number assigned by an issuer to identify a customer via the concatenation of the birthdate and characters of the first name and surname. 
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_FUN7AId4EemJ1cSJJmVYRQ")]
    [Description(@"Number assigned by an issuer to identify a customer via the concatenation of the birthdate and characters of the first name and surname. ")]
    Concat,
    
    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as &quot;NRIN&quot;.
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("__xeOUI6BEemzmeK8_tPygg")]
    [Description(@"National registration identification number. In Singapore this is known as the NRIC.")]
    NationalRegistrationIdentificationNumber,
    
}
