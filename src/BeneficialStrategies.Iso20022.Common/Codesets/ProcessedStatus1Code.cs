// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of the notification advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKeN8Np-Ed-ak6NoX_4Aeg_985847288")]
[Description(@"Specifies the processing status of the notification advice.")]
[DerivedFrom(typeof(CorporateActionProcessedStatusCode))]
public enum ProcessedStatus1Code
{
    /// <summary>
    /// The instruction/request has been received.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_aKeN8dp-Ed-ak6NoX_4Aeg_-236563833")]
    [Description(@"The instruction/request has been received.")]
    Received = CorporateActionProcessedStatusCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The advice has been sent to the market.
    /// Encoded/decoded by serializers as &quot;SENT&quot;.
    /// </summary>
    [EnumMember(Value = "SENT")]
    [IsoId("_aKeN8tp-Ed-ak6NoX_4Aeg_-236563832")]
    [Description(@"The advice has been sent to the market.")]
    SentToMarket = CorporateActionProcessedStatusCode.SentToMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The announcement has been accepted but another source has provided different information.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_aKeN89p-Ed-ak6NoX_4Aeg_-236563803")]
    [Description(@"The announcement has been accepted but another source has provided different information.")]
    AcceptedWithWarning = CorporateActionProcessedStatusCode.AcceptedWithWarning, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The request is accepted.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aKeN9Np-Ed-ak6NoX_4Aeg_-236563802")]
    [Description(@"The request is accepted.")]
    Accepted = CorporateActionProcessedStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
}
