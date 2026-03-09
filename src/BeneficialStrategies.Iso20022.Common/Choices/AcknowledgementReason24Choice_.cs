// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason24Choice.Code))]
    [KnownType(typeof(AcknowledgementReason24Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcknowledgementReason24Choice.Code),nameof(AcknowledgementReason24Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason24Choice.Proprietary),nameof(AcknowledgementReason24Choice.Proprietary))]
    #endif
    [IsoId("_H2g1cZwZEeqtp-LOti013g")]
    [DisplayName("Acknowledgement Reason 24 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcknowledgementReason24Choice_
    #else
    public abstract partial class AcknowledgementReason24Choice_
    #endif
    {
    }
}
