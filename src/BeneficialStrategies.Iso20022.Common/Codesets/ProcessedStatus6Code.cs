// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of a deactivation instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKxI4tp-Ed-ak6NoX_4Aeg_983077435")]
[Description(@"Specifies the processing status of a deactivation instruction.")]
[DerivedFrom(typeof(CorporateActionProcessedStatusCode))]
public enum ProcessedStatus6Code
{
    /// <summary>
    /// The instruction/request has been received.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_aKxI49p-Ed-ak6NoX_4Aeg_-1149003943")]
    [Description(@"The instruction/request has been received.")]
    Received = CorporateActionProcessedStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting the deactivation date.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_aKxI5Np-Ed-ak6NoX_4Aeg_-1149003942")]
    [Description(@"Awaiting the deactivation date.")]
    WaitingDeactivationDate = CorporateActionProcessedStatusCode.WaitingDeactivationDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The request has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_aKxI5dp-Ed-ak6NoX_4Aeg_-1149003664")]
    [Description(@"The request has been completed.")]
    Completed = CorporateActionProcessedStatusCode.Completed, // same ordinal as derivation source for type conversions
}
