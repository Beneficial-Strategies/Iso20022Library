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
    /// Choice between a predefined code value or a proprietary code value for a general meeting voting participation method. 
    /// </summary>
    [KnownType(typeof(ParticipationMethod1Choice.Code))]
    [KnownType(typeof(ParticipationMethod1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ParticipationMethod1Choice.Code),nameof(ParticipationMethod1Choice.Code))]
    [JsonDerivedType(typeof(ParticipationMethod1Choice.Proprietary),nameof(ParticipationMethod1Choice.Proprietary))]
    #endif
    [IsoId("_X1CUoK31EemG7MmivSuE5g")]
    [DisplayName("Participation Method 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ParticipationMethod1Choice_
    #else
    public abstract partial class ParticipationMethod1Choice_
    #endif
    {
    }
}
