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
    /// Specifies the status of an entry on the books of the account servicer.
    /// </summary>
    [KnownType(typeof(EntryStatus1Choice.Code))]
    [KnownType(typeof(EntryStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EntryStatus1Choice.Code),nameof(EntryStatus1Choice.Code))]
    [JsonDerivedType(typeof(EntryStatus1Choice.Proprietary),nameof(EntryStatus1Choice.Proprietary))]
    #endif
    [IsoId("_DICS8IaoEeeUws0ZryHQ2w")]
    [DisplayName("Entry Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EntryStatus1Choice_
    #else
    public abstract partial class EntryStatus1Choice_
    #endif
    {
    }
}
