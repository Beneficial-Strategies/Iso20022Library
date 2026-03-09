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
    /// Choice of meeting type classification.
    /// </summary>
    [KnownType(typeof(MeetingTypeClassification2Choice.Code))]
    [KnownType(typeof(MeetingTypeClassification2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MeetingTypeClassification2Choice.Code),nameof(MeetingTypeClassification2Choice.Code))]
    [JsonDerivedType(typeof(MeetingTypeClassification2Choice.Proprietary),nameof(MeetingTypeClassification2Choice.Proprietary))]
    #endif
    [IsoId("_edv9767NEemG7MmivSuE5g")]
    [DisplayName("Meeting Type Classification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MeetingTypeClassification2Choice_
    #else
    public abstract partial class MeetingTypeClassification2Choice_
    #endif
    {
    }
}
