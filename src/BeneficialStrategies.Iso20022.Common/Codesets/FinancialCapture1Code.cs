// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Mode for the financial capture of the transaction by the acquirer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KR_d8H1DEeCF8NjrBemJWQ_1904132354")]
[Description(@"Mode for the financial capture of the transaction by the acquirer.")]
[DerivedFrom(typeof(FinancialCaptureCode))]
public enum FinancialCapture1Code
{
    /// <summary>
    /// Financial capture of the transaction is performed by the acquirer during the authorisation exchange.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_KR_d8X1DEeCF8NjrBemJWQ_-344306152")]
    [Description(
        @"Financial capture of the transaction is performed by the acquirer during the authorisation exchange."
    )]
    Authorisation = FinancialCaptureCode.Authorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial capture of the transaction is performed by the acquirer during the completion exchange.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_KR_d8n1DEeCF8NjrBemJWQ_1190732522")]
    [Description(
        @"Financial capture of the transaction is performed by the acquirer during the completion exchange."
    )]
    Completion = FinancialCaptureCode.Completion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial capture of the transaction is performed by the acquirer at the reception of a batch transfer.
    /// Encoded/decoded by serializers as &quot;BTCH&quot;.
    /// </summary>
    [EnumMember(Value = "BTCH")]
    [IsoId("_KR_d831DEeCF8NjrBemJWQ_-1673145279")]
    [Description(
        @"Financial capture of the transaction is performed by the acquirer at the reception of a batch transfer."
    )]
    Batch = FinancialCaptureCode.Batch, // same ordinal as derivation source for type conversions
}
