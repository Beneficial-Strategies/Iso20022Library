// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of account identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CXMoYNtiEeipuvJHTHIw9A")]
[Description(@"Type of account identification.")]
[DerivedFrom(typeof(CardIdentificationTypeCode))]
public enum CardIdentificationType1Code
{
    /// <summary>
    /// Account identification.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_E-KqodtiEeipuvJHTHIw9A")]
    [Description(@"Account identification.")]
    AccountNumber = CardIdentificationTypeCode.AccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bar-code with a specific form of identification.
    /// Encoded/decoded by serializers as &quot;BARC&quot;.
    /// </summary>
    [EnumMember(Value = "BARC")]
    [IsoId("_FCB28dtiEeipuvJHTHIw9A")]
    [Description(@"Bar-code with a specific form of identification.")]
    BarCode = CardIdentificationTypeCode.BarCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ISO Track 2 including identification.
    /// Encoded/decoded by serializers as &quot;ISO2&quot;.
    /// </summary>
    [EnumMember(Value = "ISO2")]
    [IsoId("_FFv5UdtiEeipuvJHTHIw9A")]
    [Description(@"ISO Track 2 including identification.")]
    ISOTrack2 = CardIdentificationTypeCode.ISOTrack2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A phone number identifies the account on which the phone card is assigned.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_FKiSsdtiEeipuvJHTHIw9A")]
    [Description(@"A phone number identifies the account on which the phone card is assigned.")]
    PhoneNumber = CardIdentificationTypeCode.PhoneNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standard card identification (card number).
    /// Encoded/decoded by serializers as &quot;CPAN&quot;.
    /// </summary>
    [EnumMember(Value = "CPAN")]
    [IsoId("_FPHQsdtiEeipuvJHTHIw9A")]
    [Description(@"Standard card identification (card number).")]
    PrimaryAccountNumber = CardIdentificationTypeCode.PrimaryAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An identification set by a privative application.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_FTxHMdtiEeipuvJHTHIw9A")]
    [Description(@"An identification set by a privative application.")]
    PrivativeNumbering = CardIdentificationTypeCode.PrivativeNumbering, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A Universal Unique Identification code is set for identification.
    /// Encoded/decoded by serializers as &quot;UUID&quot;.
    /// </summary>
    [EnumMember(Value = "UUID")]
    [IsoId("_FYiScdtiEeipuvJHTHIw9A")]
    [Description(@"A Universal Unique Identification code is set for identification.")]
    UniversalUniqueIdentification = CardIdentificationTypeCode.UniversalUniqueIdentification, // same ordinal as derivation source for type conversions
    
}
