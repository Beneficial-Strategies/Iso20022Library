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
    /// Choice between a reason or no reason for the corporate action event processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus59Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus59Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus59Choice.NoSpecifiedReason),nameof(PendingStatus59Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus59Choice.Reason),nameof(PendingStatus59Choice.Reason))]
    #endif
    [IsoId("_Szi6YgVREeqjd8n6wD9JVw")]
    [DisplayName("Pending Status 59 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus59Choice_
    #else
    public abstract partial class PendingStatus59Choice_
    #endif
    {
    }
}
