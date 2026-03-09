// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a depositary receipt processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_av4BFNp-Ed-ak6NoX_4Aeg_-1629994281")]
[Description(@"Specifies the status of a depositary receipt processing.")]
[DerivedFrom(typeof(DepositaryReceiptProcessingStatusCode))]
public enum DepositaryReceiptProcessingStatus1Code
{
    /// <summary>
    /// No record of the transaction for which a status is requested.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_av4BFdp-Ed-ak6NoX_4Aeg_-1629994249")]
    [Description(@"No record of the transaction for which a status is requested.")]
    NoRecordFound = DepositaryReceiptProcessingStatusCode.NoRecordFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Depositary receipt is pending completion.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_av4BFtp-Ed-ak6NoX_4Aeg_-1629994248")]
    [Description(@"Depositary receipt is pending completion.")]
    Pending = DepositaryReceiptProcessingStatusCode.Pending, // same ordinal as derivation source for type conversions
    
}
