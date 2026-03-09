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
    /// De minimus applicability conditions.
    /// </summary>
    [KnownType(typeof(DeMinimus1Choice.DeMinimusApplicable))]
    [KnownType(typeof(DeMinimus1Choice.DeMinimusNotApplicable))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DeMinimus1Choice.DeMinimusApplicable),nameof(DeMinimus1Choice.DeMinimusApplicable))]
    [JsonDerivedType(typeof(DeMinimus1Choice.DeMinimusNotApplicable),nameof(DeMinimus1Choice.DeMinimusNotApplicable))]
    #endif
    [IsoId("_8saXYAgpEeSUG-8hqXsVMQ")]
    [DisplayName("De Minimus 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeMinimus1Choice_
    #else
    public abstract partial class DeMinimus1Choice_
    #endif
    {
    }
}
