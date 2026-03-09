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
    /// Choice between a code or a proprietary code for a deadline code.
    /// </summary>
    [KnownType(typeof(DeadlineCode1Choice.Code))]
    [KnownType(typeof(DeadlineCode1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DeadlineCode1Choice.Code),nameof(DeadlineCode1Choice.Code))]
    [JsonDerivedType(typeof(DeadlineCode1Choice.Proprietary),nameof(DeadlineCode1Choice.Proprietary))]
    #endif
    [IsoId("_Q0L0CNp-Ed-ak6NoX_4Aeg_1003378554")]
    [DisplayName("Deadline Code 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeadlineCode1Choice_
    #else
    public abstract partial class DeadlineCode1Choice_
    #endif
    {
    }
}
