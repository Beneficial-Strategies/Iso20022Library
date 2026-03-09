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
    /// Choice of formats for the legal structure of a financial instrument.
    /// </summary>
    [KnownType(typeof(LegalStructure1Choice.Code))]
    [KnownType(typeof(LegalStructure1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LegalStructure1Choice.Code),nameof(LegalStructure1Choice.Code))]
    [JsonDerivedType(typeof(LegalStructure1Choice.Proprietary),nameof(LegalStructure1Choice.Proprietary))]
    #endif
    [IsoId("_kfzX0DQeEeifw8iDiyZLmQ")]
    [DisplayName("Legal Structure 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LegalStructure1Choice_
    #else
    public abstract partial class LegalStructure1Choice_
    #endif
    {
    }
}
