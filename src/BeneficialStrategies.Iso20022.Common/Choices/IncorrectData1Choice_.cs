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
    /// Specifies the incorrect data type.
    /// </summary>
    [KnownType(typeof(IncorrectData1Choice.Code))]
    [KnownType(typeof(IncorrectData1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IncorrectData1Choice.Code),nameof(IncorrectData1Choice.Code))]
    [JsonDerivedType(typeof(IncorrectData1Choice.Proprietary),nameof(IncorrectData1Choice.Proprietary))]
    #endif
    [IsoId("_Dfigo9jLEeq5MfBBxQig1Q")]
    [DisplayName("Incorrect Data 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IncorrectData1Choice_
    #else
    public abstract partial class IncorrectData1Choice_
    #endif
    {
    }
}
