// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zi1mMdp-Ed-ak6NoX_4Aeg_-296003228")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason1Code
{
    /// <summary>
    /// Instruction received after the account servicers specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Zi1mMtp-Ed-ak6NoX_4Aeg_-219351513")]
    [Description(@"Instruction received after the account servicers specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Zi1mM9p-Ed-ak6NoX_4Aeg_-192568846")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Zi1mNNp-Ed-ak6NoX_4Aeg_-126077469")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonCode.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_Zi1mNdp-Ed-ak6NoX_4Aeg_-106680134")]
    [Description(@"Position is less than required threshold.")]
    InsufficientTresholdPosition = RejectionReasonCode.InsufficientTresholdPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_Zi1mNtp-Ed-ak6NoX_4Aeg_646909701")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonCode.LackofSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction contains an invalid or unrecognised safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Zi1mN9p-Ed-ak6NoX_4Aeg_680157992")]
    [Description(@"Instruction contains an invalid or unrecognised safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonCode.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer or Registrar has rejected the instruction.
    /// Encoded/decoded by serializers as &quot;RBIS&quot;.
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_Zi1mONp-Ed-ak6NoX_4Aeg_705093323")]
    [Description(@"Issuer or Registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar = RejectionReasonCode.RejectedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised event number or identification (eg corporate action event number, a meeting identification).
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_Zi1mOdp-Ed-ak6NoX_4Aeg_766044307")]
    [Description(@"Unrecognised event number or identification (eg corporate action event number, a meeting identification).")]
    UnrecognizedIdentification = RejectionReasonCode.UnrecognizedIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction contains an invalid message reference, reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Zi-wINp-Ed-ak6NoX_4Aeg_1032018093")]
    [Description(@"Instruction contains an invalid message reference, reference is unknown.")]
    InvalidReference = RejectionReasonCode.InvalidReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_Zi-wIdp-Ed-ak6NoX_4Aeg_1047717799")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy = RejectionReasonCode.ProxyCardDiscrepancy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_Zi-wItp-Ed-ak6NoX_4Aeg_1068961790")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed = RejectionReasonCode.PartialVoteNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_Zi-wI9p-Ed-ak6NoX_4Aeg_1080964521")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed = RejectionReasonCode.SplitVoteNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_Zi-wJNp-Ed-ak6NoX_4Aeg_1104977941")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA = RejectionReasonCode.MissingOrInvalidPOA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid registration information.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_Zi-wJdp-Ed-ak6NoX_4Aeg_1667403767")]
    [Description(@"Invalid registration information.")]
    RegistrationDiscrepancy = RejectionReasonCode.RegistrationDiscrepancy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Zi-wJtp-Ed-ak6NoX_4Aeg_1926910316")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonCode.InvalidSecurity, // same ordinal as derivation source for type conversions
    
}
