// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Preferred method used to reach the individual contact within an organisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6UHyApqlEeGSON8vddiWzQ_1788250895")]
[Description(@"Preferred method used to reach the individual contact within an organisation.")]
[DerivedFrom(typeof(PreferredContactMethodCode))]
public enum PreferredContactMethod1Code
{
    /// <summary>
    /// Preferred method used to reach the contact is per letter.
    /// Encoded/decoded by serializers as &quot;LETT&quot;.
    /// </summary>
    [EnumMember(Value = "LETT")]
    [IsoId("_6UHyA5qlEeGSON8vddiWzQ_-970786773")]
    [Description(@"Preferred method used to reach the contact is per letter.")]
    Letter = PreferredContactMethodCode.Letter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Preferred method used to reach the contact is per email.
    /// Encoded/decoded by serializers as &quot;MAIL&quot;.
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_6UHyBJqlEeGSON8vddiWzQ_496361990")]
    [Description(@"Preferred method used to reach the contact is per email.")]
    Email = PreferredContactMethodCode.Email, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Preferred method used to reach the contact is per phone.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_6UHyBZqlEeGSON8vddiWzQ_37862079")]
    [Description(@"Preferred method used to reach the contact is per phone.")]
    Phone = PreferredContactMethodCode.Phone, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Preferred method used to reach the contact is per fax.
    /// Encoded/decoded by serializers as &quot;FAXX&quot;.
    /// </summary>
    [EnumMember(Value = "FAXX")]
    [IsoId("_6UHyBpqlEeGSON8vddiWzQ_1934398803")]
    [Description(@"Preferred method used to reach the contact is per fax.")]
    Fax = PreferredContactMethodCode.Fax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Preferred method used to reach the contact is per mobile or cell phone.
    /// Encoded/decoded by serializers as &quot;CELL&quot;.
    /// </summary>
    [EnumMember(Value = "CELL")]
    [IsoId("_6UHyB5qlEeGSON8vddiWzQ_-1355658363")]
    [Description(@"Preferred method used to reach the contact is per mobile or cell phone.")]
    MobileOrCellPhone = PreferredContactMethodCode.MobileOrCellPhone, // same ordinal as derivation source for type conversions
    
}
