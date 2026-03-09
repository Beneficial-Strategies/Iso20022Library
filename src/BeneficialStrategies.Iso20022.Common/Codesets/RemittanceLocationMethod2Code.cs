// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used to deliver the remittance advice information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZsX8tNp-Ed-ak6NoX_4Aeg_-517543090")]
[Description(@"Specifies the method used to deliver the remittance advice information.")]
[DerivedFrom(typeof(RemittanceLocationMethodCode))]
public enum RemittanceLocationMethod2Code
{
    /// <summary>
    /// Remittance advice information must be faxed.
    /// Encoded/decoded by serializers as &quot;FAXI&quot;.
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_ZsX8tdp-Ed-ak6NoX_4Aeg_-517543060")]
    [Description(@"Remittance advice information must be faxed.")]
    Fax = RemittanceLocationMethodCode.Fax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance advice information must be sent through Electronic Data Interchange (EDI).
    /// Encoded/decoded by serializers as &quot;EDIC&quot;.
    /// </summary>
    [EnumMember(Value = "EDIC")]
    [IsoId("_ZsX8ttp-Ed-ak6NoX_4Aeg_-517543029")]
    [Description(@"Remittance advice information must be sent through Electronic Data Interchange (EDI).")]
    ElectronicDataInterchange = RemittanceLocationMethodCode.ElectronicDataInterchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance advice information needs to be sent to a Uniform Resource Identifier (URI). URI is a compact string of characters that uniquely identify an abstract or physical resource. URI&apos;s are the super-set of identifiers, such as URLs, email addresses, ftp sites, etc, and as such, provide the syntax for all of the identification schemes.
    /// Encoded/decoded by serializers as &quot;URID&quot;.
    /// </summary>
    [EnumMember(Value = "URID")]
    [IsoId("_ZsX8t9p-Ed-ak6NoX_4Aeg_-517543028")]
    [Description(@"Remittance advice information needs to be sent to a Uniform Resource Identifier (URI). URI is a compact string of characters that uniquely identify an abstract or physical resource. URI's are the super-set of identifiers, such as URLs, email addresses, ftp sites, etc, and as such, provide the syntax for all of the identification schemes.")]
    UniformResourceIdentifier = RemittanceLocationMethodCode.UniformResourceIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance advice information must be sent through e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_ZsX8uNp-Ed-ak6NoX_4Aeg_-517542998")]
    [Description(@"Remittance advice information must be sent through e-mail.")]
    EMail = RemittanceLocationMethodCode.EMail, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance advice information must be sent through postal services.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_ZsX8udp-Ed-ak6NoX_4Aeg_-517542968")]
    [Description(@"Remittance advice information must be sent through postal services.")]
    Post = RemittanceLocationMethodCode.Post, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance advice information must be sent through by phone as a short message service (SMS).
    /// Encoded/decoded by serializers as &quot;SMSM&quot;.
    /// </summary>
    [EnumMember(Value = "SMSM")]
    [IsoId("_ZshGoNp-Ed-ak6NoX_4Aeg_-333762381")]
    [Description(@"Remittance advice information must be sent through by phone as a short message service (SMS).")]
    SMS = RemittanceLocationMethodCode.SMS, // same ordinal as derivation source for type conversions
    
}
