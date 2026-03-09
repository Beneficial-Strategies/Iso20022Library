// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of the standing instruction request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zi-wJ9p-Ed-ak6NoX_4Aeg_1390539565")]
[Description(@"Specifies the reason of a rejection of the standing instruction request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason20Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Zi-wKNp-Ed-ak6NoX_4Aeg_-482612999")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to identify cash account.
    /// Encoded/decoded by serializers as &quot;CASA&quot;.
    /// </summary>
    [EnumMember(Value = "CASA")]
    [IsoId("_ZjIhINp-Ed-ak6NoX_4Aeg_-482612969")]
    [Description(@"Unable to identify cash account.")]
    NotIdentifiedCashAccount = RejectionReasonCode.NotIdentifiedCashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to identify correspondent bank.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_ZjIhIdp-Ed-ak6NoX_4Aeg_-482612938")]
    [Description(@"Unable to identify correspondent bank.")]
    NotIdentifiedCorrespondentBank = RejectionReasonCode.NotIdentifiedCorrespondentBank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid standing instruction type for the specified underlying security.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_ZjIhItp-Ed-ak6NoX_4Aeg_-482612937")]
    [Description(@"Invalid standing instruction type for the specified underlying security.")]
    InvalidStandingInstructionType = RejectionReasonCode.InvalidStandingInstructionType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No holding for the specified underlying security.
    /// Encoded/decoded by serializers as &quot;NOHO&quot;.
    /// </summary>
    [EnumMember(Value = "NOHO")]
    [IsoId("_ZjIhI9p-Ed-ak6NoX_4Aeg_-482612907")]
    [Description(@"No holding for the specified underlying security.")]
    NoHolding = RejectionReasonCode.NoHolding, // same ordinal as derivation source for type conversions
    
}
