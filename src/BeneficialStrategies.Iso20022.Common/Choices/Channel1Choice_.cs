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
    /// Choice of format for the submission channel.
    /// </summary>
    [KnownType(typeof(Channel1Choice.Code))]
    [KnownType(typeof(Channel1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Channel1Choice.Code),nameof(Channel1Choice.Code))]
    [JsonDerivedType(typeof(Channel1Choice.Proprietary),nameof(Channel1Choice.Proprietary))]
    #endif
    [IsoId("_93Z_wHltEeG7BsjMvd1mEw_-1487139441")]
    [DisplayName("Channel 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Channel1Choice_
    #else
    public abstract partial class Channel1Choice_
    #endif
    {
    }
}
