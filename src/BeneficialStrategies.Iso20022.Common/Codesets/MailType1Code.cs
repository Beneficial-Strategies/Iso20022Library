// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of mail service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gpYLECCXEeWJd9HF2tO7BA")]
[Description(@"Specifies the type of mail service.")]
[DerivedFrom(typeof(MailTypeCode))]
public enum MailType1Code
{
    /// <summary>
    /// Air mail.
    /// Encoded/decoded by serializers as &quot;AIRM&quot;.
    /// </summary>
    [EnumMember(Value = "AIRM")]
    [IsoId("_jWjjASCXEeWJd9HF2tO7BA")]
    [Description(@"Air mail.")]
    AirMail = MailTypeCode.AirMail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ordinary mail.
    /// Encoded/decoded by serializers as &quot;ORDM&quot;.
    /// </summary>
    [EnumMember(Value = "ORDM")]
    [IsoId("_jdi70SCXEeWJd9HF2tO7BA")]
    [Description(@"Ordinary mail.")]
    OrdinaryMail = MailTypeCode.OrdinaryMail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Registered Mail.
    /// Encoded/decoded by serializers as &quot;REGM&quot;.
    /// </summary>
    [EnumMember(Value = "REGM")]
    [IsoId("_jkZKsSCXEeWJd9HF2tO7BA")]
    [Description(@"Registered Mail.")]
    RegisteredMail = MailTypeCode.RegisteredMail, // same ordinal as derivation source for type conversions
}
