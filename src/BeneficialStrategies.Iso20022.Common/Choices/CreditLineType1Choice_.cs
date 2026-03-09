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
    /// Specifies the type of the credit line provided.
    /// </summary>
    [KnownType(typeof(CreditLineType1Choice.Code))]
    [KnownType(typeof(CreditLineType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CreditLineType1Choice.Code),nameof(CreditLineType1Choice.Code))]
    [JsonDerivedType(typeof(CreditLineType1Choice.Proprietary),nameof(CreditLineType1Choice.Proprietary))]
    #endif
    [IsoId("_2T3LxIZ5Eee8r9VKRbnJSg")]
    [DisplayName("Credit Line Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CreditLineType1Choice_
    #else
    public abstract partial class CreditLineType1Choice_
    #endif
    {
    }
}
