// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason to process an online authorisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TU5kIAEcEeCQm6a_G2yO_w_329831590")]
[Description(@"Reason to process an online authorisation.")]
[Derivations(typeof(OnLineReason1Code), typeof(OnLineReason2Code))]
public enum OnLineReasonCode
{
    /// <summary>
    /// Transaction random selection to go online.
    /// Encoded/decoded by serializers as &quot;RNDM&quot;.
    /// </summary>
    [EnumMember(Value = "RNDM")]
    [IsoId("_TU5kIQEcEeCQm6a_G2yO_w_1923311799")]
    [Description(@"Transaction random selection to go online.")]
    RandomSelection,

    /// <summary>
    /// Payment application in the Integrated Circuit Card forces to go on-line.
    /// Encoded/decoded by serializers as &quot;ICCF&quot;.
    /// </summary>
    [EnumMember(Value = "ICCF")]
    [IsoId("_TU5kIgEcEeCQm6a_G2yO_w_-1245846943")]
    [Description(@"Payment application in the Integrated Circuit Card forces to go on-line.")]
    ICCForced,

    /// <summary>
    /// On line forced by card acceptor.
    /// Encoded/decoded by serializers as &quot;MERF&quot;.
    /// </summary>
    [EnumMember(Value = "MERF")]
    [IsoId("_TVCuAAEcEeCQm6a_G2yO_w_674120094")]
    [Description(@"On line forced by card acceptor.")]
    MerchantForced,

    /// <summary>
    /// Terminal random selection to go online.
    /// Encoded/decoded by serializers as &quot;TRMF&quot;.
    /// </summary>
    [EnumMember(Value = "TRMF")]
    [IsoId("_TVCuAQEcEeCQm6a_G2yO_w_-247585585")]
    [Description(@"Terminal random selection to go online.")]
    TerminalForced,

    /// <summary>
    /// On line forced by card issuer.
    /// Encoded/decoded by serializers as &quot;ISSF&quot;.
    /// </summary>
    [EnumMember(Value = "ISSF")]
    [IsoId("_TVCuAgEcEeCQm6a_G2yO_w_1284522022")]
    [Description(@"On line forced by card issuer.")]
    IssuerForced,

    /// <summary>
    /// Over floor limit.
    /// Encoded/decoded by serializers as &quot;FRLT&quot;.
    /// </summary>
    [EnumMember(Value = "FRLT")]
    [IsoId("_TVCuAwEcEeCQm6a_G2yO_w_1786397507")]
    [Description(@"Over floor limit.")]
    FloorLimit,

    /// <summary>
    /// Card appears on terminal exception file.
    /// Encoded/decoded by serializers as &quot;EXFL&quot;.
    /// </summary>
    [EnumMember(Value = "EXFL")]
    [IsoId("_TVCuBAEcEeCQm6a_G2yO_w_-736533613")]
    [Description(@"Card appears on terminal exception file.")]
    ExceptionFile,

    /// <summary>
    /// Total amount of purchases per cardholder and per application above floor limit.
    /// Encoded/decoded by serializers as &quot;TAMT&quot;.
    /// </summary>
    [EnumMember(Value = "TAMT")]
    [IsoId("_TVCuBQEcEeCQm6a_G2yO_w_-390515156")]
    [Description(
        @"Total amount of purchases per cardholder and per application above floor limit."
    )]
    TotalAmount,

    /// <summary>
    /// Bank Identification Number under control.
    /// Encoded/decoded by serializers as &quot;CBIN&quot;.
    /// </summary>
    [EnumMember(Value = "CBIN")]
    [IsoId("_TVCuBgEcEeCQm6a_G2yO_w_-768504377")]
    [Description(@"Bank Identification Number under control.")]
    ControlledBIN,

    /// <summary>
    /// Unknown Bank Identification Number.
    /// Encoded/decoded by serializers as &quot;UBIN&quot;.
    /// </summary>
    [EnumMember(Value = "UBIN")]
    [IsoId("_TVCuBwEcEeCQm6a_G2yO_w_-314417108")]
    [Description(@"Unknown Bank Identification Number.")]
    UnknownBIN,

    /// <summary>
    /// Primary account number (card number) under control.
    /// Encoded/decoded by serializers as &quot;CPAN&quot;.
    /// </summary>
    [EnumMember(Value = "CPAN")]
    [IsoId("_TVCuCAEcEeCQm6a_G2yO_w_811391446")]
    [Description(@"Primary account number (card number) under control.")]
    ControlledPAN,

    /// <summary>
    /// Flow control.
    /// Encoded/decoded by serializers as &quot;FLOW&quot;.
    /// </summary>
    [EnumMember(Value = "FLOW")]
    [IsoId("_TVCuCQEcEeCQm6a_G2yO_w_-800606403")]
    [Description(@"Flow control.")]
    FlowControl,

    /// <summary>
    /// Unknown currency code or foreign currency.
    /// Encoded/decoded by serializers as &quot;CRCY&quot;.
    /// </summary>
    [EnumMember(Value = "CRCY")]
    [IsoId("_TVCuCgEcEeCQm6a_G2yO_w_1210676022")]
    [Description(@"Unknown currency code or foreign currency.")]
    UnavailableCurrency,

    /// <summary>
    /// Request Cardholder Authentication througth PIN insertion
    /// Encoded/decoded by serializers as &quot;IFPR&quot;.
    /// </summary>
    [EnumMember(Value = "IFPR")]
    [IsoId("_MFRxkE4LEey_VecAUE-C9Q")]
    [Description(@"Request Cardholder Authentication througth PIN insertion")]
    IssuerForcedPINRequest,
}
