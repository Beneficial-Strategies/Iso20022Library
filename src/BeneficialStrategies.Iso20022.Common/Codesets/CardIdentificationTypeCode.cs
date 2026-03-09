// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of account identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bEGccNthEeipuvJHTHIw9A")]
[Description(@"Type of account identification.")]
[Derivations(typeof(CardIdentificationType1Code))]
public enum CardIdentificationTypeCode
{
    /// <summary>
    /// Standard card identification (card number).
    /// Encoded/decoded by serializers as &quot;CPAN&quot;.
    /// </summary>
    [EnumMember(Value = "CPAN")]
    [IsoId("_hi4dwNthEeipuvJHTHIw9A")]
    [Description(@"Standard card identification (card number).")]
    PrimaryAccountNumber,
    
    /// <summary>
    /// ISO Track 2 including identification.
    /// Encoded/decoded by serializers as &quot;ISO2&quot;.
    /// </summary>
    [EnumMember(Value = "ISO2")]
    [IsoId("_l8QRwNthEeipuvJHTHIw9A")]
    [Description(@"ISO Track 2 including identification.")]
    ISOTrack2,
    
    /// <summary>
    /// Bar-code with a specific form of identification.
    /// Encoded/decoded by serializers as &quot;BARC&quot;.
    /// </summary>
    [EnumMember(Value = "BARC")]
    [IsoId("_pbMd0NthEeipuvJHTHIw9A")]
    [Description(@"Bar-code with a specific form of identification.")]
    BarCode,
    
    /// <summary>
    /// Account identification.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_sVH4UNthEeipuvJHTHIw9A")]
    [Description(@"Account identification.")]
    AccountNumber,
    
    /// <summary>
    /// A phone number identifies the account on which the phone card is assigned.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_vOcO0NthEeipuvJHTHIw9A")]
    [Description(@"A phone number identifies the account on which the phone card is assigned.")]
    PhoneNumber,
    
    /// <summary>
    /// A Universal Unique Identification code is set for identification.
    /// Encoded/decoded by serializers as &quot;UUID&quot;.
    /// </summary>
    [EnumMember(Value = "UUID")]
    [IsoId("_yacQwNthEeipuvJHTHIw9A")]
    [Description(@"A Universal Unique Identification code is set for identification.")]
    UniversalUniqueIdentification,
    
    /// <summary>
    /// An identification set by a privative application.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_9ra1wNthEeipuvJHTHIw9A")]
    [Description(@"An identification set by a privative application.")]
    PrivativeNumbering,
    
}
