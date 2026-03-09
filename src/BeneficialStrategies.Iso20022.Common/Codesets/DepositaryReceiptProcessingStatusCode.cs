// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a depositary receipt processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_av4BF9p-Ed-ak6NoX_4Aeg_1948323043")]
[Description(@"Specifies the status of a depositary receipt processing.")]
[Derivations(typeof(DepositaryReceiptProcessingStatus1Code))]
public enum DepositaryReceiptProcessingStatusCode
{
    /// <summary>
    /// No record of the transaction for which a status is requested.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_av4BGNp-Ed-ak6NoX_4Aeg_-2060352164")]
    [Description(@"No record of the transaction for which a status is requested.")]
    NoRecordFound,
    
    /// <summary>
    /// Depositary receipt is pending completion.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_awBLANp-Ed-ak6NoX_4Aeg_-2058506616")]
    [Description(@"Depositary receipt is pending completion.")]
    Pending,
    
}
