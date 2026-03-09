// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKeN9dp-Ed-ak6NoX_4Aeg_966452193")]
[Description(@"Specifies the processing status of a cancellation request.")]
[DerivedFrom(typeof(CorporateActionProcessedStatusCode))]
public enum ProcessedStatus2Code
{
    /// <summary>
    /// The instruction/request has been received.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_aKeN9tp-Ed-ak6NoX_4Aeg_1837333616")]
    [Description(@"The instruction/request has been received.")]
    Received = CorporateActionProcessedStatusCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The request has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_aKeN99p-Ed-ak6NoX_4Aeg_1837333617")]
    [Description(@"The request has been completed.")]
    Completed = CorporateActionProcessedStatusCode.Completed, // same ordinal as derivation source for type conversions
    
}
