// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Preferred method used to reach the individual contact within an organisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OQ1V0DIDEe6mzvR3CHiUhA")]
[Description(@"Preferred method used to reach the individual contact within an organisation.")]
[DerivedFrom(typeof(PreferredContactMethodCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PreferredContactMethod2Code>))]
public enum PreferredContactMethod2Code
{
    /// <summary>
    /// Preferred method used to reach the contact is per mobile or cell phone.
    /// Encoded/decoded by serializers as &quot;CELL&quot;.
    /// </summary>
    [EnumMember(Value = "CELL")]
    [IsoId("_RyuIMTIDEe6mzvR3CHiUhA")]
    [Description(@"Preferred method used to reach the contact is per mobile or cell phone.")]
    MobileOrCellPhone = PreferredContactMethodCode.MobileOrCellPhone, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preferred method used to reach the contact is per fax.
    /// Encoded/decoded by serializers as &quot;FAXX&quot;.
    /// </summary>
    [EnumMember(Value = "FAXX")]
    [IsoId("_RoX5YTIDEe6mzvR3CHiUhA")]
    [Description(@"Preferred method used to reach the contact is per fax.")]
    Fax = PreferredContactMethodCode.Fax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preferred method used to reach the contact is per letter.
    /// Encoded/decoded by serializers as &quot;LETT&quot;.
    /// </summary>
    [EnumMember(Value = "LETT")]
    [IsoId("_RtfC4TIDEe6mzvR3CHiUhA")]
    [Description(@"Preferred method used to reach the contact is per letter.")]
    Letter = PreferredContactMethodCode.Letter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preferred method used to reach the contact is per email.
    /// Encoded/decoded by serializers as &quot;MAIL&quot;.
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_Ri2gMTIDEe6mzvR3CHiUhA")]
    [Description(@"Preferred method used to reach the contact is per email.")]
    Email = PreferredContactMethodCode.Email, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preferred method used to reach the contact is online.
    /// Encoded/decoded by serializers as &quot;ONLI&quot;.
    /// </summary>
    [EnumMember(Value = "ONLI")]
    [IsoId("_R3wZMTIDEe6mzvR3CHiUhA")]
    [Description(@"Preferred method used to reach the contact is online.")]
    Online = PreferredContactMethodCode.Online, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preferred method used to reach the contact is per phone.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_R8yqMTIDEe6mzvR3CHiUhA")]
    [Description(@"Preferred method used to reach the contact is per phone.")]
    Phone = PreferredContactMethodCode.Phone, // same ordinal as derivation source for type conversions
}
