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
    [KnownType(typeof(MeetingTypeClassification1Choice.Code))]
    [KnownType(typeof(MeetingTypeClassification1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MeetingTypeClassification1Choice.Code),nameof(MeetingTypeClassification1Choice.Code))]
    [JsonDerivedType(typeof(MeetingTypeClassification1Choice.Proprietary),nameof(MeetingTypeClassification1Choice.Proprietary))]
    #endif
    [IsoId("_RDrokNp-Ed-ak6NoX_4Aeg_843703595")]
    [DisplayName("Meeting Type Classification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MeetingTypeClassification1Choice_
    #else
    public abstract partial class MeetingTypeClassification1Choice_
    #endif
    {
    }
}
