// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Mode for the financial capture of the transaction by the acquirer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KR_d9H1DEeCF8NjrBemJWQ_948346296")]
[Description(@"Mode for the financial capture of the transaction by the acquirer.")]
[Derivations(typeof(FinancialCapture1Code))]
public enum FinancialCaptureCode
{
    /// <summary>
    /// Financial capture of the transaction is performed by the acquirer during the authorisation exchange.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_KR_d9X1DEeCF8NjrBemJWQ_-1063051555")]
    [Description(
        @"Financial capture of the transaction is performed by the acquirer during the authorisation exchange."
    )]
    Authorisation,

    /// <summary>
    /// Financial capture of the transaction is performed by the acquirer during the completion exchange.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_KR_d9n1DEeCF8NjrBemJWQ_-1355009293")]
    [Description(
        @"Financial capture of the transaction is performed by the acquirer during the completion exchange."
    )]
    Completion,

    /// <summary>
    /// Financial capture of the transaction is performed by the acquirer at the reception of a batch transfer.
    /// Encoded/decoded by serializers as &quot;BTCH&quot;.
    /// </summary>
    [EnumMember(Value = "BTCH")]
    [IsoId("_KR_d931DEeCF8NjrBemJWQ_-1241170227")]
    [Description(
        @"Financial capture of the transaction is performed by the acquirer at the reception of a batch transfer."
    )]
    Batch,
}
