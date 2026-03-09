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
    /// Choice of format for the allegment reason.
    /// </summary>
    [KnownType(typeof(AllegmentReason1Choice.Code))]
    [KnownType(typeof(AllegmentReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AllegmentReason1Choice.Code),nameof(AllegmentReason1Choice.Code))]
    [JsonDerivedType(typeof(AllegmentReason1Choice.Proprietary),nameof(AllegmentReason1Choice.Proprietary))]
    #endif
    [IsoId("_A4j1INokEeC60axPepSq7g_-73094806")]
    [DisplayName("Allegment Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AllegmentReason1Choice_
    #else
    public abstract partial class AllegmentReason1Choice_
    #endif
    {
    }
}
