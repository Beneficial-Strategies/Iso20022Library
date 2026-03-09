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
    /// Choice between a code or a data source scheme to determine the closing of the securities lending contract.
    /// </summary>
    [KnownType(typeof(Reversible1Choice.Code))]
    [KnownType(typeof(Reversible1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reversible1Choice.Code),nameof(Reversible1Choice.Code))]
    [JsonDerivedType(typeof(Reversible1Choice.Proprietary),nameof(Reversible1Choice.Proprietary))]
    #endif
    [IsoId("_AYOIONokEeC60axPepSq7g_-1179089003")]
    [DisplayName("Reversible 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reversible1Choice_
    #else
    public abstract partial class Reversible1Choice_
    #endif
    {
    }
}
