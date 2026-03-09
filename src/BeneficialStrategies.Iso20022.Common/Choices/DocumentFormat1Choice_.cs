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
    /// Choice of format for the type of document format.
    /// </summary>
    [KnownType(typeof(DocumentFormat1Choice.Code))]
    [KnownType(typeof(DocumentFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DocumentFormat1Choice.Code),nameof(DocumentFormat1Choice.Code))]
    [JsonDerivedType(typeof(DocumentFormat1Choice.Proprietary),nameof(DocumentFormat1Choice.Proprietary))]
    #endif
    [IsoId("_932rtHltEeG7BsjMvd1mEw_-1666043325")]
    [DisplayName("Document Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DocumentFormat1Choice_
    #else
    public abstract partial class DocumentFormat1Choice_
    #endif
    {
    }
}
