// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Action associated with a result.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aDorwJ1AEeeuzZPGP9QqVw")]
[Description(@"Action associated with a result.")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType11Code
{
    /// <summary>
    /// Contact card issuer.
    /// Encoded/decoded by serializers as &quot;CNTI&quot;.
    /// </summary>
    [EnumMember(Value = "CNTI")]
    [IsoId("_nHJlYZ1AEeeuzZPGP9QqVw")]
    [Description(@"Contact card issuer.")]
    ContactIssuer = ActionTypeCode.ContactIssuer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refer to card issuer&apos;s special conditions.
    /// Encoded/decoded by serializers as &quot;CNIS&quot;.
    /// </summary>
    [EnumMember(Value = "CNIS")]
    [IsoId("_nR3AkZ1AEeeuzZPGP9QqVw")]
    [Description(@"Refer to card issuer's special conditions.")]
    ContactIssuerSpecialConditions = ActionTypeCode.ContactIssuerSpecialConditions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact acquirer.
    /// Encoded/decoded by serializers as &quot;CNTA&quot;.
    /// </summary>
    [EnumMember(Value = "CNTA")]
    [IsoId("_oM7hsZ1AEeeuzZPGP9QqVw")]
    [Description(@"Contact acquirer.")]
    ContactAcquirer = ActionTypeCode.ContactAcquirer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card acceptor to call acquirer&apos;s security department.
    /// Encoded/decoded by serializers as &quot;CNAS&quot;.
    /// </summary>
    [EnumMember(Value = "CNAS")]
    [IsoId("_oZbFkZ1AEeeuzZPGP9QqVw")]
    [Description(@"Card acceptor to call acquirer's security department.")]
    ContactAcquirerSecurity = ActionTypeCode.ContactAcquirerSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_pwdJ8Z1AEeeuzZPGP9QqVw")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional verification of cardholder required.
    /// Encoded/decoded by serializers as &quot;CHDV&quot;.
    /// </summary>
    [EnumMember(Value = "CHDV")]
    [IsoId("_qebDMZ1AEeeuzZPGP9QqVw")]
    [Description(@"Additional verification of cardholder required.")]
    CardholderVerification = ActionTypeCode.CardholderVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manage account as a VIP one.
    /// Encoded/decoded by serializers as &quot;VIPM&quot;.
    /// </summary>
    [EnumMember(Value = "VIPM")]
    [IsoId("_sG3nsZ1AEeeuzZPGP9QqVw")]
    [Description(@"Manage account as a VIP one.")]
    VIPAccountManagement = ActionTypeCode.VIPAccountManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Track provided in the response must be updated on the card.
    /// Encoded/decoded by serializers as &quot;TRCK&quot;.
    /// </summary>
    [EnumMember(Value = "TRCK")]
    [IsoId("_tVHjgZ1AEeeuzZPGP9QqVw")]
    [Description(@"Track provided in the response must be updated on the card.")]
    UpdateTrack = ActionTypeCode.UpdateTrack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction to be re-entered.
    /// Encoded/decoded by serializers as &quot;TRXR&quot;.
    /// </summary>
    [EnumMember(Value = "TRXR")]
    [IsoId("_uWb2kZ1AEeeuzZPGP9QqVw")]
    [Description(@"Transaction to be re-entered.")]
    ReEnterTransaction = ActionTypeCode.ReEnterTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other action defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_2qgToZ1CEeeuzZPGP9QqVw")]
    [Description(@"Other action defined at national level.")]
    OtherNational = ActionTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other action defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_21Nu0Z1CEeeuzZPGP9QqVw")]
    [Description(@"Other action defined at private level")]
    OtherPrivate = ActionTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Signature required.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_q7b14J54EeqkBIJTZMHl2Q")]
    [Description(@"Signature required.")]
    Signature = ActionTypeCode.Signature, // same ordinal as derivation source for type conversions
    
}
