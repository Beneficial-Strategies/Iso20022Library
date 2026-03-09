// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Preferred method used to reach the individual contact within an organisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6UHyCJqlEeGSON8vddiWzQ_1695397384")]
[Description(@"Preferred method used to reach the individual contact within an organisation.")]
[Derivations(typeof(PreferredContactMethod1Code))]
public enum PreferredContactMethodCode
{
    /// <summary>
    /// Preferred method used to reach the contact is per letter.
    /// Encoded/decoded by serializers as &quot;LETT&quot;.
    /// </summary>
    [EnumMember(Value = "LETT")]
    [IsoId("_6UHyCZqlEeGSON8vddiWzQ_-1387252991")]
    [Description(@"Preferred method used to reach the contact is per letter.")]
    Letter,
    
    /// <summary>
    /// Preferred method used to reach the contact is per email.
    /// Encoded/decoded by serializers as &quot;MAIL&quot;.
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_6URjAJqlEeGSON8vddiWzQ_-735312912")]
    [Description(@"Preferred method used to reach the contact is per email.")]
    Email,
    
    /// <summary>
    /// Preferred method used to reach the contact is per phone.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_6URjAZqlEeGSON8vddiWzQ_877055563")]
    [Description(@"Preferred method used to reach the contact is per phone.")]
    Phone,
    
    /// <summary>
    /// Preferred method used to reach the contact is per fax.
    /// Encoded/decoded by serializers as &quot;FAXX&quot;.
    /// </summary>
    [EnumMember(Value = "FAXX")]
    [IsoId("_6URjApqlEeGSON8vddiWzQ_-724061441")]
    [Description(@"Preferred method used to reach the contact is per fax.")]
    Fax,
    
    /// <summary>
    /// Preferred method used to reach the contact is per mobile or cell phone.
    /// Encoded/decoded by serializers as &quot;CELL&quot;.
    /// </summary>
    [EnumMember(Value = "CELL")]
    [IsoId("_6URjA5qlEeGSON8vddiWzQ_-2097794174")]
    [Description(@"Preferred method used to reach the contact is per mobile or cell phone.")]
    MobileOrCellPhone,
    
}
