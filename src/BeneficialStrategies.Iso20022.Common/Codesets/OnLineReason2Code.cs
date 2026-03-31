// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason to process an online authorisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3n55AU4LEey_VecAUE-C9Q")]
[Description(@"Reason to process an online authorisation.")]
[DerivedFrom(typeof(OnLineReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OnLineReason2Code>))]
#endif
public enum OnLineReason2Code
{
    /// <summary>
    /// Transaction random selection to go online.
    /// Encoded/decoded by serializers as &quot;RNDM&quot;.
    /// </summary>
    [EnumMember(Value = "RNDM")]
    [IsoId("_3vH7UU4LEey_VecAUE-C9Q")]
    [Description(@"Transaction random selection to go online.")]
    RandomSelection = OnLineReasonCode.RandomSelection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment application in the Integrated Circuit Card forces to go on-line.
    /// Encoded/decoded by serializers as &quot;ICCF&quot;.
    /// </summary>
    [EnumMember(Value = "ICCF")]
    [IsoId("_3vH7U04LEey_VecAUE-C9Q")]
    [Description(@"Payment application in the Integrated Circuit Card forces to go on-line.")]
    ICCForced = OnLineReasonCode.ICCForced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// On line forced by card acceptor.
    /// Encoded/decoded by serializers as &quot;MERF&quot;.
    /// </summary>
    [EnumMember(Value = "MERF")]
    [IsoId("_3vH7VU4LEey_VecAUE-C9Q")]
    [Description(@"On line forced by card acceptor.")]
    MerchantForced = OnLineReasonCode.MerchantForced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal random selection to go online.
    /// Encoded/decoded by serializers as &quot;TRMF&quot;.
    /// </summary>
    [EnumMember(Value = "TRMF")]
    [IsoId("_3vH7V04LEey_VecAUE-C9Q")]
    [Description(@"Terminal random selection to go online.")]
    TerminalForced = OnLineReasonCode.TerminalForced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// On line forced by card issuer.
    /// Encoded/decoded by serializers as &quot;ISSF&quot;.
    /// </summary>
    [EnumMember(Value = "ISSF")]
    [IsoId("_3vH7WU4LEey_VecAUE-C9Q")]
    [Description(@"On line forced by card issuer.")]
    IssuerForced = OnLineReasonCode.IssuerForced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Over floor limit.
    /// Encoded/decoded by serializers as &quot;FRLT&quot;.
    /// </summary>
    [EnumMember(Value = "FRLT")]
    [IsoId("_3vH7W04LEey_VecAUE-C9Q")]
    [Description(@"Over floor limit.")]
    FloorLimit = OnLineReasonCode.FloorLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card appears on terminal exception file.
    /// Encoded/decoded by serializers as &quot;EXFL&quot;.
    /// </summary>
    [EnumMember(Value = "EXFL")]
    [IsoId("_3vH7XU4LEey_VecAUE-C9Q")]
    [Description(@"Card appears on terminal exception file.")]
    ExceptionFile = OnLineReasonCode.ExceptionFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total amount of purchases per cardholder and per application above floor limit.
    /// Encoded/decoded by serializers as &quot;TAMT&quot;.
    /// </summary>
    [EnumMember(Value = "TAMT")]
    [IsoId("_3vH7X04LEey_VecAUE-C9Q")]
    [Description(
        @"Total amount of purchases per cardholder and per application above floor limit."
    )]
    TotalAmount = OnLineReasonCode.TotalAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Identification Number under control.
    /// Encoded/decoded by serializers as &quot;CBIN&quot;.
    /// </summary>
    [EnumMember(Value = "CBIN")]
    [IsoId("_3vH7YU4LEey_VecAUE-C9Q")]
    [Description(@"Bank Identification Number under control.")]
    ControlledBIN = OnLineReasonCode.ControlledBIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown Bank Identification Number.
    /// Encoded/decoded by serializers as &quot;UBIN&quot;.
    /// </summary>
    [EnumMember(Value = "UBIN")]
    [IsoId("_3vH7Y04LEey_VecAUE-C9Q")]
    [Description(@"Unknown Bank Identification Number.")]
    UnknownBIN = OnLineReasonCode.UnknownBIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Primary account number (card number) under control.
    /// Encoded/decoded by serializers as &quot;CPAN&quot;.
    /// </summary>
    [EnumMember(Value = "CPAN")]
    [IsoId("_3vH7ZU4LEey_VecAUE-C9Q")]
    [Description(@"Primary account number (card number) under control.")]
    ControlledPAN = OnLineReasonCode.ControlledPAN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Flow control.
    /// Encoded/decoded by serializers as &quot;FLOW&quot;.
    /// </summary>
    [EnumMember(Value = "FLOW")]
    [IsoId("_3vH7Z04LEey_VecAUE-C9Q")]
    [Description(@"Flow control.")]
    FlowControl = OnLineReasonCode.FlowControl, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown currency code or foreign currency.
    /// Encoded/decoded by serializers as &quot;CRCY&quot;.
    /// </summary>
    [EnumMember(Value = "CRCY")]
    [IsoId("_3vH7aU4LEey_VecAUE-C9Q")]
    [Description(@"Unknown currency code or foreign currency.")]
    UnavailableCurrency = OnLineReasonCode.UnavailableCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request Cardholder Authentication througth PIN insertion
    /// Encoded/decoded by serializers as &quot;IFPR&quot;.
    /// </summary>
    [EnumMember(Value = "IFPR")]
    [IsoId("_9wKQsE4LEey_VecAUE-C9Q")]
    [Description(@"Request Cardholder Authentication througth PIN insertion")]
    IssuerForcedPINRequest = OnLineReasonCode.IssuerForcedPINRequest, // same ordinal as derivation source for type conversions
}
